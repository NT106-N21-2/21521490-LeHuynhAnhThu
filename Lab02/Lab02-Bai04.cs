using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Lab02.Lab02_Bai04;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02
{
    public partial class Lab02_Bai04 : Form
    {
        public Lab02_Bai04()
        {
            InitializeComponent();
        }

        private void textBox_id_in_Leave(object sender, EventArgs e)
        {
            if (textBox_id_in.Text.Length != 8)
            {
                DialogResult Notification = MessageBox.Show("MSSV phải là một số có 8 chữ số. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_id_in.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }
        }

        private void textBox_phone_in_Leave(object sender, EventArgs e)
        {
            if (textBox_phone_in.Text.Length != 10 || !textBox_phone_in.Text.StartsWith("0"))
            {
                DialogResult Notification = MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bởi số 0. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_phone_in.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }
        }

        private void textBox_course1_in_Leave(object sender, EventArgs e)
        {
            float mark;

            if (float.TryParse(textBox_course1_in.Text, out mark))
            {
                if (mark < 0 || mark > 10)
                {
                    DialogResult Notification = MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Notification == DialogResult.Yes)
                    {
                        textBox_course1_in.Text = "";
                    }
                    else
                    {
                        this.Hide();
                    }
                }
            }
            else
            {
                DialogResult Notification = MessageBox.Show("Định dạng không hợp lệ. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_course1_in.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }
        }

        private void textBox_course2_in_Leave(object sender, EventArgs e)
        {
            float mark;

            if (float.TryParse(textBox_course1_in.Text, out mark))
            {
                if (mark < 0 || mark > 10)
                {
                    DialogResult Notification = MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Notification == DialogResult.Yes)
                    {
                        textBox_course2_in.Text = "";
                    }
                    else
                    {
                        this.Hide();
                    }
                }
            }
            else
            {
                DialogResult Notification = MessageBox.Show("Định dạng không hợp lệ. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_course2_in.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }
        }

        private void textBox_course3_in_Leave(object sender, EventArgs e)
        {
            float mark;

            if (float.TryParse(textBox_course1_in.Text, out mark))
            {
                if (mark < 0 || mark > 10)
                {
                    DialogResult Notification = MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Notification == DialogResult.Yes)
                    {
                        textBox_course3_in.Text = "";
                    }
                    else
                    {
                        this.Hide();
                    }
                }
            }
            else
            {
                DialogResult Notification = MessageBox.Show("Định dạng không hợp lệ. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_course3_in.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }
        }

        [Serializable]
        public class Student
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public string Phone { get; set; }
            public float Course1 { get; set; }
            public float Course2 { get; set; }
            public float Course3 { get; set; }
            public float Average { get; set; }
        }

        private int currentPage = 0; // số trang hiện tại
        private int maxPage = 0; // tối đa số trang hiển thị
        private List<Student> students = new List<Student>(); // danh sách sinh viên

        private void button_add_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các control trên form
            string name = textBox_name_in.Text;
            string id = textBox_id_in.Text;
            string phone = textBox_phone_in.Text;
            string course1 = textBox_course1_in.Text;
            string course2 = textBox_course2_in.Text;
            string course3 = textBox_course3_in.Text;

            // Tạo một đối tượng sinh viên mới
            Student student = new Student();
            student.Name = name;
            student.Id = int.Parse(id);
            student.Phone = phone;
            student.Course1 = float.Parse(course1);
            student.Course2 = float.Parse(course2);
            student.Course3 = float.Parse(course3);

            // Thêm sinh viên vào danh sách
            students.Add(student);

            // Xóa thông tin trên các control sau khi thêm sinh viên thành công
            textBox_name_in.Clear();
            textBox_id_in.Clear();
            textBox_phone_in.Clear();
            textBox_course1_in.Clear();
            textBox_course2_in.Clear();
            textBox_course3_in.Clear();
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            // Mở file dialog để chọn file txt
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.Create);

            // Lưu danh sách sinh viên vào file
            BinaryFormatter bw = new BinaryFormatter();
            bw.Serialize(fs, students);
            fs.Close();
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            // Mở file dialog để chọn file txt
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);

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

            // Đọc danh sách sinh viên từ file
            BinaryFormatter formatter = new BinaryFormatter();
            students = (List<Student>)formatter.Deserialize(fs);
            fs.Close();

            // Tính điểm trung bình cho từng sinh viên
            for (int i = 0; i < students.Count; i++)
            {
                Student student = students[i];
                float average = (student.Course1 + student.Course2 + student.Course3) / 3;
                student.Average = average;
                students[i] = student;
            }

            // Tính toán số trang tối đa
            maxPage = (int)Math.Ceiling((double)students.Count / 1); // giả sử hiển thị 1 sinh viên mỗi trang

            // Xuất dữ liệu cho trang đầu tiên
            ShowStudentByPage(0);

            // Chọn folder lưu file
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string filePath = Path.Combine(fbd.SelectedPath, "output4.txt");

            // Ghi danh sách sinh viên đã tính điểm trung bình xuống file
            fs = new FileStream(filePath, FileMode.Create);
            formatter = new BinaryFormatter();
            formatter.Serialize(fs, students);
            fs.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                ShowStudentByPage(currentPage);
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (currentPage < maxPage - 1)
            {
                currentPage++;
                ShowStudentByPage(currentPage);
            }
        }

        // Hiển thị dữ liệu sinh viên cho trang tương ứng
        private void ShowStudentByPage(int page)
        {
            richTextBox_output.Clear();
            int startIndex = page * 1; // giả sử hiển thị 1 sinh viên mỗi trang
            int endIndex = Math.Min(startIndex + 1, students.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                Student student = students[i];

                // Hiển thị lên textBox
                textBox_page.Text = (currentPage + 1).ToString();
                textBox_name_out.Text = student.Name.ToString();
                textBox_id_out.Text = student.Id.ToString();
                textBox_phone_out.Text = student.Phone.ToString();
                textBox_course1_out.Text = student.Course1.ToString();
                textBox_course2_out.Text = student.Course2.ToString();
                textBox_course3_out.Text = student.Course3.ToString();
                textBox_average_out.Text = student.Average.ToString();
            }

            // Hiển thị lên richTextBox
            foreach (Student student in students)
            {
                richTextBox_output.AppendText($"Họ và tên: {student.Name}\n");
                richTextBox_output.AppendText($"MSSV: {student.Id}\n");
                richTextBox_output.AppendText($"Số điện thoại: {student.Phone}\n");
                richTextBox_output.AppendText($"Môn 1: {student.Course1}\n");
                richTextBox_output.AppendText($"Môn 2: {student.Course2}\n");
                richTextBox_output.AppendText($"Môn 3: {student.Course3}\n");
                richTextBox_output.AppendText($"Điểm trung bình: {student.Average}\n\n");
            }
        }
    }
}
