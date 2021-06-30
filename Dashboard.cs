using System;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hello\Documents\BookShopManagementSystem Db.mdf;Integrated Security=True;Connect Timeout=30");

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select sum(Bcity) from BookTbl",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Bookstock.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("select sum(Amount) from BillTbl", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            AmountLbl.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from UserTbl", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            UsersLbl.Text = dt2.Rows[0][0].ToString();
            Con.Close();
        } 

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
