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


namespace Lab03_Bai04
{
    public partial class Server2 : Form
    {

        TcpListener server = null;
        TcpClient client = null;
        int port = 8080;
        bool isConnected = false;

        public Server2()
        {
            InitializeComponent();
        }

        private void Server2_Load(object sender, EventArgs e)
        {
            try
            {
                // Connect to the specified server and port.
                client = new TcpClient();
                client.Connect("localhost", port);

                // Set the isConnected flag to true.
                isConnected = true;

                // Start receiving messages from the server.
                ReceiveMessages(client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                // Handle the incoming messages from the client.
                HandleClient(client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //kiểm tra trạng thái kết nối giữa Server 2 và Client. Nếu kết nối bị mất, thì thay đổi trạng thái kết nối và thử kết nối lại đến Server 1
        private void CheckConnection()
        {
            try
            {
                // Send a test message to the server to check the connection.
                SendMessage(client, "Test");

                // If the message is sent successfully, then the connection is still alive.
                isConnected = true;
            }
            catch (Exception ex)
            {
                // If an exception is thrown, then the connection is lost.
                isConnected = false;

                // Try to connect to the server again.
                client = new TcpClient();
                client.Connect("localhost", port);

                // Start receiving messages from the server.
                ReceiveMessages(client);
            }
        }


        //kiểm tra kết nối định kỳ với Server 1
        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckConnection();
        }
        private void HandleClient(TcpClient client)
        {
            try
            {
                // Get the client stream for reading and writing.
                NetworkStream stream = client.GetStream();

                // Create a byte array to store the incoming data.
                byte[] data = new byte[1024];

                while (true)
                {
                    // Read the incoming data from the client.
                    int bytes = stream.Read(data, 0, data.Length);
                    string message = Encoding.ASCII.GetString(data, 0, bytes);

                    // Handle the incoming message.
                    if (message == "Hello")
                    {
                        // Send a response message to the client.
                        SendMessage(client, "Hi client!");
                    }
                    else
                    {
                        // Send an error message to the client.
                        SendMessage(client, "Invalid message.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //xử lý việc gửi tin nhắn đến Server 1
        private void SendMessage(TcpClient client, string message)
        {
            // Get the client stream for reading and writing.
            NetworkStream stream = client.GetStream();

            // Convert the message to a byte array and send it to the server.
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }

        //nhận tin nhắn từ Server 1
        private void ReceiveMessages(TcpClient client)
        {
            try
            {
                // Get the client stream for reading and writing.
                NetworkStream stream = client.GetStream();

                while (true)
                {
                    // Create a byte array to store the incoming data.
                    byte[] data = new byte[1024];

                    // Read the incoming data from the server.
                    int bytes = stream.Read(data, 0, data.Length);
                    string message = Encoding.ASCII.GetString(data, 0, bytes);

                    // Handle the incoming message.
                    if (message == "Hi server!")
                    {
                        // Send a test message to the server.
                        SendMessage(client, "Hello");
                    }
                    else
                    {
                        // Display the incoming message.
                        richTextBox2.Invoke(new Action(() => richTextBox2.AppendText(message + "\n")));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
