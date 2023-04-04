using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }

        public bool IsValidIPAddress(string ipAddress)
        {
            // Kiểm tra độ dài địa chỉ IP
            string[] ipParts = ipAddress.Split('.');
            if (ipParts.Length != 4)
            {
                return false;
            }

            // Kiểm tra giá trị của từng phần
            foreach (string ipPart in ipParts)
            {
                int ipInt;
                if (!int.TryParse(ipPart, out ipInt) || ipInt < 0 || ipInt > 255)
                {
                    return false;
                }
            }

            // Địa chỉ IP hợp lệ
            return true;
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            // Kiểm tra giá trị nhập vào có hợp lệ không và lấy địa chỉ mạng, số mạng con cần chia từ các điều khiển đầu vào trên giao diện
            if (textBox_input.Text.Length == 0 || textBox_numSubnet.Text.Length == 0)
            {
                DialogResult Notification = MessageBox.Show("Thiếu dữ liệu để có thể chia mạng. Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_input.Text = "";
                    textBox_numSubnet.Text = "";
                    dataGridView_output.DataSource = null;
                }
                else
                {
                    this.Hide();
                }
            }

            string[] ipSubnet = textBox_input.Text.Split('/');
            if (ipSubnet.Length != 2 || !IsValidIPAddress(ipSubnet[0]))
            {
                DialogResult Notification = MessageBox.Show("Địa chỉ mạng/Subnet Mask không đúng định dạng! Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_input.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }

            string ip = ipSubnet[0];
            int subnet;
            if (!int.TryParse(ipSubnet[1], out subnet) || subnet < 8 || subnet > 32)
            {
                DialogResult Notification = MessageBox.Show("Subnet Mask không đúng định dạng số! Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_input.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }

            int numSubnets;
            if (!int.TryParse(textBox_numSubnet.Text, out numSubnets) || numSubnets <= 0)
            {
                DialogResult Notification = MessageBox.Show("Số lượng mạng con không đúng định dạng hoặc không hợp lệ! Bạn có muốn thử lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Notification == DialogResult.Yes)
                {
                    textBox_numSubnet.Text = "";
                }
                else
                {
                    this.Hide();
                }
            }

            // Tính toán số bit mượn và số bit host còn lại
            int borrowedBits = (int)Math.Ceiling(Math.Log(numSubnets, 2));
            int hostBits = 32 - borrowedBits - subnet;

            // Chuyển đổi địa chỉ mạng thành dạng số nguyên
            byte[] ipBytes = IPAddress.Parse(ip).GetAddressBytes();
            uint networkAddress = (uint)(ipBytes[0] << 24) | (uint)(ipBytes[1] << 16) | (uint)(ipBytes[2] << 8) | (uint)(ipBytes[3]);

            // tạo DataTable với các cột tương ứng với các thuộc tính của Subnet
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("STT", typeof(int));
            dataTable.Columns.Add("Địa chỉ mạng", typeof(string));
            dataTable.Columns.Add("Địa chỉ đầu", typeof(string));
            dataTable.Columns.Add("Địa chỉ cuối", typeof(string));
            dataTable.Columns.Add("Địa chỉ Broadcast", typeof(string));

            // Tính toán các thông tin về từng mạng con
            for (int i = 0; i < numSubnets; i++)
            {
                double jump = Math.Pow(2, hostBits);
                uint subnetCurrent = networkAddress + (uint)(i * jump);
                uint broadcast = subnetCurrent + (uint)(jump - 1); ;
                uint firstHost = subnetCurrent + 1;
                uint lastHost = broadcast - 1;

                // tạo đối tượng DataRow với các giá trị tương ứng cho từng cột
                DataRow row = dataTable.NewRow();
                row["STT"] = i + 1;
                row["Địa chỉ mạng"] = string.Format("{0}.{1}.{2}.{3}", (subnetCurrent >> 24) & 255, (subnetCurrent >> 16) & 255, (subnetCurrent >> 8) & 255, subnetCurrent & 255);
                row["Địa chỉ đầu"] = string.Format("{0}.{1}.{2}.{3}", (firstHost >> 24) & 255, (firstHost >> 16) & 255, (firstHost >> 8) & 255, firstHost & 255);
                row["Địa chỉ cuối"] = string.Format("{0}.{1}.{2}.{3}", (lastHost >> 24) & 255, (lastHost >> 16) & 255, (lastHost >> 8) & 255, lastHost & 255);
                row["Địa chỉ Broadcast"] = string.Format("{0}.{1}.{2}.{3}", (broadcast >> 24) & 255, (broadcast >> 16) & 255, (broadcast >> 8) & 255, broadcast & 255);

                // thêm DataRow vào DataTable
                dataTable.Rows.Add(row);
            }

            // hiển thị DataTable trong DataGridView
            dataGridView_output.DataSource = dataTable;

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult Notification = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Notification == DialogResult.Yes)
            {
                textBox_input.Text = "";
                textBox_numSubnet.Text = "";
                dataGridView_output.DataSource = null;
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
