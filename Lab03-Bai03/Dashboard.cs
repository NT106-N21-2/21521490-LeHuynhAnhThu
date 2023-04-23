using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai03
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TCP_Client f1 = new TCP_Client();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TCP_Server f2 = new TCP_Server();
            f2.Show();
        }
    }
}
