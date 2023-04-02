using Microsoft.Win32.SafeHandles;
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
    public partial class Lab01_Bai04 : Form
    {
        public Lab01_Bai04()
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

                if (num < 0 || num > 9999)
                {
                    DialogResult Notification = MessageBox.Show("Dữ liệu nhập vào phải là số từ 0 đến 9999. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    string[] thousandWords = { "", "một nghìn", "hai nghìn", "ba nghìn", "bốn nghìn", "năm nghìn", "sáu nghìn", "bảy nghìn", "tám nghìn", "chín nghìn" };
                    string[] hundredWords = { "", "một trăm", "hai trăm", "ba trăm", "bốn trăm", "năm trăm", "sáu trăm", "bảy trăm", "tám trăm", "chín trăm" };
                    string[] tenWords = { "", "", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
                    string[] oneWords = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

                    string word = "";
                    int one = num % 10;
                    int ten = (num / 10) % 10;
                    int hundred = (num / 100) % 10;
                    int thousand = (num / 1000) % 10;

                    if (num == 0)
                    {
                        word = "không";
                    }
                    else
                    {
                        if (thousand != 0)
                        {
                            word += thousandWords[thousand] + " ";
                        }

                        if (hundred == 0 && thousand != 0 && (ten != 0 || one != 0))
                        {
                            word += "không trăm ";
                        }
                        else if (hundred != 0)
                        {
                            word += hundredWords[hundred] + " ";
                        }

                        if (ten == 0 && one != 0 && (thousand != 0 || hundred != 0))
                        {
                            word += "lẻ " + oneWords[one];
                        }
                        else if (ten == 1)
                        {
                            word += "mười ";
                            if (one > 0)
                            {
                                if (one == 5)
                                {
                                    word += "lăm";
                                }
                                else
                                {
                                    word += oneWords[one] + " ";
                                }
                            }
                        }
                        else if (ten > 1)
                        {
                            word += tenWords[ten] + " ";
                            if (one == 1)
                            {
                                word += "mốt";
                            }
                            else if (one == 4)
                            {
                                word += "tư";
                            }
                            else if (one == 5)
                            {
                                word += "lăm";
                            }
                            else
                            {
                                word += oneWords[one] + " ";
                            }
                        }
                        else
                        {
                            word += oneWords[one];
                        }
                    }

                        textBox_read.Text = word;
                }
                
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
            DialogResult Notification = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Notification == DialogResult.Yes)
            {
                this.Hide();
            }
        }


    }
}
