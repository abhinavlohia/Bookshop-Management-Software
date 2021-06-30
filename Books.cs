using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 


namespace BookShop_Management_System
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            populate();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Books_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hello\Documents\BookShopManagementSystem Db.mdf;Integrated Security=True;Connect Timeout=30");

        //diaplay table in 2d grid
        private void populate()
        {
            Con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
           /* DataTable dtb1 = new DataTable();
            sda.Fill(dtb1);
            BookDGV.DataSource = dtb1;*/
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();

        }


        private void Filter()
        {
            Con.Open();
            string query = "select * from BookTbl where BCat = '" +CatCbSearchCb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BautTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BcatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");

            }

            else
            {
                try
                {
                    Con.Open();
                    String query = "Insert into BookTbl values('" + BTitleTb.Text + "' , " +
                        "                                      '" + BautTb.Text + "' , " +
                        "                                      '" + BcatCb.SelectedItem.ToString() + "' , " +
                        "                                      '" + QtyTb.Text + "' , " +
                        "                                      '" + PriceTb.Text + "')";

                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Saved Successfully");
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



        private void CatCbSearchCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }

        private void CatCbSearchCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            populate();
            CatCbSearchCb.SelectedIndex = -1;
        }

        private void Reset()
        {
            BTitleTb.Text = "";
            BautTb.Text = "";
            BcatCb.SelectedIndex = -1;
            PriceTb.Text = "";
            QtyTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
           
        }

        int key = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BTitleTb.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            BautTb.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
            CatCbSearchCb.SelectedItem = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            QtyTb.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
            PriceTb.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();
           
            if(BTitleTb.Text=="")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("Missing Information");

            }

            else
            {
                try
                {
                    Con.Open();
                    String query = "delete from BookTbl where BId =" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Deleted Successfully");
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
            if (BTitleTb.Text == "" || BautTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BcatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");

            }

            else
            {
                try
                {
                    Con.Open();
                    String query = "Update BookTbl set BTitle = '" + BTitleTb.Text + "', BAuthor = '" + BautTb.Text + "',BCat = '" + BcatCb.SelectedItem.ToString() + "',BCity='" + QtyTb.Text + "',BPrice='" + PriceTb.Text + "' where BId = "+key+";";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Updated Successfully");
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

        private void label9_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }
    }
}
