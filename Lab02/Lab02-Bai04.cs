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

        private void textBox_id_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu người dùng nhập vào ký tự không phải là số và không phải là phím Backspace (ký tự ASCII của phím Backspace là 8)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // Không cho phép hiển thị ký tự đó trong TextBox
                MessageBox.Show("Định dạng không hợp lệ. Vui lòng nhập số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Nếu độ dài của chuỗi trong TextBox khác 8 ký tự
            if (textBox_id_in.Text.Length != 8 && e.KeyChar != 8)
            {
                e.Handled = true; // Không cho phép hiển thị ký tự đó trong TextBox
                MessageBox.Show("Định dạng không hợp lệ. Mã số sinh viên phải có đúng 8 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_phone_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu người dùng nhập vào ký tự không phải là số và không phải là phím Backspace (ký tự ASCII của phím Backspace là 8)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                DialogResult Notification = MessageBox.Show("Định dạng không hợp lệ. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_phone_in.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }

            // Nếu người dùng nhập vào ký tự thứ 11 (và sau đó) hoặc ký tự đầu tiên không phải là số 0
            if (textBox_phone_in.Text.Length == 10 && textBox_phone_in.Text[0] != '0')
            {
                e.Handled = true;
                DialogResult Notification = MessageBox.Show("Định dạng không hợp lệ. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void textBox_course1_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu người dùng nhập vào ký tự không phải là số, không phải là phím Backspace (ký tự ASCII của phím Backspace là 8), và không phải là dấu chấm (phần thập phân)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
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

            // Nếu người dùng nhập vào dấu chấm (phần thập phân) và đã có một dấu chấm trong chuỗi
            if (e.KeyChar == '.' && textBox_course1_in.Text.Contains("."))
            {
                e.Handled = true;
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

            // Nếu độ dài của chuỗi trong TextBox lớn hơn hoặc bằng 3 (bao gồm cả dấu chấm)
            if (textBox_course1_in.Text.Length >= 3)
            {
                e.Handled = true;
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

            // Nếu giá trị của chuỗi trong TextBox lớn hơn 10
            if (double.Parse(textBox_course1_in.Text) < 0 || double.Parse(textBox_course1_in.Text) > 10)
            {
                e.Handled = true;
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

        private void textBox_course2_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu người dùng nhập vào ký tự không phải là số, không phải là phím Backspace (ký tự ASCII của phím Backspace là 8), và không phải là dấu chấm (phần thập phân)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
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

            // Nếu người dùng nhập vào dấu chấm (phần thập phân) và đã có một dấu chấm trong chuỗi
            if (e.KeyChar == '.' && textBox_course2_in.Text.Contains("."))
            {
                e.Handled = true;
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

            // Nếu độ dài của chuỗi trong TextBox lớn hơn hoặc bằng 3 (bao gồm cả dấu chấm)
            if (textBox_course2_in.Text.Length >= 3)
            {
                e.Handled = true;
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

            // Nếu giá trị của chuỗi trong TextBox lớn hơn 10
            if (double.Parse(textBox_course2_in.Text) < 0 || double.Parse(textBox_course2_in.Text) > 10)
            {
                e.Handled = true;
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

        private void textBox_course3_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu người dùng nhập vào ký tự không phải là số, không phải là phím Backspace (ký tự ASCII của phím Backspace là 8), và không phải là dấu chấm (phần thập phân)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
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

            // Nếu người dùng nhập vào dấu chấm (phần thập phân) và đã có một dấu chấm trong chuỗi
            if (e.KeyChar == '.' && textBox_course3_in.Text.Contains("."))
            {
                e.Handled = true;
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

            // Nếu độ dài của chuỗi trong TextBox lớn hơn hoặc bằng 3 (bao gồm cả dấu chấm)
            if (textBox_course3_in.Text.Length >= 3)
            {
                e.Handled = true;
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

            // Nếu giá trị của chuỗi trong TextBox lớn hơn 10
            if (double.Parse(textBox_course3_in.Text) < 0 || double.Parse(textBox_course3_in.Text) > 10)
            {
                e.Handled = true;
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
            public string Id { get; set; }
            public string Phone { get; set; }
            public string Course1 { get; set; }
            public string Course2 { get; set; }
            public string Course3 { get; set; }
            public string Average { get; set; }
        }

        private int currentPage = 0; // số trang hiện tại
        private int maxPage = 0; // tối đa số trang hiển thị
        private List<Student> students; // danh sách sinh viên

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
            student.Id = id;
            student.Phone = phone;
            student.Course1 = course1;
            student.Course2 = course2;
            student.Course3 = course3;

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

            // Đọc danh sách sinh viên từ file
            BinaryFormatter formatter = new BinaryFormatter();
            students = (List<Student>)formatter.Deserialize(fs);
            fs.Close();

            // Tính điểm trung bình cho từng sinh viên
            for (int i = 0; i < students.Count; i++)
            {
                Student student = students[i];
                double average = (double)(double.Parse(student.Course1) + double.Parse(student.Course2) + double.Parse(student.Course3)) / 3;
                student.Average = average.ToString();
                students[i] = student;
            }

            // Tính toán số trang tối đa
            maxPage = (int)Math.Ceiling((double)students.Count / 1); // giả sử hiển thị 1 sinh viên mỗi trang

            // Xuất dữ liệu cho trang đầu tiên
            ShowStudentByPage(0);

            // Ghi danh sách sinh viên đã tính điểm trung bình xuống file
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            fs = new FileStream(sfd.FileName, FileMode.Create);
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
            int startIndex = page * 1; // giả sử hiển thị 1 sinh viên mỗi trang
            int endIndex = Math.Min(startIndex + 1, students.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                Student student = students[i];
                textBox_page.Text = (currentPage + 1).ToString();
                textBox_name_out.Text = student.Name.ToString();
                textBox_id_out.Text = student.Id.ToString();
                textBox_phone_out.Text = student.Phone.ToString();
                textBox_course1_out.Text = student.Course1.ToString();
                textBox_course2_out.Text = student.Course2.ToString();
                textBox_course3_out.Text = student.Course3.ToString();
                textBox_average_out.Text = student.Average.ToString();
            }
        }

    }
}
