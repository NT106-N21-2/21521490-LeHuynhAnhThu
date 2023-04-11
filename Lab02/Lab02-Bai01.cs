using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02
{
    public partial class Lab02_Bai01 : Form
    {
        public Lab02_Bai01()
        {
            InitializeComponent();
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            // Mở file dialog để chọn file txt
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            // Lấy nội dung từ richTextBox và chuyển đổi kí tự sang chữ in hoa
            string content = richTextBox_input.Text;
            string upperCaseContent = content.ToUpper();

            // Ghi nội dung đã chuyển đổi vào file output.txt
            sw.Write(upperCaseContent);

            // Đóng StreamReader và FileStream
            sw.Close();
            fs.Close();

            // Hiển thị lên richTextBox
            richTextBox_output.Text = "";
            richTextBox_output.Text = upperCaseContent;
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            // Mở file dialog để chọn file txt
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();

            // Hiển thị lên richTextBox
            richTextBox_input.Text = "";
            richTextBox_input.Text = content;

            // Đóng StreamReader và FileStream
            sr.Close();
            fs.Close();
        }
    }
}
