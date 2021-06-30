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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            populate();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hello\Documents\BookShopManagementSystem Db.mdf;Integrated Security=True;Connect Timeout=30");

        //diaplay table in 2d grid
        private void populate()
        {
            Con.Open();
            string query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            /* DataTable dtb1 = new DataTable();
             sda.Fill(dtb1);
             BookDGV.DataSource = dtb1;*/
            var ds = new DataSet();
            sda.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PhoneTb.Text == "" || AddTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }

            else
            {
                try
                {
                    Con.Open();
                    String query = "Insert into UserTbl values('" + UnameTb.Text + "' , " +
                        "                                      '" + AddTb.Text + "' , " +
                        "                                      '" + PhoneTb.Text + "' , " +
                        "                                      '" + PassTb.Text + "')";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Saved Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || AddTb.Text == "" || PhoneTb.Text == "" || PassTb.Text == "" )
            {
                MessageBox.Show("Missing Information");

            }

            else
            {
                try
                {
                    Con.Open();
                    String query = "Update UserTbl set UName = '" + UnameTb.Text + "', UAdd = '" + AddTb.Text + "', UPhone='" + PhoneTb.Text + "',UPass ='" + PassTb.Text + "' where UId = " + key + ";";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }


        private void Reset()
        {
            UnameTb.Text = "";
            AddTb.Text = "";
            PhoneTb.Text ="";
            PassTb.Text = "";
            
        }
        
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information");

            }

            else
            {
                try
                {
                    Con.Open();
                    String query = "delete from UserTbl where UId =" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        int key = 0;
        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            AddTb.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = UserDGV.SelectedRows[0].Cells[3].Value.ToString();
            PassTb.Text = UserDGV.SelectedRows[0].Cells[4].Value.ToString();

            if (UnameTb.Text == "")
            {
                key = 0; 
            }
            else
            {
                key = Convert.ToInt32(UserDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
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

        private void label8_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }
    }
}
