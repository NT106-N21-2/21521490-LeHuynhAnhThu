using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace Lab01
{
    public partial class Lab01_Bai08 : Form
    {
        public Lab01_Bai08()
        {
            InitializeComponent();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            listView_output.Clear();
            string[] data = textBox_input.Text.Split(',');

            if (data.Length < 2 || string.IsNullOrWhiteSpace(data[0]))
            {
                DialogResult Notification = MessageBox.Show("Nhập sai định dạng. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_input.Text = "";
                    return;
                }
            }

            string fullName = data[0];
            double[] grades = new double[data.Length - 1];

            for (int i = 0; i < grades.Length; i++)
            {
                if (!double.TryParse(data[i + 1], out double grade) || grade < 0 || grade > 10)
                {
                    DialogResult Notification = MessageBox.Show("Nhập sai định dạng điểm (phải nhập trong khoảng từ 0 đến 10). Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Notification == DialogResult.Yes)
                    {
                        textBox_input.Text = "";
                        return;
                    }
                }
                grades[i] = grade;
            }



            listView_output.Items.Add("Họ và tên: " + fullName);

            for (int i = 1; i < data.Length; i++)
            {
                string subject = "Môn " + i + ":";
                string grade = data[i];
                ListViewItem item = new ListViewItem(subject + " " + grade);
                listView_output.Items.Add(item);
            }

            double average = grades.Average();
            listView_output.Items.Add("Điểm trung bình: " + average.ToString("#.##"));

            double maxGrade = grades.Max();
            double minGrade = grades.Min();

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] == maxGrade)
                {
                    listView_output.Items.Add("Môn cao điểm nhất: Môn " + (i + 1) + " (" + maxGrade + ")");
                }

                if (grades[i] == minGrade)
                {
                    listView_output.Items.Add("Môn thấp điểm nhất: Môn " + (i + 1) + " (" + minGrade + ")");
                }
            }

            int passes = grades.Count(g => g >= 5);
            int fails = grades.Length - passes;

            listView_output.Items.Add("Số môn đậu: " + passes);
            listView_output.Items.Add("Số môn không đậu: " + fails);

            if (average >= 8 && minGrade >= 6.5)
            {
                listView_output.Items.Add("Xếp loại: Giỏi");
            }
            else if (average >= 6.5 && minGrade >= 5)
            {
                listView_output.Items.Add("Xếp loại: Khá");
            }
            else if (average >= 5 && minGrade >= 3.5)
            {
                listView_output.Items.Add("Xếp loại: TB");
            }
            else if (average >= 3.5 && minGrade >= 2)
            {
                listView_output.Items.Add("Xếp loại: Yếu");
            }
            else
            {
                listView_output.Items.Add("Xếp loại: Kém");
            }
        }


        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult Notification = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Notification == DialogResult.Yes)
            {
                textBox_input.Text = "";
                listView_output.Items.Clear();
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult Notification = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Notification == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
