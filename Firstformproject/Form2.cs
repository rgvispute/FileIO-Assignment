﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firstformproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Box1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "admin" && txtemail.Text == "rv@gmail.com" && txtmobile.Text == "9850608139" && txtaddress.Text == "Pune")
            {
                MessageBox.Show("Success");
            }
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtname.Clear();
            txtemail.Clear();
            txtmobile.Clear();
            txtaddress.Clear();
        }
    }
}
