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
    }
}