using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Lab06 : Form
    {
        public Lab06()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab06_Bai01 f2 = new Lab06_Bai01();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab06_Bai02 f3 = new Lab06_Bai02();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai03_Dashboard f4 = new Bai03_Dashboard();
            f4.ShowDialog();
        }
    }
}
