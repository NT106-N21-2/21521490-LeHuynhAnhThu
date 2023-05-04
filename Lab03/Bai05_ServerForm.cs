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

namespace Lab03_Bai05
{
    public partial class Bai05_ServerForm : Form
    {
        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>();

        public Bai05_ServerForm()
        {
            InitializeComponent();
        }

        private void button_listen_Click(object sender, EventArgs e)
        {
            button_listen.Enabled = false;
            server = new TcpListener(IPAddress.Any, 9999);
            server.Start();
            richTextBox_server.AppendText("Server started.\r\n");

            // Start listening for incoming connections
            Task.Run(async () =>
            {
                while (true)
                {
                    TcpClient client = await server.AcceptTcpClientAsync();
                    clients.Add(client);
                    richTextBox_server.AppendText("New client connected from " + client.Client.RemoteEndPoint.ToString() + "\r\n");

                    // Start a new thread to handle the client connection
                    Task.Run(() => HandleClient(client));
                }
            });
        }

        private void HandleClient(TcpClient client)
        {
            try
            {
                // Get the client stream for reading and writing
                NetworkStream stream = client.GetStream();

                // Send a welcome message to the client
                string welcomeMessage = "Welcome to Chat Room!\r\n";
                byte[] welcomeMessageBytes = Encoding.UTF8.GetBytes(welcomeMessage);
                stream.Write(welcomeMessageBytes, 0, welcomeMessageBytes.Length);

                // Get the client name
                byte[] nameBytes = new byte[1024];
                int nameLength = stream.Read(nameBytes, 0, nameBytes.Length);
                string name = Encoding.UTF8.GetString(nameBytes, 0, nameLength);
                richTextBox_server.AppendText("Client from " + client.Client.RemoteEndPoint.ToString() + " name: " + name + "\r\n");

                // Broadcast the join message to all clients
                string joinMessage = name + " joined the chat.\r\n";
                byte[] joinMessageBytes = Encoding.UTF8.GetBytes(joinMessage);
                Broadcast(joinMessageBytes);

                // Keep reading messages from the client
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        // The client has disconnected
                        clients.Remove(client);
                        richTextBox_server.AppendText("Client from " + client.Client.RemoteEndPoint.ToString() + " disconnected.\r\n");
                        string leaveMessage = name + " left the chat.\r\n";
                        byte[] leaveMessageBytes = Encoding.UTF8.GetBytes(leaveMessage);
                        Broadcast(leaveMessageBytes);
                        break;
                    }

                    // Broadcast the message to all clients
                    byte[] messageBytes = new byte[bytesRead];
                    Array.Copy(buffer, messageBytes, bytesRead);
                    string message = name + ": " + Encoding.UTF8.GetString(messageBytes) + "\r\n";
                    byte[] messageBytesWithPrefix = Encoding.UTF8.GetBytes(message);
                    Broadcast(messageBytesWithPrefix);
                }
            }
            catch (Exception ex) { }
        }

        private void Broadcast(byte[] message)
        {
            foreach (TcpClient client in clients)
            {
                NetworkStream stream = client.GetStream();
                stream.Write(message, 0, message.Length);
            }
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close all client connections
            foreach (TcpClient client in clients)
            {
                client.Close();
            }
            MessageBox.Show("Server disconnected!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
