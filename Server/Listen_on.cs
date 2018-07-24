using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    
    public partial class Listen_on : Form
    {
     //   IClientHandler clientHandler;
        private ServerSide myServer;
        public Listen_on()
        {
            InitializeComponent();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           myServer = new ServerSide(IpTextBox1.Text, int.Parse(textPort.Text));
        
           ConnectedClients f = new ConnectedClients(myServer);
            this.Hide();
           f.ShowDialog();

            myServer = null;
            this.Show();
        }

        private void Listen_on_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listen_on_Load(object sender, EventArgs e)
        {

        }
    }
}
