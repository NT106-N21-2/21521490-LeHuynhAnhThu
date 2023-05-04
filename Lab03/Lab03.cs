using Lab03_Bai01;
using Lab03_Bai02;
using Lab03_Bai03;
//using Lab03_Bai04;
using Lab03_Bai05;

namespace Lab03
{
    public partial class Lab03 : Form
    {
        public Lab03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai01_Dashboard f2 = new Bai01_Dashboard();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai02_Telnet f3 = new Bai02_Telnet();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai03_Dashboard f4 = new Bai03_Dashboard();
            f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai04_Dashboard f5 = new Bai04_Dashboard();
            f5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai05_Dashboard f6 = new Bai05_Dashboard();
            f6.ShowDialog();
        }

        private void Lab03_Load(object sender, EventArgs e)
        {

        }
    }
}