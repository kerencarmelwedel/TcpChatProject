using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using Common;

//namespace Server
////{
//    class ChatHandler
//    {
//        public void HandleClient(TcpClient client)
//        {
//            // Handle multiple clients concurrently
//            new Thread(() =>
//            {
//                // Get the stream through which we can read and send data
//                NetworkStream stream = client.GetStream();
//                //StreamReader reader = new StreamReader(stream);
//                SoapFormatter formatter = new SoapFormatter();
//                StreamWriter writer = new StreamWriter(stream);
//                Message messageContent = (Message)formatter.Deserialize(stream);
//            });
//        }
//    }

//}

      

