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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void textBox_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                DialogResult Notification = MessageBox.Show("Dữ liệu nhập vào không phải số nguyên. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_num.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            if (textBox_num.Text.Length == 0)
            {
                DialogResult Notification = MessageBox.Show("Thiếu dữ liệu. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_num.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }
            else
            {
                int num = Int32.Parse(textBox_num.Text);
                string word = "";

                switch (num)
                {
                    case 0:
                        word = "Không";
                        break;
                    case 1:
                        word = "Một";
                        break;
                    case 2:
                        word = "Hai";
                        break;
                    case 3:
                        word = "Ba";
                        break;
                    case 4:
                        word = "Bốn";
                        break;
                    case 5:
                        word = "Năm";
                        break;
                    case 6:
                        word = "Sáu";
                        break;
                    case 7:
                        word = "Bảy";
                        break;
                    case 8:
                        word = "Tám";
                        break;
                    case 9:
                        word = "Chín";
                        break;
                    default:
                        DialogResult Notification = MessageBox.Show("Dữ liệu nhập vào phải là số từ 0 đến 9. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Notification == DialogResult.Yes)
                        {
                            textBox_num.Text = "";
                        }
                        else
                        {
                            this.Hide();
                        }
                        break;
                }

                textBox_read.Text = word;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult Notification = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Notification == DialogResult.Yes)
            {
                textBox_num.Text = "";
                textBox_read.Text = "";
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
