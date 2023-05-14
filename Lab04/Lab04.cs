using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Lab04 : Form
    {
        public Lab04()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab04_Bai01 f2 = new Lab04_Bai01();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab04_Bai02 f3 = new Lab04_Bai02();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab04_Bai03 f4 = new Lab04_Bai03();
            f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab04_Bai04 f5 = new Lab04_Bai04();
            f5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab04_Bai05 f6 = new Lab04_Bai05();
            f6.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab04_Bai06 f7 = new Lab04_Bai06();
            f7.ShowDialog();
        }

        private void Lab04_Load(object sender, EventArgs e)
        {

        }
    }
}
