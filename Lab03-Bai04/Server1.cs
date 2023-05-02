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
using System.Threading;



namespace Lab03_Bai04
{
    public partial class Server1 : Form
    {
        TcpListener server = null;
        TcpClient client = null;
        int port = 8080;

        public Server1()
        {
            InitializeComponent();
        }

        private void Listen_Click(object sender, EventArgs e)
        {
            try
            {
                // Start listening on the specified port.
                server = new TcpListener(IPAddress.Any, port);
                server.Start();

                // Accept the incoming client connection.
                client = server.AcceptTcpClient();

                // Start receiving messages from the client.
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
                    // Read the incoming message from the client.
                    int bytesRead = client.GetStream().Read(bytes, 0, bytes.Length);
                    message = Encoding.ASCII.GetString(bytes, 0, bytesRead);

                    // Display the message on the richtextBox1.
                    Invoke(new Action(() =>
                    {
                        richTextBox1.AppendText(message + "\n");
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
