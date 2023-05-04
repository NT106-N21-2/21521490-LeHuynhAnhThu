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

namespace Lab03
{
    public partial class Bai04_Client : Form
    {
        private TcpClient client;
        public Bai04_Client()
        {
            InitializeComponent();
            button_send.Enabled = false;
            button_disconnect.Enabled = false;
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            button_connect.Enabled = false;
            button_send.Enabled = true;
            button_disconnect.Enabled = true;
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

        private void button_send_Click(object sender, EventArgs e)
        {
            button_connect.Enabled = false;
            button_send.Enabled = false;
            button_disconnect.Enabled = true;
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

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            button_connect.Enabled = true;
            button_send.Enabled = false;
            button_disconnect.Enabled = false;
            if (client != null && client.Connected)
            {
                client.Close();
                MessageBox.Show("Disconnected from server", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Clear();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Bai04_Client_Load(object sender, EventArgs e)
        {

        }
    }
}
