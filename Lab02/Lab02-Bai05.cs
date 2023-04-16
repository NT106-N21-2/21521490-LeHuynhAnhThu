using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab02
{
    public partial class Lab02_Bai05 : Form
    {
        public Lab02_Bai05()
        {
            InitializeComponent();
        }

        private void button_zip_Click(object sender, EventArgs e)
        {
            // Mở folder muốn lưu file
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string zipFilePath = Path.Combine(fbd.SelectedPath, "output5.zip");

            // Lấy dữ liệu từ TextBox
            string data = richTextBox_input.Text;

            // Tạo file output5.zip trong folder đã chọn và mở nó để ghi dữ liệu
            FileStream fs = new FileStream(zipFilePath, FileMode.Create);
            ZipArchive ar = new ZipArchive(fs, ZipArchiveMode.Create);

            // Tạo entry data.txt trong file zip
            ZipArchiveEntry etr = ar.CreateEntry("output5.txt");

            // Mở stream để ghi dữ liệu vào entry
            Stream s = etr.Open();

            // Viết dữ liệu vào stream
            StreamWriter sw = new StreamWriter(s);
            sw.Write(data);

            sw.Close();
            s.Close();
            ar.Dispose();
            fs.Close();
        }

        private void button_unzip_Click(object sender, EventArgs e)
        {
            // Mở folder muốn lưu file
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string zipFilePath = Path.Combine(fbd.SelectedPath, "output5.zip");
            string extractPath = Path.Combine(fbd.SelectedPath, "extracted");

            // Kiểm tra nếu thư mục đích không tồn tại, tạo mới thư mục đó
            if (!Directory.Exists(extractPath))
            {
                Directory.CreateDirectory(extractPath);
            }

            // Giải nén file output5.zip vào thư mục đích
            ZipFile.ExtractToDirectory(zipFilePath, extractPath);
        }
    }
}
