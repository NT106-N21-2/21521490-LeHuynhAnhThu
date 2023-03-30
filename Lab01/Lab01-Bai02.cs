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
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void textBox_num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                e.Handled = true;
                DialogResult Notification = MessageBox.Show("Dữ liệu nhập vào không phải số thực hợp lệ. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            if (e.KeyChar == '.' && ((sender as TextBox).SelectionStart == 0 || (sender as TextBox).Text.Contains(".")))
            {
                e.Handled = true;
                DialogResult Notification = MessageBox.Show("Số thực chỉ được nhập 1 dấu chấm và dấu chấm không được ở đầu số. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void textBox_num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                e.Handled = true;
                DialogResult Notification = MessageBox.Show("Dữ liệu nhập vào không phải số thực hợp lệ. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_num3.Text = "";
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
                    textBox_num3.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }
            if (e.KeyChar == '.' && ((sender as TextBox).SelectionStart == 0 || (sender as TextBox).Text.Contains(".")))
            {
                e.Handled = true; // Không cho phép nhập dấu chấm nếu đã có trong số
                DialogResult Notification = MessageBox.Show("Số thực chỉ được nhập 1 dấu chấm và dấu chấm không được ở đầu số. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_num3.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }
        }

        private void textBox_num3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                e.Handled = true;
                DialogResult Notification = MessageBox.Show("Dữ liệu nhập vào không phải số thực hợp lệ. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            if (e.KeyChar == '.' && ((sender as TextBox).SelectionStart == 0 || (sender as TextBox).Text.Contains(".")))
            {
                e.Handled = true; // Không cho phép nhập dấu chấm nếu đã có trong số
                DialogResult Notification = MessageBox.Show("Số thực chỉ được nhập 1 dấu chấm và dấu chấm không được ở đầu số. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void button_find_Click(object sender, EventArgs e)
        {
            if (textBox_num1.Text.Length == 0 || textBox_num2.Text.Length == 0 || textBox_num3.Text.Length == 0)
            {
                DialogResult Notification = MessageBox.Show("Thiếu dữ liệu. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_num1.Text = "";
                    textBox_num2.Text = "";
                    textBox_num3.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }
            else
            {
                double num1 = double.Parse(textBox_num1.Text);
                double num2 = double.Parse(textBox_num2.Text);
                double num3 = double.Parse(textBox_num3.Text);

                double max = num1;
                if (num2 > max)
                {
                    max = num2;
                }
                if (num3 > max)
                {
                    max = num3;
                }

                double min = num1;
                if (num2 < min)
                {
                    min = num2;
                }
                if (num3 < min)
                {
                    min = num3;
                }

                textBox_max.Text = max.ToString();
                textBox_min.Text = min.ToString();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult Notification = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Notification == DialogResult.Yes)
            {
                textBox_num1.Text = "";
                textBox_num2.Text = "";
                textBox_num3.Text = "";
                textBox_max.Text = "";
                textBox_min.Text = "";
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
