using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai05
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button_server_Click(object sender, EventArgs e)
        {
            // Show the server form
            ServerForm serverForm = new ServerForm();
            serverForm.Show();
        }

        private void button_client_Click(object sender, EventArgs e)
        {
            // Show the client form
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }
    }
}
