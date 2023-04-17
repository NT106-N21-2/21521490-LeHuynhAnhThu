using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            // Mở file dialog để chọn file txt
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);

            // Kiểm tra xem file có rỗng hay không
            if (fs.Length == 0)
            {
                DialogResult Notification = MessageBox.Show("File rỗng. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    ofd.ShowDialog();
                }
                else
                {
                    this.Hide();
                }
            }

            StreamReader sr = new StreamReader(fs);

            // Đọc nội dung file vào chuỗi content
            string content = sr.ReadToEnd();

            // Gán nội dung file cho thuộc tính Text của RichTextBox
            richTextBox_input.Text = content;

            int lineCount = content.Split('\n').Length;
            int wordCount = content.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int charCount = content.Length;

            string name = ofd.SafeFileName.ToString();

            string url = fs.Name.ToString();

            string size = fs.Length.ToString();

            // Hiển thị lên textBox
            textBox_name.Text = name;
            textBox_size.Text = size + " bytes";
            textBox_url.Text = url;
            textBox_line.Text = lineCount.ToString();
            textBox_word.Text = wordCount.ToString();
            textBox_character.Text = charCount.ToString();

            // Đóng StreamReader và FileStream
            sr.Close();
            fs.Close();
        }
    }
}
