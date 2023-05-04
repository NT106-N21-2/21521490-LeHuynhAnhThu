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
    public partial class TCP_Client : Form
    {
        private TcpClient client;

        public TCP_Client()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        //Ngắt kết nối 
        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            if (client != null && client.Connected)
            {
                client.Close();
                MessageBox.Show("Disconnected from server", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Clear();
            }

        }

        //Kết nối tới server 
        private void ConnectButton_Click(object sender, EventArgs e) //
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            client = new TcpClient();
            try
            {
                client.Connect(IPAddress.Loopback, 8080);
                MessageBox.Show("Connected to server", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            //Kiểm tra kết nối 
            if (client == null || !client.Connected)
            {
                MessageBox.Show("Not connected to server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Lẩy nội dung từ richTextBox1 chuyển sang mảng byte và gửi đến server bằng networkstream của client 
            string message = richTextBox1.Text;
            byte[] data = Encoding.UTF8.GetBytes(message);
            try
            {
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                MessageBox.Show("Message sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
