﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM_assignement_2.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member nm = new Member();
            nm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin adminLogin = new Admin();
            adminLogin.Show();

            //Admindashboard ad = new Admindashboard();
            //ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Trainer t = new Trainer();
            t.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
