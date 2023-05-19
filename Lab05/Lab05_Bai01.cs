using MailKit.Net.Smtp;
using MimeKit;
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
using System.Xml.Linq;

namespace Lab05
{
    public partial class Lab05_Bai01 : Form
    {
        public Lab05_Bai01()
        {
            InitializeComponent();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            var client = new SmtpClient();
            client.Connect("smtp.gmail.com", 465, true);
            client.Authenticate("21521490@gm.uit.edu.vn", "qacpigizbyjxiwpr");

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("anhthune", "21521490@gm.uit.edu.vn"));
            message.To.Add(new MailboxAddress("", textBox_to.Text));
            message.Subject = textBox_subject.Text;
            message.Body = new TextPart("plain")
            {
                Text = richTextBox_body.Text
            };

            client.Send(message);
        }
    }
}
