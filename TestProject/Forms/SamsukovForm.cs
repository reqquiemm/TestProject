﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject.Forms
{
    public partial class SamsukovForm : Form
    {
        public SamsukovForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SamsukovForm_Load(object sender, EventArgs e)
        {

        }
    }
}
