﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_Management_System
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UPassTb.Text == "Password")
            {
                Books Obj = new Books();
                Obj.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Wrong Password");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
