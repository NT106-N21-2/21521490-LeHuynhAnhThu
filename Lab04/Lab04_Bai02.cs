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

namespace Lab04
{
    public partial class Lab04_Bai02 : Form
    {
        public Lab04_Bai02()
        {
            InitializeComponent();
        }

        private async void button_post_Click(object sender, EventArgs e)
        {
            // Lấy đường dẫn và dữ liệu từ textBox
            string url = textBox_url.Text;
            string postData = textBox_data.Text;

            // Kiểm tra đường dẫn và dữ liệu có rỗng hay không
            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(postData))
            {
                MessageBox.Show("Vui lòng nhập đường dẫn và dữ liệu muốn gửi.");
                return;
            }

            try
            {
                // Khởi tạo request với địa chỉ URL sử dụng phương thức POST
                WebRequest request = WebRequest.Create(url);
                request.Method = "POST";

                // Convert dữ liệu POST từ string sang byte array
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                // Thiết lập độ dài của nội dung trả về (Content Length) bởi WebRequest
                request.ContentLength = byteArray.Length;

                // Thiết lập thuộc tính Content Type của WebRequest
                request.ContentType = "application/x-www-form-urlencoded";

                // Tạo request stream bằng cách get request stream từ WebRequest
                using (Stream dataStream = request.GetRequestStream())
                {
                    // Ghi dữ liệu vào request stream
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                // Sử dụng Task.Run() để đưa đoạn mã này vào một tiểu trình khác để tránh tình trạng khóa UI
                string responseString = await Task.Run(() =>
                {
                    // Get response từ WebRequest bằng cách sử dụng phương thức GetResponse()
                    using (WebResponse response = request.GetResponse())
                    {
                        // Lấy phản hồi dưới dạng stream
                        using (Stream responseStream = response.GetResponseStream())
                        {
                            // Đọc phản hồi thành chuỗi
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                return reader.ReadToEnd();
                            }
                        }
                    }
                });

                // In chuỗi phản hồi vào RichTextBox
                richTextBox_web.Text = responseString;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi ở đây
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void textBox_url_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
