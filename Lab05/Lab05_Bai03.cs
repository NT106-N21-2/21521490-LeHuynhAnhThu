using MailKit.Net.Imap;
using MailKit;
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
using MailKit.Net.Pop3;

namespace Lab05
{
    public partial class Lab05_Bai03 : Form
    {
        List<MimeMessage> emails = new List<MimeMessage>();
        public Lab05_Bai03()
        {
            InitializeComponent();
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            var client = new Pop3Client();
            client.Connect("pop.gmail.com", 995, true);
            client.Authenticate(textBox_Email.Text, textBox_Password.Text);   //bcctyctoaolwyoqs


            var messages = client.GetMessageCount();

            listView1.Items.Clear();
            listView1.Columns.Clear();


            // Thêm các cột vào ListView
            listView1.Columns.Add("From", 300);
            listView1.Columns.Add("Email", 300);
            listView1.Columns.Add("Date", 200);

            for (int i = 0; i < messages; i++)
            {
                var message = client.GetMessage(i);
                emails.Add(message);
                // Tạo một ListViewItem mới
                var item = new ListViewItem(message.From.Mailboxes.FirstOrDefault()?.Name);

                // Thêm subitem (cột) "Email" vào ListViewItem
                var emailSubItem = new ListViewItem.ListViewSubItem(item, message.Subject);
                item.SubItems.Add(emailSubItem);

                // Thêm subitem (cột) "Date" vào ListViewItem
                var dateSubItem = new ListViewItem.ListViewSubItem(item, message.Date.ToString());
                item.SubItems.Add(dateSubItem);

                // Thêm ListViewItem vào ListView
                listView1.Items.Add(item);

            }

            client.Disconnect(true);
            label_total.Text = $"{messages}";
            label_total.BringToFront();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int selectedIndex = listView1.SelectedIndices[0];
                var selectedEmail = emails[selectedIndex];

                // Hiển thị toàn bộ nội dung của email
                MessageBox.Show($"From: {selectedEmail.From}\nSubject: {selectedEmail.Subject}\n\n{selectedEmail.TextBody}");
            }
        }

        private void checkBox_Showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Showpass.Checked)
            {
                textBox_Password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_Password.UseSystemPasswordChar = true;
            }
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lab05_Bai03_Load(object sender, EventArgs e)
        {

        }
    }
}
