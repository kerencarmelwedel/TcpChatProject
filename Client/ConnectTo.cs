using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ConnectTo : Form
    {
        private ClientSide Client;
        Color ClientColor = Color.Black;
        public Chat chatting;
        public ConnectTo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ConnectTo_Load(object sender, EventArgs e)
        {

        }

        private void IpTextBox1_TextChanged(object sender, EventArgs e)
        {
       //    string Ip = IpTextBox1.Text;

        }

        private void PortUpDown_ValueChanged(object sender, EventArgs e)
        {
      //      int port = (int)PortUpDown.Value;
        }

        private void changeColor(object sender, EventArgs e)
        {


        }

        private void OkButton1_Click(object sender, EventArgs e)
        {
            string ip = IpTextBox1.Text;
            int port = (int)PortUpDown.Value;
            string UserName= NickNametextBox2.Text;
            //send to clientSide?
            ClientSide Client = new ClientSide(ip, port, ClientColor, UserName);
     //       chatting = new Chat(Client, ClientColor, NickNametextBox2.Text);
            bool res = Client.Connect(ip, port);
            Client.sendMessageToServer(UserName);
            if (!res)
            {
                MessageBox.Show("Cant connect to server");
                return;
            }
      //     ConnectedClients f = new ConnectedClients(ClientColor, UserName.Text, client);
          this.Hide();
           chatting.Show();
                         
        }

        private void NickNametextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeColor(object sender, MouseEventArgs e)
        {
            DialogResult res = colorDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                ColorTextBox3.BackColor = colorDialog1.Color;
                ClientColor = colorDialog1.Color;
            }
        }
    }
}
