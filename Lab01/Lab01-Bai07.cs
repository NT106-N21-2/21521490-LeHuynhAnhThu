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

        private void button_calculate_Click(object sender, EventArgs e)
        {
            // lấy địa chỉ mạng và số mạng con từ TextBox tương ứng
            string networkAddress = textBox_input.Text;
            int numSubnets = Int32.Parse(textBox_numSubnet.Text);

            // Tách địa chỉ IP và subnet mask từ chuỗi đầu vào
            string[] ipSubnet = textBox_input.Text.Split('/');
            string ipAddress = ipSubnet[0];
            int subnet = int.Parse(ipSubnet[1]);

            // Tính toán subnet mask từ số bit subnet
            uint mask = 0xffffffff;
            mask <<= (32 - subnet);

            // Chuyển đổi địa chỉ IP và subnet mask sang dạng số nguyên không dấu
            uint ip = BitConverter.ToUInt32(IPAddress.Parse(ipAddress).GetAddressBytes(), 0);
            uint network = ip & mask;

            // tính toán số bit subnet và số host trong mỗi subnet
            int numSubnetBits = (int)Math.Ceiling(Math.Log(numSubnets, 2));
            int numHostBits = 32 - subnet - numSubnetBits;
            int numHostsPerSubnet = (int)Math.Pow(2, numHostBits) - 2;

            // tính toán địa chỉ mạng và broadcast address mới cho từng subnet
            int subnetMask = (int)Math.Pow(2, 32 - subnet) - 1;
            int subnetMaskComplement = subnetMask;
            long networkAddressBase = network & subnetMask;
            long broadcastAddressBase = networkAddressBase | subnetMaskComplement;
            long subnetAddress = networkAddressBase;

            // tạo DataTable với các cột tương ứng với các thuộc tính của Subnet
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("STT", typeof(int));
            dataTable.Columns.Add("Địa chỉ mạng", typeof(string));
            dataTable.Columns.Add("Địa chỉ đầu", typeof(string));
            dataTable.Columns.Add("Địa chỉ cuối", typeof(string));
            dataTable.Columns.Add("Địa chỉ Broadcast", typeof(string));

            for (int i = 0; i < numSubnets; i++)
            {
                // tính toán địa chỉ mạng và broadcast address cho subnet hiện tại
                int subnetMaskBits = subnet + numSubnetBits;
                int subnetMaskNew = (int)Math.Pow(2, 32 - subnetMaskBits) - 1;
                int subnetMaskComplementNew = ~subnetMaskNew;
                long networkAddressNew = subnetAddress;
                long broadcastAddressNew = networkAddressNew | subnetMaskComplementNew;

                // tính toán địa chỉ đầu và địa chỉ cuối của subnet hiện tại
                long firstIPAddress = networkAddressNew + 1;
                long lastIPAddress = broadcastAddressNew - 1;

                // tạo đối tượng DataRow với các giá trị tương ứng cho từng cột
                DataRow row = dataTable.NewRow();
                row["STT"] = i + 1;
                row["Địa chỉ mạng"] = IntToIPAddress(networkAddressNew);
                row["Địa chỉ đầu"] = IntToIPAddress(firstIPAddress);
                row["Địa chỉ cuối"] = IntToIPAddress(lastIPAddress);
                row["Địa chỉ Broadcast"] = IntToIPAddress(broadcastAddressNew);

                // thêm DataRow vào DataTable
                dataTable.Rows.Add(row);

                // cập nhật địa chỉ mạng cho subnet tiếp theo
                subnetAddress = broadcastAddressNew + 1;
            }

            // hiển thị DataTable trong DataGridView
            dataGridView_output.DataSource = dataTable;
        }

        private string IntToIPAddress(long ipAddressInt)
        {
            long[] octets = new long[4];

            octets[0] = (ipAddressInt >> 24) & 0xFF;
            octets[1] = (ipAddressInt >> 16) & 0xFF;
            octets[2] = (ipAddressInt >> 8) & 0xFF;
            octets[3] = ipAddressInt & 0xFF;

            string ipAddress = octets[0].ToString() + "." + octets[1].ToString() + "." + octets[2].ToString() + "." + octets[3].ToString();
        
            return ipAddress;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult Notification = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Notification == DialogResult.Yes)
            {
                textBox_input.Text = "";
                dataGridView_output.Text = "";
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
