﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hello\Documents\BookShopManagementSystem Db.mdf;Integrated Security=True;Connect Timeout=30");
        public static string Username = "";

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where Uname='" + UNameTb.Text + "'and UPass='"+UPassTb.Text+"'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                Username = UNameTb.Text;
                Billing obj = new Billing();
                obj.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }

            Con.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            AdminLogin Obj = new AdminLogin();
            Obj.Show();
            this.Hide();
        }
    }
}
