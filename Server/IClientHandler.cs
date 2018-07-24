using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{

    public delegate void IClientEventHandler(IClientHandler sender, string message);
 
        public class IClientHandler  // mennage connumication between server and specific client
        {
           public string UserName { get; set; }
        
            public event IClientEventHandler userConnected;
            public event IClientEventHandler userDisconnected;
            public event IClientEventHandler userSentMessage;

            private TcpClient client;
          

        public void sendMessage(string msg)
            {

                StreamWriter writer = new StreamWriter(client.GetStream());
                writer.WriteLine(msg);
                writer.Flush();

            }


            public IClientHandler(TcpClient client)
            {
                this.client = client;
            }

        public string Username;
            //{ get { return this.userName; } }


            public void HandleClient()
            {

                // Get the stream through which we can read and send data
                NetworkStream stream = client.GetStream();
                StreamReader reader = new StreamReader(stream);
                try
                {
                    // get message from client (userName)
                    string UserName = reader.ReadLine();
                    this.UserName = UserName;

                    //raise event - user connected
                    userConnected(this, this.UserName + " has connected");

                    string messageRecieved;

                    // get messages from client (until client disconnected)
                    // for each message - send it to everyone
                    while (true)
                    {
                        // read message from network
                        messageRecieved = reader.ReadLine();

                        // users has disconnected
                        if (messageRecieved == null || messageRecieved == string.Empty)
                        {
                            userDisconnected(this, this.UserName + " has disconnected");

                            break;
                        }


                        userSentMessage(this, UserName + " Said:" + messageRecieved);
                    }

                }
                catch { }
                finally
                {

                    reader.Close();
                    stream.Close();
                }

            }
            public void disconnect()
            {
                client.Close();
                client = null;
            }
        }
 }

   

