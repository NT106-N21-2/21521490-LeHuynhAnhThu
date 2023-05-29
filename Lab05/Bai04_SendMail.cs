using MimeKit;
using MailKit.Net.Smtp;
using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.IO;

namespace Lab05
{
    public partial class Bai04_SendMail : Form
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string HostSend { get; set; }
        public string PortSend { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public Bai04_SendMail()
        {
            InitializeComponent();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            var client = new SmtpClient();
            client.Connect(HostSend, int.Parse(PortSend), true);
            client.Authenticate(Username, Password);

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(textBox_name.Text, textBox_from.Text));
            message.To.Add(new MailboxAddress("", textBox_to.Text));
            message.Subject = textBox_subject.Text;

            if (checkBox_html.Checked)
            {
                var body = new TextPart("html")
                {
                    Text = richTextBox_body.Text
                };
                message.Body = body;
            }
            else
            {
                var body = new TextPart("plain")
                {
                    Text = richTextBox_body.Text
                };
                message.Body = body;
            }

            if (!string.IsNullOrEmpty(textBox_attachment.Text))
            {
                var attachment = new MimePart("application", "octet-stream")
                {
                    Content = new MimeContent(File.OpenRead(textBox_attachment.Text)),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(textBox_attachment.Text )
                };
                var multipart = new Multipart("mixed");
                multipart.Add(message.Body);
                multipart.Add(attachment);
                message.Body = multipart;
            }

            client.Send(message);
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_attachment.Text = ofd.FileName;
            }
        }

        private void Bai05_SendMail_Load(object sender, EventArgs e)
        {
            textBox_from.Text = Username;
            textBox_from.Enabled = false;
            textBox_to.Text = To;
            textBox_subject.Text = Subject;
            richTextBox_body.Text = Body;
        }
    }
}
