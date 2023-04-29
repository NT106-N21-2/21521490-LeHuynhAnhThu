using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai01
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button_client_Click(object sender, EventArgs e)
        {
            UDPClient formClient = new UDPClient();
            formClient.Show();
            button_client.Enabled = false;
        }

        private void button_server_Click(object sender, EventArgs e)
        {
            UDPServer formServer = new UDPServer();
            formServer.Show();
            button_server.Enabled = false;
        }
    }
}
