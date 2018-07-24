using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
   public class ServerSide
    {
        public event EventHandler<string> UserConected;
        public event EventHandler<string> UserDisconnected;
        public event EventHandler<string> UserSentMessage;

        private Dictionary<string, IClientHandler> connectedUsers;
        private Dictionary<IClientHandler, Thread> threads;
        private BinaryFormatter bFormatter;

        private IPEndPoint ep;
        //private IClientHandler clientHandler;
        private TcpListener listener;

        public ServerSide(string ip, int port)
        {
            // Define the address of the server
            IPAddress address = IPAddress.Parse(ip);
            ep = new IPEndPoint(address, port);
            connectedUsers = new Dictionary<string, IClientHandler>();
            threads = new Dictionary<IClientHandler, Thread>();

        }

        public void Start()
        {
            // Start listening on the address
            listener = new TcpListener(ep);
            listener.Start();

            // Accept a new connection
            Console.WriteLine("Listening...");

            new Thread(() =>
            {
                NewMethod();
            }).Start();
        }

        private void NewMethod()
        {
            // This server generates a new connection for each client
            while (true)
            {
               TcpClient client= listener.AcceptTcpClient();
            
               // waiting for client that wants to connect and accept it
                client = listener.AcceptTcpClient();
              //  try
                {
                  Console.WriteLine("Client connected");
                    // handle this client (seperate thread)
                    IClientHandler currClientHandler = new IClientHandler(client);
                    currClientHandler.userConnected += CurrClientHandler_userConnected;
                    currClientHandler.userDisconnected += CurrClientHandler_userDisconnected;
                    currClientHandler.userSentMessage += CurrClientHandler_userSentMessage;
                    System.Threading.ThreadStart ts = new System.Threading.ThreadStart(currClientHandler.HandleClient);
                    System.Threading.Thread t = new System.Threading.Thread(ts);
                    t.Start();

                }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //   }
            }
        }

        private void CurrClientHandler_userSentMessage(IClientHandler sender, string MessageContent)
        {
            IClientHandler c = sender;
            Console.WriteLine(c.UserName + " sending message: " + MessageContent);
            sendMessageToAllUsers(c, MessageContent);

            // notifty the graphics
            UserSentMessage(this, MessageContent);
        }

        private void CurrClientHandler_userDisconnected(IClientHandler sender, string MessageContent)
        {
            IClientHandler c = sender;
            connectedUsers.Remove(c.UserName);
            Console.WriteLine(c.UserName + " has disconnected");

            sendMessageToAllUsers(c, MessageContent);

            // notifty the graphics
            UserDisconnected(this, c.UserName);
        }

        private void CurrClientHandler_userConnected(IClientHandler sender, string MessageContent)
        {
            IClientHandler c = sender;
            connectedUsers.Add(c.UserName, c);

            Console.WriteLine(c.UserName + " has connected");

            // send message to all users
            sendMessageToAllUsers(c, MessageContent);

            // notifty the graphics
            UserConected(this, c.UserName);
        }

        private void sendMessageToAllUsers(IClientHandler sendingUser, string MessageContent)
        {
            IClientHandler c = sendingUser;

            Console.WriteLine(c.UserName + " sendMessageToAllUsers message: " + MessageContent);


            foreach (KeyValuePair<string, IClientHandler> currUser in connectedUsers)
            {
                if (c != currUser.Value)
                {
                    try
                    {
                        currUser.Value.sendMessage(MessageContent);

                    }
                    catch
                    {
                        Console.WriteLine("error sending message to: " + currUser.Key);
                    }
                }
            }
        }

            
            public void Stop()
            {
                connectedUsers.Clear();
                listener.Stop();
            }
    }
}


