using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Lab03_Bai04
{
    public partial class Client : Form  
    {
        TcpClient client = null;
        int port = 8080;
        public Client()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {

            try
            {
                // Get the message from the richtextBox3.
                string message = richTextBox3.Text.Trim();

                // Send the message to the server.
                byte[] bytes = Encoding.ASCII.GetBytes(message);
                client.GetStream().Write(bytes, 0, bytes.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                // Connect to the specified server and port.
                client = new TcpClient();
                client.Connect("localhost", port);

                // Start receiving messages from the server.
                ReceiveMessages(client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ReceiveMessages(TcpClient client)
        { 
            try
            {
                byte[] bytes = new byte[1024];
                string message = "";

                while (true)
                {
                    // Read the incoming message from the server.
                    int bytesRead = client.GetStream().Read(bytes, 0, bytes.Length);
                    message = Encoding.ASCII.GetString(bytes, 0, bytesRead);

                    // Display the message on the richtextBox3.
                    Invoke(new Action(() =>
                    {
                        richTextBox3.AppendText(message + "\n");
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
