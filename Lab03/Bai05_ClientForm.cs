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

namespace Lab03_Bai05
{
    public partial class Bai05_ClientForm : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private string name;
        public Bai05_ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // Connect to the server
            client = new TcpClient("localhost", 9999);
            stream = client.GetStream();

            // Start a new thread to receive messages from the server
            Task.Run(() => ReceiveMessages());
        }

        private void ReceiveMessages()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        // The server has disconnected
                        for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                        {
                            Form form = Application.OpenForms[i];
                            if (form is Bai05_ClientForm)
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

        private void button_send_Click(object sender, EventArgs e)
        {
            // Send the message to the server
            string message = textBox_message.Text;
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);

            if (!nameSent)
            {
                string name = textBox_name.Text;
                textBox_name.Enabled = false;
                byte[] nameBytes = Encoding.UTF8.GetBytes(name);
                stream.Write(nameBytes, 0, nameBytes.Length);
                nameSent = true;
            }

            stream.Write(messageBytes, 0, messageBytes.Length);
            textBox_message.Clear();
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the client connection
            client.Close();
        }
    }
}
