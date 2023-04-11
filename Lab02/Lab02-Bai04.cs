using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Lab02.Lab02_Bai04;

namespace Lab02
{
    public partial class Lab02_Bai04 : Form
    {
        public Lab02_Bai04()
        {
            InitializeComponent();
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
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            // Mở file dialog để chọn file txt
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            richTextBox_input.Text = "Lưu mảng Học Viên vào file có đường dẫn:" + "\n" + fs.Name;
            fs.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string[] lines = richTextBox_input.Lines;
            string filePath = lines[1];

            // Tạo danh sách của sinh viên mới
            List<Student> students = new List<Student>();

            // Lấy thông tin từ các control trên form
            string name = textBox_name_in.Text;
            string id = textBox_id_in.Text;
            string phone = textBox_phone_in.Text;
            string course1= textBox_course1_in.Text;
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

            // Lưu danh sách sinh viên vào file
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
            formatter.Serialize(fs, students);
            fs.Close();

            // Xóa thông tin trên các control sau khi thêm sinh viên thành công
            textBox_name_in.Clear();
            textBox_id_in.Clear();
            textBox_phone_in.Clear();
            textBox_course1_in.Clear();
            textBox_course2_in.Clear();
            textBox_course3_in.Clear();
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            // Mở file dialog để chọn file txt
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            //double average = (double)(double.Parse(course1) + double.Parse(course2) + double.Parse(course3)) / 3;

            // Đóng StreamReader và FileStream
            sr.Close();
            fs.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {

        }

        private void button_next_Click(object sender, EventArgs e)
        {

        }
    }
}
