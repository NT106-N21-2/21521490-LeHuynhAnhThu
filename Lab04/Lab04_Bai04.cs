using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using HtmlAgilityPack;

namespace Lab04
{
    public partial class Lab04_Bai04 : Form
    {
        public Lab04_Bai04()
        {
            InitializeComponent();
        }

        private string getHTML(string szUrl)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szUrl);
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Close the response.
            response.Close();
            return responseFromServer;
        }

        private void button_get_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri(textBox_url.Text);
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            var html = getHTML(textBox_url.Text);
            Bai04_ViewSource source = new Bai04_ViewSource(html);
            source.Show();
        }

        private async void button_download_Click(object sender, EventArgs e)
        {
            // Mở folder muốn lưu file
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string folderName = Path.Combine(fbd.SelectedPath, "DownloadedWebPages");
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }

            // Tải nội dung HTML từ đường dẫn URL
            using (WebClient client = new WebClient())
            {
                string html = await client.DownloadStringTaskAsync(textBox_url.Text);

                // Tạo đối tượng HtmlDocument và load nội dung HTML
                HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.LoadHtml(html);

                // Tải xuống các hình ảnh từ trang web
                foreach (HtmlNode imgNode in htmlDoc.DocumentNode.Descendants("img"))
                {
                    string imgUrl = imgNode.GetAttributeValue("src", null);
                    if (!string.IsNullOrEmpty(imgUrl))
                    {
                        // Tạo Uri từ đường dẫn hình ảnh
                        Uri imgUri = new Uri(imgUrl, UriKind.RelativeOrAbsolute);
                        if (!imgUri.IsAbsoluteUri)
                        {
                            imgUri = new Uri(new Uri(textBox_url.Text), imgUri);
                        }

                        // Tạo đường dẫn file được lưu trữ trên ổ đĩa
                        string fileName = Path.Combine(folderName, Path.GetFileName(imgUri.LocalPath));

                        try
                        {
                            // Tải xuống hình ảnh và lưu vào đường dẫn file
                            using (WebClient imgClient = new WebClient())
                            {
                                await imgClient.DownloadFileTaskAsync(imgUri, fileName);
                            }
                        }
                        catch (WebException ex)
                        {
                            if (ex.Response is HttpWebResponse response && response.StatusCode == HttpStatusCode.NotFound)
                            {
                                // Xử lý lỗi 404 tại đây
                            }
                            else
                            {
                                // Xử lý các lỗi khác tại đây
                            }
                        }
                    }
                }

                // Tải xuống các tệp liên quan từ trang web
                foreach (HtmlNode linkNode in htmlDoc.DocumentNode.Descendants("a"))
                {
                    string linkUrl = linkNode.GetAttributeValue("href", null);
                    if (!string.IsNullOrEmpty(linkUrl))
                    {
                        // Tạo Uri từ đường dẫn tệp liên quan
                        Uri linkUri = new Uri(linkUrl, UriKind.RelativeOrAbsolute);
                        if (!linkUri.IsAbsoluteUri)
                        {
                            linkUri = new Uri(new Uri(textBox_url.Text), linkUri);
                        }

                        // Tạo đường dẫn file được lưu trữ trên ổ đĩa
                        string fileName = Path.Combine(folderName, Path.GetFileName(linkUri.LocalPath));

                        try
                        {
                            // Tải xuống tệp liên quan và lưu vào đường dẫn file
                            using (WebClient linkClient = new WebClient())
                            {
                                await linkClient.DownloadFileTaskAsync(linkUri, fileName);
                            }
                        }
                        catch (WebException ex)
                        {
                            if (ex.Response is HttpWebResponse response && response.StatusCode == HttpStatusCode.NotFound)
                            {
                                // Xử lý lỗi 404 tại đây
                            }
                            else
                            {
                                // Xử lý các lỗi khác tại đây
                            }
                        }
                    }
                }

                MessageBox.Show("Download completed!");
            }
        }

        private void Lab04_Bai04_Load(object sender, EventArgs e)
        {

        }
    }
}
