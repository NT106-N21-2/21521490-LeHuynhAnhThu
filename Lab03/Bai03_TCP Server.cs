using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Lab03_Bai03
{
    public partial class TCP_Server : Form
    {
        private TcpListener listener;

        public TCP_Server()
        {
            InitializeComponent();
        }

        private void ListenButton_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            //Kiểm tra đối tượng listener được khởi tạo chưa
            if (listener == null)
            {
                listener = new TcpListener(IPAddress.Loopback, 8080);
                listener.Start();
                MessageBox.Show("Listening for connections", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AcceptClients();
            }
        }

        //Chấp nhận kết nối từ client cho đến khi server bị ngắt kết nối  
        private async void AcceptClients()
        {
            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync(); // 
                HandleClient(client);
            }
        }

        //Xử lý kết nối từ TCP Client 
        private async void HandleClient(TcpClient client)
        {
            try
            {   //tạo một đối tượng NetworkStream từ kết nối của Client và đọc thông điệp gửi từ Client.
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                StringBuilder builder = new StringBuilder();
                int bytesRead = 0;
                //Chỉ đọc dữ liệu từ NetworkStream khi có dữ liệu khả dụng 
                do
                {
                    bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    //Chuyển đổi byte thành chuỗi 
                    builder.Append(Encoding.UTF8.GetString(buffer, 0, bytesRead));
                } while (stream.DataAvailable);
                string message = builder.ToString();
                AddMessageToLog(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error handling client: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Hiển thị thông điệp đã được nhận lên richTextBox1 
        private void AddMessageToLog(string message)
        {
            if (InvokeRequired) //kiểm tra xem thread hiện tại có thể truy cập trực tiếp vào richTextBox1 hay không
            {
                Invoke(new Action(() => AddMessageToLog(message))); // giá trị đầu vào là action và trả về addmessagetolog(message)
            }
            else
            {
                richTextBox1.AppendText(message + Environment.NewLine); //nếu có thể truy cập trực tiếp thì message được thêm vào cuối 
            }
        }
    }
}
