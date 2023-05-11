namespace Lab04
{
    public partial class Lab04 : Form
    {
        public Lab04()
        {
            InitializeComponent();
        }

        private void Bai01_Click(object sender, EventArgs e)
        {
            Lab04_Bai01 f1 = new Lab04_Bai01();
            f1.Show();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            Lab04_Bai03 f3 = new Lab04_Bai03();

            f3.Show();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            Lab04_Bai05 f5 = new Lab04_Bai05();
            f5.Show();
        }
    }
}