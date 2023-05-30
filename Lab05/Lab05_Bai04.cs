using MailKit;
using MailKit.Net.Imap;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab05
{
    public partial class Lab05_Bai04 : Form
    {
        List<MimeMessage> emails = new List<MimeMessage>();

        public Lab05_Bai04()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            button_login.Visible = false;
            button_logout.Visible = true;
            button_refresh.Visible = true;
            button_send.Visible = true;
            textBox_usermail.Enabled = false;
            textBox_password.Enabled = false;

            var client = new ImapClient();
            client.Connect(textBox_hostget.Text, Int32.Parse(textBox_portget.Text), true);
            client.Authenticate(textBox_usermail.Text, textBox_password.Text);

            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);

            listView_mail.Clear();

            // Thêm các cột vào ListView
            listView_mail.Columns.Add("STT", 50);
            listView_mail.Columns.Add("From", 150);
            listView_mail.Columns.Add("Subject", 200);
            listView_mail.Columns.Add("Date", 120);

            for (int i = inbox.Count - 1; i >= inbox.Count - 1 - 19; i--)
            {
                var message = inbox.GetMessage(i);
                emails.Add(message);

                // Tạo một ListViewItem mới
                var item = new ListViewItem((inbox.Count - i).ToString());

                // Thêm subitem (cột) "From" vào ListViewItem
                var fromSubItem = new ListViewItem.ListViewSubItem(item, message.From.Mailboxes.FirstOrDefault()?.Name);
                item.SubItems.Add(fromSubItem);

                // Thêm subitem (cột) "Subject" vào ListViewItem
                var subjectSubItem = new ListViewItem.ListViewSubItem(item, message.Subject);
                item.SubItems.Add(subjectSubItem);

                // Thêm subitem (cột) "Date" vào ListViewItem
                var dateSubItem = new ListViewItem.ListViewSubItem(item, message.Date.ToString());
                item.SubItems.Add(dateSubItem);

                // Thêm ListViewItem vào ListView
                listView_mail.Items.Add(item);
            }
            client.Disconnect(true);
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            Bai04_SendMail f6 = new Bai04_SendMail();
            f6.Username = textBox_usermail.Text;
            f6.Password = textBox_password.Text;
            f6.HostSend = textBox_hostsend.Text;
            f6.PortSend = textBox_portsend.Text;
            f6.ShowDialog();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            listView_mail.Items.Clear();
            emails.Clear();

            // Gọi lại hàm để đọc email từ server và hiển thị danh sách email lên ListView
            button_login_Click(sender, e);
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            listView_mail.Clear();

            // Đặt giao diện người dùng về trạng thái ban đầu
            button_logout.Visible = false;
            button_refresh.Visible = false;
            button_send.Visible = false;
            button_login.Visible = true;
            textBox_usermail.Enabled = true;
            textBox_password.Enabled = true;
            textBox_password.Text = "";
            textBox_usermail.Text = "";
        }

        private void listView_mail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_mail.SelectedItems.Count > 0)
            {
                // Lấy MimeMessage tương ứng với email được chọn
                int emailIndex = listView_mail.SelectedItems[0].Index;
                MimeMessage email = emails[emailIndex];

                string html = email.HtmlBody;

                // Hiển thị nội dung của email dưới dạng chuỗi HTML trong đối tượng WebView2
                Bai04_ViewMail f7 = new Bai04_ViewMail(html);
                f7.From = email.From.ToString();
                f7.To = email.To.ToString();
                f7.Username = textBox_usermail.Text;
                f7.Password = textBox_password.Text;
                f7.Subject = listView_mail.SelectedItems[0].SubItems[2].Text;
                f7.HostSend = textBox_hostsend.Text;
                f7.PortSend = textBox_portsend.Text;
                f7.ShowDialog();
            }
        }

        private void Lab05_Bai04_Load(object sender, EventArgs e)
        {

        }

        private void textBox_portsend_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
