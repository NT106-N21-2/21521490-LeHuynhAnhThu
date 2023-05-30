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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab05
{
    public partial class Bai04_ViewMail : Form
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string HostSend { get; set; }
        public string PortSend { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        private string html;

        public Bai04_ViewMail(string html)
        {
            InitializeComponent();
            this.html = html;
            LoadHtmlAsync(html);
        }

        private async void LoadHtmlAsync(string htmlContent)
        {
            await webView_mail.EnsureCoreWebView2Async();
            webView_mail.CoreWebView2.NavigateToString(htmlContent);
        }

        private void Bai04_ViewMail_Load(object sender, EventArgs e)
        {
            textBox_from.Text = To;
            textBox_to.Text = From;
            textBox_subject.Text = Subject;
        }

        private void button_reply_Click(object sender, EventArgs e)
        {
            // Hiển thị form gửi email với thông tin email được chọn để trả lời
            Bai04_SendMail f6 = new Bai04_SendMail();
            f6.Username = Username;
            f6.Password = Password;
            f6.HostSend = HostSend;
            f6.PortSend = PortSend;
            f6.Subject = "RE: " + this.Subject;
            int startIndex = this.From.IndexOf("<") + 1;
            int endIndex = this.From.IndexOf(">", startIndex);
            string to = this.From.Substring(startIndex, endIndex - startIndex);
            f6.To = to;
            f6.Body = string.Format("\r\n\r\n--------\r\n{0}\r\n{1} wrote:\r\n\r\n{2}", DateTime.Now.ToString(), this.To, this.Body);
            f6.ShowDialog();
        }
    }
}
