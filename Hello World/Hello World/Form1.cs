﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World!";
        }

        private void btwCMI_Click(object sender, EventArgs e)
        {
            lblCMI.Text = "Haha! Tricked you";
        }
    }
}
