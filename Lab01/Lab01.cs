namespace Lab01
{
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab01_Bai01 f2 = new Lab01_Bai01();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab01_Bai02 f3 = new Lab01_Bai02();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab01_Bai03 f4 = new Lab01_Bai03();
            f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab01_Bai04 f5 = new Lab01_Bai04();
            f5.ShowDialog();
        }

        private void Lab01_Load(object sender, EventArgs e)
        {

        }
    }
}