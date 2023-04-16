using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02 : Form
    {
        public Lab02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab02_Bai01 f2 = new Lab02_Bai01();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab02_Bai02 f3 = new Lab02_Bai02();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab02_Bai03 f4 = new Lab02_Bai03();
            f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab02_Bai04 f5 = new Lab02_Bai04();
            f5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab02_Bai05 f6 = new Lab02_Bai05();
            f6.ShowDialog();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Lab02_Bai06 f7 = new Lab02_Bai06();
            f7.ShowDialog();
        }
    }
}
