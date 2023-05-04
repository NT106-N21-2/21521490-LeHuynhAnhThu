using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai01
{
    public partial class Bai01_UDPServer : Form
    {
        public Bai01_UDPServer()
        {
            InitializeComponent();
        }

        private void serverThread()
        {
            UdpClient udpClient = new UdpClient(8080);
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            button_listen.Enabled = false;
            while (true)
            {
                try
                {
                    // Nhận dữ liệu từ Client
                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);

                    // Chuyển đổi dữ liệu nhận được sang chuỗi và hiển thị lên TextBox
                    string message = Encoding.UTF8.GetString(receiveBytes);

                    textBox_rcvport.Text = "8080";

                    string[] lines = message.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                    foreach (string line in lines)
                    {
                        string data = RemoteIpEndPoint.Address.ToString() + ": " + line.TrimEnd('\n', '\r');
                        richTextBox_rcvmessage.AppendText(data + "\n");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread udpServerThread = new Thread(new ThreadStart(serverThread));
            udpServerThread.Start();
            udpServerThread.IsBackground = true;
        }

        private void Bai01_UDPServer_Load(object sender, EventArgs e)
        {

        }
    }
}
