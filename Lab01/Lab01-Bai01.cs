using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Lab01
{
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void textBox_num1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                DialogResult Notification = MessageBox.Show("Dữ liệu nhập vào không phải là số nguyên hợp lệ. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_num1.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }

            if (e.KeyChar == '-' && ((sender as TextBox).SelectionStart != 0 || (sender as TextBox).Text.Contains("-")))
            {
                e.Handled = true;
                DialogResult Notification = MessageBox.Show("Dấu trừ chỉ được nhập ở đầu số. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                DialogResult Notification = MessageBox.Show("Dữ liệu nhập vào không phải là số nguyên hợp lệ. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_num2.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }

            if (e.KeyChar == '-' && ((sender as TextBox).SelectionStart != 0 || (sender as TextBox).Text.Contains("-")))
            {
                e.Handled = true;
                DialogResult Notification = MessageBox.Show("Dấu trừ chỉ được nhập ở đầu số. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                int num1 = Int32.Parse(textBox_num1.Text);
                int num2 = Int32.Parse(textBox_num2.Text);
                long sum = 0;
                sum = num1 + num2;
                textBox_sum.Text = sum.ToString();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult Notification = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Notification == DialogResult.Yes)
            {
                textBox_num1.Text = "";
                textBox_num2.Text = "";
                textBox_sum.Text = "";
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
