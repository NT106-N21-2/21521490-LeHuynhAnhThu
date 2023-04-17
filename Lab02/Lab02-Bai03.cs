using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai03 : Form
    {
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        private double Evaluate(string expression)
        {
            return Convert.ToDouble(new DataTable().Compute(expression, ""));
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            // Mở file dialog để chọn file txt
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            // Lấy nội dung từ file và tính toán
            string[] lines = richTextBox_input.Lines;
            for (int i = 0; i < lines.Length; i++)
            {
                double result = Evaluate(lines[i]);
                string output = lines[i] + " = " + result.ToString(result == (int)result ? "" : "#.##") + "\n";
                sw.Write(output);
                richTextBox_output.AppendText(output);
            }

            // Đóng StreamReader và FileStream
            sw.Close();
            fs.Close();
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
            string content = sr.ReadToEnd();

            // Hiển thị lên richTextBox
            richTextBox_input.Text = "";
            richTextBox_input.Text = content;

            // Đóng StreamReader và FileStream
            sr.Close();
            fs.Close();
        }
    }
}
