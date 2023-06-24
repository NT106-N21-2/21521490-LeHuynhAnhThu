using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Crypto;
using RSA;
using System.Diagnostics.Metrics;


namespace Lab06
{
    public partial class Bai03_Client : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private string name;
        public Bai03_Client()
        {
            InitializeComponent();

        }
        private void Bai03_Client_Load(object sender, EventArgs e)
        {    // Connect to the server
            client = new TcpClient("localhost", 9999);
            stream = client.GetStream();
            // Start a new thread to receive messages from the server
            Task.Run(() => ReceiveMessages());
        }
        private async Task ReceiveMessages()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        // The server has disconnected
                        for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                        {
                            Form form = Application.OpenForms[i];
                            if (form is Bai03_Client)
                            {
                                form.Close();
                            }
                        }
                        break;
                    }
                    // Display the message in the chat box
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    richTextBox_chat.Invoke(new Action(() => richTextBox_chat.AppendText(message)));
                }
            }
            catch (Exception ex) { }
            finally
            {
                // Close the client connection
                client.Close();
            }
        }

        private bool nameSent = false;
        private void button_send_Click_1(object sender, EventArgs e)
        {
            // Send the message to the server
            string message = textBox_message.Text;
            byte[] encryptedMessageBytes = RSAKeys.EncryptData(message); // message encryption

            if (!nameSent)
            {
                string name = textBox_name.Text;
                textBox_name.Enabled = false;
                byte[] encryptedNameBytes = RSAKeys.EncryptData(name); // Name encryption 
                stream.Write(encryptedNameBytes, 0, encryptedNameBytes.Length);
                nameSent = true;
            }

            stream.Write(encryptedMessageBytes, 0, encryptedMessageBytes.Length);
            textBox_message.Clear();
        }
        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the client connection
            client.Close();
        }
    }
}
