﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_of_triangular_matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void закрепитьПоверхДургихОконToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
        }
    }
}
