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
using System.Diagnostics;


namespace Lab03_Bai02
{
    public partial class Telnet : Form
    {
        public Telnet()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Listen_Click(object sender, EventArgs e)
        {	
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
            serverThread.IsBackground = true;
			//cmd tự động mở 
			Process.Start("cmd.exe");
		}
		private void StartUnsafeThread()
		{
			int bytesReceievd = 0;
			//Khởi tạo mảng byte nhận dữ liệu 
			byte[] recv = new byte[1];
			//Tạo socket bên gửi 
			Socket clientSocket;
			//Tạo socket bên nhận 
			Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
			listenerSocket.Bind(ipEndPoint);
			listenerSocket.Listen(-1);

			//Đồng ý kết nối 
			clientSocket = listenerSocket.Accept();
			//Nhận dữ liệu 
			while (clientSocket.Connected)
			{
				string text = "";
				do
				{
					bytesReceievd = clientSocket.Receive(recv);
					text += Encoding.UTF8.GetString(recv);
				} while (text[text.Length - 1] != '\n');
				  richTextBox1.Text += text + "\n";
			}
			listenerSocket.Close();
		}
	}
}
