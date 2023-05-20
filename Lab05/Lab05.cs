namespace Lab05
{
    public partial class Lab05 : Form
    {
        public Lab05()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab05_Bai01 f1 = new Lab05_Bai01();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab05_Bai02 f2 = new Lab05_Bai02();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab05_Bai03 f3 = new Lab05_Bai03();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Lab05_Bai04 f4 = new Lab05_Bai04();
            //f4.ShowDialog();
        }
    }
}