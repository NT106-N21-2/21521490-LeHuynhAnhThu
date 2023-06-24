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
using System.Security.Cryptography;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Crypto;
using System.Diagnostics.Metrics;
using RSA;

namespace Lab06
{
    public partial class Bai03_Server : Form
    {
        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>();
        private RSACryptoServiceProvider rsa;
        public Bai03_Server()
        {
            InitializeComponent();
        }

        private void button_listen_Click_1(object sender, EventArgs e)
        {
            button_listen.Enabled = false;
            server = new TcpListener(IPAddress.Any, 9999);
            server.Start();
            richTextBox_server.AppendText("Server started.\r\n");

            // Listenting the connections  
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

            // Generate RSA key pair
            rsa = new RSACryptoServiceProvider();
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
                byte[] encryptedNameBytes = new byte[4096];
                int nameLength = stream.Read(encryptedNameBytes, 0, encryptedNameBytes.Length);
                string name = RSAKeys.DecryptData(encryptedNameBytes); // Decrypt the message

                richTextBox_server.Invoke(new Action(() => richTextBox_server.AppendText("Client from " + client.Client.RemoteEndPoint.ToString() + " name: " + name + "\r\n")));

                // Broadcast the join message to all clients
                string joinMessage = name + " joined the chat.\r\n";
                byte[] joinMessageBytes = Encoding.UTF8.GetBytes(joinMessage);
                Broadcast(joinMessageBytes);

                // Keep reading messages from the client
                while (true)
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        // The client has disconnected
                        clients.Remove(client);
                        richTextBox_server.Invoke(new Action(() => richTextBox_server.AppendText("Client from " + client.Client.RemoteEndPoint.ToString() + " disconnected.\r\n")));
                        string leaveMessage = name + " left the chat.\r\n";
                        byte[] leaveMessageBytes = Encoding.UTF8.GetBytes(leaveMessage);
                        Broadcast(leaveMessageBytes);
                        break;
                    }

                    byte[] encryptedMessageBytes = new byte[bytesRead];
                    Array.Copy(buffer, encryptedMessageBytes, bytesRead);
                    string decryptedMessage = RSAKeys.DecryptData(encryptedMessageBytes); // Giải mã tin nhắn


                    richTextBox_server.Invoke(new Action(() => richTextBox_server.AppendText("Received message from " + name + "! \r\n")));

                    // Broadcast the message to all clients
                    string message = name + ": " + decryptedMessage + "\r\n";
                    byte[] messageBytesWithPrefix = Encoding.UTF8.GetBytes(message);
                    Broadcast(messageBytesWithPrefix);
                }
            }
            catch (Exception ex)
            {
                richTextBox_server.Invoke(new Action(() => richTextBox_server.AppendText("Exception: " + ex.Message + "\r\n")));
            }
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
            MessageBox.Show("Server disconnected!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

