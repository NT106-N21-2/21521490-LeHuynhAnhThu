using MailKit.Net.Imap;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MimeKit;

namespace Lab05
{
    public partial class Lab05_Bai02 : Form
    {
        List<MimeMessage> emails = new List<MimeMessage>();
        public Lab05_Bai02()
        {
            InitializeComponent();
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            var client = new ImapClient();
            client.Connect("imap.gmail.com", 993, true);
            client.Authenticate(textBox1.Text, textBox2.Text); 
          

            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);

            listView1.Items.Clear();
            listView1.Columns.Clear();

            // Thêm các cột vào ListView
            listView1.Columns.Add("From", 150);
            listView1.Columns.Add("Email", 200);
            listView1.Columns.Add("Date", 120);

            for (int i = 0; i < inbox.Count; i++)
            {
                var message = inbox.GetMessage(i);
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
    }
}


