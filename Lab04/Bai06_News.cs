﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Bai06_News : Form
    {
        public Bai06_News(string link)
        {
            InitializeComponent();
            webView21.Source = new Uri(link);
        }
    }
}
