﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab04
{
    public partial class Lab04_Bai05 : Form
    {
        private int currentPage = 1;
        private int totalPages;
        private int usersPerPage = 6;
        private int totalUsers = 12;
        private List<User> users = new List<User>();

        public Lab04_Bai05()
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
        class User
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("email")]
            public string Email { get; set; }

            [JsonPropertyName("first_name")]
            public string FirstName { get; set; }

            [JsonPropertyName("last_name")]
            public string LastName { get; set; }

            [JsonPropertyName("avatar")]
            public string Avatar { get; set; }
        }

        class UserPagination
        {
            [JsonPropertyName("page")]
            public int Page { get; set; }
            [JsonPropertyName("per_page")]
            public int PerPage { get; set; }
            [JsonPropertyName("total")]
            public int Total { get; set; }
            [JsonPropertyName("total_pages")]
            public int TotalPages { get; set; }
            [JsonPropertyName("data")]
            public List<User> Data { get; set; }
        }

        private void Lab04_Bai05_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            // Tạo URL API mới để lấy dữ liệu từ trang tiếp theo hoặc trang trước đó
            var apiUrl = $"https://reqres.in/api/users?page={currentPage}&per_page={usersPerPage}";

            // Gọi phương thức getHTML để lấy dữ liệu từ URL API mới
            var response = getHTML(apiUrl);

            // Sử dụng JsonSerializer để chuyển đổi JSON thành đối tượng UserPagination
            var data = JsonSerializer.Deserialize<UserPagination>(response);

            // Xóa tất cả các điều khiển trên panel trước khi thêm lại
            panel1.Controls.Clear();

            totalUsers = data.Total;
            usersPerPage = data.PerPage;
            totalPages = data.TotalPages;

            label2.Text = $"Page {currentPage}/{totalPages}";
            label3.Text = $"Total page: {totalPages}";
            label4.Text = $"Users/Page: {usersPerPage}";
            label5.Text = $"Total Users: {totalUsers}";


            // Xóa tất cả các điều khiển trên panel trước khi thêm lại
            panel1.Controls.Clear();

            foreach (var item in data.Data)
            {
                // Tạo Label để hiển thị tên người dùng
                Label lbName = new Label();
                lbName.Text = item.FirstName + " " + item.LastName;
                lbName.Location = new Point(0, item.Id * 100);
                panel1.Controls.Add(lbName);

                // Tạo Label để hiển thị email người dùng
                Label lbEmail = new Label();
                lbEmail.Text = "Email: " + item.Email;
                lbEmail.Location = new Point(0, item.Id * 100 + 40);
                panel1.Controls.Add(lbEmail);

                // Tạo PictureBox để hiển thị ảnh đại diện của người dùng
                PictureBox pictureBox = new PictureBox();
                pictureBox.Load(item.Avatar);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; 
                pictureBox.Location = new Point(400, item.Id * 100);
                pictureBox.Size = new Size(80, 80);
                panel1.Controls.Add(pictureBox);
            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem trang hiện tại đã là trang đầu tiên hay chưa
            if (currentPage <= 1)
                return;
            currentPage--;
            LoadData();
        }
        private void next_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem trang hiện tại đã là trang cuối cùng hay chưa
            if (currentPage >= totalPages)
                return;
            currentPage++;
            LoadData();
        }
    }
}
