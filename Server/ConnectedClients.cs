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

namespace Server
{
    public partial class ConnectedClients : Form
    {
        private ServerSide myServer ;
        Thread t;
        public ConnectedClients(ServerSide mySer)
        {
            InitializeComponent();
            myServer = mySer;
            myServer.UserConected += MyServer_UserConected;
            myServer.UserDisconnected += MyServer_UserDisconnected;
            myServer.UserSentMessage += MyServer_UserSentMessage;
        }

        private  void MyServer_UserSentMessage(object sender, string e)
        {
            this.txtHistory.Invoke((MethodInvoker)delegate {

                txtHistory.Text += e + " " + DateTime.Now.ToString() + "\r\n";
            });
        }

        private void MyServer_UserDisconnected(object sender, string e)
        {

            Console.WriteLine(e + " has disconnected");


            this.tabControlViews.Invoke((MethodInvoker)delegate {
                // Running on the UI thread

                for (int i = 0; i < listConnected.Items.Count; i++)

                {
                    if (listConnected.Items[i].SubItems[0].Text == e)
                    {
                        listConnected.Items.RemoveAt(i);
                        break;
                    }
                }

                txtHistory.Text += e + " has disconnected at " + DateTime.Now.ToString() + "\r\n";
            });
        }

        private void MyServer_UserConected(object sender, string e)
        {
            Console.WriteLine(e + " has connected");



            string[] row = { e, "Connected", DateTime.Now.ToString() };
            ListViewItem listViewItem = new ListViewItem(row);

            this.tabControlViews.Invoke((MethodInvoker)delegate
            {
                // Running on the UI thread
                listConnected.Items.Add(listViewItem);
                txtHistory.Text += e + " has connected at " + DateTime.Now.ToString() + "\r\n";
            });

        }
            private void ConnectedClients_Load(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(myServer.Start));
            t.Start();
        }

        private void ConnectedClients_FormClosed(object sender, FormClosedEventArgs e)
        {
            myServer.Stop();
            t.Abort();
        }
    }
}
