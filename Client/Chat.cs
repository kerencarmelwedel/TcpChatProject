using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Chat : Form
    {

        public Color myColor;
        public string myUserName;
        private ClientSide Client;
        Thread t;
        public Chat(ClientSide  c, Color clinetColor, string userName)
        {
            InitializeComponent();
            myColor = clinetColor;
            myUserName = userName;
 
           Client = c;
            this.Text += " - " + myUserName;
            Client.MessageRecieved += Client_MessageRecieved;
            Client.ServerDisconnected += Client_ServerDisconnected;

            //c.sendMessageToServer(myUserName);
            //t = new Thread(new ThreadStart(c.handleMessagesFromServer));
            //t.Start();

        }
        private void Client_ServerDisconnected(ClientSide c, string MessageContent)
        {
            MessageBox.Show("Lost connection with server. Bye..");
            this.Invoke((MethodInvoker)delegate {
                // Running on the UI thread

                this.Close();

            });

        }

        private void Client_MessageRecieved(ClientSide sender, string MessageContent)
        {
            try
            {
                this.ChatListMessages.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread

                    ChatListMessages.Items.Add(MessageContent);

                });
                //Console.WriteLine(e);
            }
            catch
            {
                Console.WriteLine("Error receiving message from server..");
            }
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0} Connected ", Client.UserName);
            label1.ForeColor = myColor;
        }

        private void ChatListMessages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Chat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Client.Diconnect();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Client.sendMessageToServer(textInput.Text);
                ListViewItem lv = ChatListMessages.Items.Add(myUserName + " Said: " + textInput.Text);
                lv.ForeColor = myColor;

            }
            catch
            {
                MessageBox.Show("Cant send message to server..");

            }
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

            //i want it to take the name from username which is textBox2 in "ConnectTo"
            //label1.Text = String.Format(" Connected {0}", textInput.Text, myColor);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
