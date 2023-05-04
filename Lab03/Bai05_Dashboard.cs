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
    public partial class Bai05_Dashboard : Form
    {
        public Bai05_Dashboard()
        {
            InitializeComponent();
        }

        private void button_server_Click(object sender, EventArgs e)
        {
            // Show the server form
            Bai05_ServerForm serverForm = new Bai05_ServerForm();
            serverForm.Show();
        }

        private void button_client_Click(object sender, EventArgs e)
        {
            // Show the client form
            Bai05_ClientForm clientForm = new Bai05_ClientForm();
            clientForm.Show();
        }
    }
}
