using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using Common;
using System.Drawing;

namespace Client
{
    public class ClientSide
    {
        public delegate void IClientEHandler(ClientSide c, string MessageContent);
        public event IClientEHandler MessageRecieved;
        public event IClientEHandler ServerDisconnected;

        private TcpClient client;
        private StreamWriter writer;

        private IPEndPoint ep;
        public string Ip { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }

        private NetworkStream stream;
        private StreamReader reader;
        public Color ClientColor;
        //public ClientSide() { }

        public ClientSide(string ip, int port, Color ClientColor, string userName)
        {
            // Define the address of the server
            IPAddress address = IPAddress.Parse(ip);
            ep = new IPEndPoint(address, port);
            Ip = ip;
            Port = port;
            this.UserName = userName;
        }


        public bool Connect(string ip, int port)
        {
            // Define the address of the server
            IPAddress address = IPAddress.Parse(ip);
            IPEndPoint ep = new IPEndPoint(address, port);
            try
            {
                client = new TcpClient();
                client.Connect(ep);
                stream = client.GetStream();
                writer = new StreamWriter(stream);
                reader = new StreamReader(stream);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Cant connect to server...");
                return false;
            }

        }
        public void Diconnect()
        {
            client.Close();
        }



        public void SendMessage( string UserName, string Color, string MessageContent )
        {
            // Connect to server
            TcpClient client = new TcpClient();
            try
            {
                client.Connect(ep);
            }


            catch (Exception)
            {
                throw new Exception("Server is offline. Try again later");
            }
            
            // Get the stream from the tcp client
            NetworkStream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);
            //StreamWriter writer = new StreamWriter(stream);  
            SoapFormatter formatter = new SoapFormatter();

            // Send message to the server
            formatter.Serialize(stream, MessageContent);
         
            
            //reader.Close();
            //writer.Close();
            //stream.Close();
            //client.Close();
        }
        public void sendMessageToServer(string MessageContent)
        {


            writer.WriteLine(MessageContent);
            writer.Flush();

        }

        public void handleMessagesFromServer()
        {

            while (client.Connected)
            {
                // get message from client (userName)
                string MessageContent = reader.ReadLine();

                if (MessageContent == null || MessageContent == string.Empty)

                {
                    ServerDisconnected(this, null);
                    break;
                }
                MessageRecieved(this, MessageContent);
                Console.WriteLine("message recieved = " + MessageContent);
            }
        }
        // Enumeration that define the type of message
        public enum MessageType { Error, Warning, Info }

        [Serializable]
        public class Message
        {
            private MessageType _messageType;
            private string messageTitle;
            private string messageContent;

            public Message(string title, string contents, MessageType type)
            {
                this.Title = title;
                this.Contents = contents;
                this.Type = type;
            }

            public MessageType Type
            {
                get
                {
                    return this._messageType;
                }
                set
                {
                    this._messageType = value;
                }
            }

            public string Title
            {
                get
                {
                    return this.messageTitle;
                }
                set
                {
                    this.messageTitle = value;
                }
            }

            public string Contents
            {
                get
                {
                    return this.messageContent;
                }
                set
                {
                    this.messageContent = value;
                }
            }
        }

    }
}
 