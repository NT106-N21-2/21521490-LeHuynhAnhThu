using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai01
{
    public partial class UDPClient : Form
    {
        public UDPClient()
        {
            InitializeComponent();
            textBox_ip.Text = "127.0.0.1";
            textBox_port.Text = "8080";
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            try
            {
                // Khai báo thông điệp cần gửi đến Server từ TextBox
                string message = richTextBox_message.Text;

                // Chuyển đổi thông điệp sang dạng bytes và gửi đi
                byte[] sendBytes = Encoding.UTF8.GetBytes(message);
                udpClient.Send(sendBytes, sendBytes.Length, textBox_ip.Text, 8080);

                richTextBox_message.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
