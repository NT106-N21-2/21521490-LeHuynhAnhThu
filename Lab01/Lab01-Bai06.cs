using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        private void textBox_num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                DialogResult Notification = MessageBox.Show("Dữ liệu nhập vào không hợp lệ! Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_num1.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }
        }

        private void textBox_num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                DialogResult Notification = MessageBox.Show("Dữ liệu nhập vào không hợp lệ! Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_num2.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }
        }

        public int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        public int Sum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        public int SuperSum(int a, int b)
        {
            int sum = 0;
            for (int i = 1; i <= b; i++)
            {
                sum += (int)Math.Pow(a, i);
            }
            return sum;
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            if (textBox_num1.Text.Length == 0 || textBox_num2.Text.Length == 0)
            {
                DialogResult Notification = MessageBox.Show("Thiếu dữ liệu để có thể thực hiện phép tính. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_num1.Text = "";
                    textBox_num2.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }
            else
            {
                int A = Int32.Parse(textBox_num1.Text);
                int B = Int32.Parse(textBox_num2.Text);

                int factorialA = Factorial(A);
                int factorialB = Factorial(B);

                int sumA = Sum(A);
                int sumB = Sum(B);

                int superSumA = SuperSum(A, B);

                listView_result.Clear();
                listView_result.Items.Add("A! = " + factorialA);
                listView_result.Items.Add("B! = " + factorialB);
                listView_result.Items.Add("S1 = " + sumA);
                listView_result.Items.Add("S2 = " + sumB);
                listView_result.Items.Add("S3 = " + superSumA);
            }
        }



        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult Notification = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Notification == DialogResult.Yes)
            {
                textBox_num1.Text = "";
                textBox_num2.Text = "";
                listView_result.Clear();
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult Notification = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Notification == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
