﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai04_Dashboard : Form
    {
        public Bai04_Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai04_Server1 server = new Bai04_Server1();
            server.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai04_Client client = new Bai04_Client();
            client.Show();
        }
    }
}
