using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            int vehicle = comboBox_vehicle.SelectedIndex;
            int fuel = comboBox_fuel.SelectedIndex;

            double full_fuel = 0, distance = 0;
            if (vehicle == 0)
            {
                if (fuel == 0 || fuel == 1)
                {
                    full_fuel = 3.7;
                    distance = (full_fuel / 1.6) * 100;
                }
                else
                {
                    DialogResult Notification = MessageBox.Show("Xe Wave Alpha không sử dụng Dầu DO 0,05S-II. Bạn có muốn chọn lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Notification == DialogResult.Yes)
                    {
                        comboBox_fuel.SelectedIndex = -1;
                    }
                }
            }
            else if (vehicle == 1)
            {
                if (fuel == 0 || fuel == 1)
                {
                    full_fuel = 3.8;
                    distance = (full_fuel / 1.99) * 100;
                }
                else
                {
                    DialogResult Notification = MessageBox.Show("Xe Sirius không sử dụng Dầu DO 0,05S-II. Bạn có muốn chọn lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Notification == DialogResult.Yes)
                    {
                        comboBox_fuel.SelectedIndex = -1;
                    }
                }
            }
            else if (vehicle == 2)
            {
                if (fuel == 0 || fuel == 1)
                {
                    full_fuel = 5.2;
                    distance = (full_fuel / 1.87) * 100;
                }
                else
                {
                    DialogResult Notification = MessageBox.Show("Xe Vision không sử dụng Dầu DO 0,05S-II. Bạn có muốn chọn lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Notification == DialogResult.Yes)
                    {
                        comboBox_fuel.SelectedIndex = -1;
                    }
                }
            }
            else if (vehicle == 3)
            {
                if (fuel == 0)
                {
                    full_fuel = 6;
                    distance = (full_fuel / 2.02) * 100;
                }
                else
                {
                    DialogResult Notification = MessageBox.Show("Xe Lead chỉ sử dụng Xăng RON 95-III. Bạn có muốn chọn lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Notification == DialogResult.Yes)
                    {
                        comboBox_fuel.SelectedIndex = -1;
                    }
                }
            }
            else if (vehicle == 4)
            {
                if (fuel == 0)
                {
                    full_fuel = 4.5;
                    distance = (full_fuel / 1.7) * 100;
                }
                else
                {
                    DialogResult Notification = MessageBox.Show("Xe Winner chỉ sử dụng Xăng RON 95-III. Bạn có muốn chọn lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Notification == DialogResult.Yes)
                    {
                        comboBox_fuel.SelectedIndex = -1;
                    }
                }
            }
            else if (vehicle == 5)
            {
                if (fuel == 0)
                {
                    full_fuel = 4.4;
                    distance = (full_fuel / 2.17) * 100;
                }
                else
                {
                    DialogResult Notification = MessageBox.Show("Xe AirBlade 150 chỉ sử dụng Xăng RON 95-III. Bạn có muốn chọn lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Notification == DialogResult.Yes)
                    {
                        comboBox_fuel.SelectedIndex = -1;
                    }
                }
            }
            else if (vehicle == 6)
            {
                if (fuel == 2)
                {
                    full_fuel = 70;
                    distance = (full_fuel / 13) * 100;
                }
                else
                {
                    DialogResult Notification = MessageBox.Show("Xe tải 9 tấn chỉ sử dụng Dầu DO 0,05S-II. Bạn có muốn chọn lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Notification == DialogResult.Yes)
                    {
                        comboBox_fuel.SelectedIndex = -1;
                    }
                }
            }

            double paid = 0;
            double a = 26.830;
            double b = 26.070;
            double c = 21.310;

            if (fuel == 0)
            {
                paid = full_fuel * a;
            }
            else if (fuel == 1)
            {
                paid = full_fuel * b;
            }
            else
            {
                paid = full_fuel * c;
            }

            textBox_distance.Text = string.Format("{0:N2} km", distance);
            textBox_paid.Text = string.Format("{0:N3} đồng", paid);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
