﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormBUtton : Form
    {
        public FormBUtton()
        {
            InitializeComponent();
        }

        private void FormBUtton_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "請按我一下")
                button1.Text = "我已經按過了";
            else if (button1.Text == "我已經被按過了")
                button1.Text = "請按我一下";
        }
    }
}
