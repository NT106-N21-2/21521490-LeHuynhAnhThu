using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab04
{
    public partial class Lab04_Bai03 : Form
    {
        public Lab04_Bai03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy địa chỉ URL từ TextBox1
                string url = textBox1.Text;

                // Lấy đường dẫn file lưu trữ từ TextBox2
                string filename = textBox2.Text;

                // Khởi tạo đối tượng WebClient
                WebClient myClient = new WebClient();


                // Tải nội dung trang web về dưới dạng một mảng byte
                byte[] data = myClient.DownloadData(url);

                // Ghi mảng byte về file
                File.WriteAllBytes(filename, data);

                // Đọc nội dung file vừa lưu vào một chuỗi
                string html = File.ReadAllText(filename);

                // Hiển thị nội dung trang web lên RichTextBox
                richTextBox1.Text = html;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
 


