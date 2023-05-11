namespace Lab04
{
    public partial class Lab04 : Form
    {
        public Lab04()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab04_Bai02 f2 = new Lab04_Bai02();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab04_Bai04 f4 = new Lab04_Bai04();
            f4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab04_Bai01 f1 = new Lab04_Bai01();
            f1.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Lab04_Bai03 f3 = new Lab04_Bai03();
            f3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab04_Bai05 f5 = new Lab04_Bai05();
            f5.ShowDialog();
        }

      
        private void Lab04_Load(object sender, EventArgs e)
        {
           
        }

      
    }
}