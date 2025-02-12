﻿using HtmlAgilityPack;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab04
{
    public partial class Lab04_Bai06 : Form
    {
        public Lab04_Bai06()
        {
            InitializeComponent();
        }

        private void button_get_Click(object sender, EventArgs e)
        {
            string url = textBox_url.Text;
            ExtractNewsItems(url);
        }

        private void ExtractNewsItems(string url)
        {
            panel_web.Controls.Clear();
            HtmlWeb htmlWeb = new HtmlWeb();
            var htmlDoc = htmlWeb.Load(url);

            var articles = htmlDoc.DocumentNode.SelectNodes("//*[@id=\"automation_TV0\"]/div[2]/article");
            progressBar.Maximum = articles.Count;
            int count = 0;
            foreach (HtmlNode article in articles)
            {
                try
                {
                    HtmlNode imageNode = article.SelectSingleNode("./div/a/picture/img");
                    HtmlNode titleNode = article.SelectSingleNode("./h2");
                    HtmlNode descriptionNode = article.SelectSingleNode("./p");
                    HtmlNode linkNode = article.SelectSingleNode("./h2/a");

                    var image = "";

                    if (imageNode != null)
                    {
                        image = imageNode.GetAttributeValue("data-src", "") != "" ? imageNode.GetAttributeValue("data-src", "") : imageNode.GetAttributeValue("src", "");
                    }

                    if (titleNode != null && descriptionNode != null && linkNode != null)
                    {
                        string title = titleNode.InnerText.Trim();
                        string description = descriptionNode.InnerText.Trim();
                        string link = linkNode.Attributes["href"].Value;

                        Panel itemPanel = new Panel();
                        itemPanel.BorderStyle = BorderStyle.FixedSingle;
                        itemPanel.Margin = new Padding(5);
                        itemPanel.Padding = new Padding(5);
                        itemPanel.Cursor = Cursors.Hand;
                        itemPanel.Size = new Size(743, 120);

                        Label titleLabel = new Label();
                        titleLabel.AutoSize = true;
                        titleLabel.MaximumSize = new Size(itemPanel.Width - 200, 0);
                        titleLabel.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                        titleLabel.Text = title;

                        Label descriptionLabel = new Label();
                        descriptionLabel.AutoSize = true;
                        descriptionLabel.Font = new Font("Times New Roman", 10);
                        descriptionLabel.MaximumSize = new Size(panel_web.Width - 200, 0);
                        descriptionLabel.Text = description;

                        PictureBox imagePictureBox = new PictureBox();
                        imagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        imagePictureBox.Size = new Size(150, 100);
                        imagePictureBox.Margin = new Padding(5);
                        if (!string.IsNullOrEmpty(image))
                        {
                            imagePictureBox.Load(image);
                        }

                        itemPanel.Controls.Add(titleLabel);
                        itemPanel.Controls.Add(descriptionLabel);
                        itemPanel.Controls.Add(imagePictureBox);
                        itemPanel.Tag = link;

                        titleLabel.Location = new Point(imagePictureBox.Right + 10, 10);
                        descriptionLabel.Location = new Point(imagePictureBox.Right + 10, titleLabel.Bottom + 10);
                        imagePictureBox.Location = new Point(10, 10);

                        // Gán sự kiện click vào Panel chứa tin tức
                        itemPanel.Click += panel_web_Click;

                        if (count > 0)
                        {
                            Panel prevPanel = (Panel)panel_web.Controls[count - 1];
                            int top = prevPanel.Bottom + 10;
                            itemPanel.Location = new Point(0, top);
                        }
                        else
                        {
                            itemPanel.Location = new Point(0, 0);
                        }

                        panel_web.Controls.Add(itemPanel);

                        count++;
                    }
                }
                catch (Exception ex) { }
                progressBar.Value = count;
            }
        }

        private void panel_web_Click(object sender, EventArgs e)
        {
            // Hiển thị nội dung tin tức được chọn
            Panel clickedPanel = sender as Panel;
            if (clickedPanel != null)
            {
                string link = clickedPanel.Tag.ToString();
                Bai06_News news = new Bai06_News(link);
                news.Show();
            }
        }
    }
}
