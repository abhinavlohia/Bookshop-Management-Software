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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            populate();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {
            UsernameLbl.Text = Login.Username;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

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
            BookListDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
            try
            {
                Con.Open();
                String query = "Update BookTbl set BCity = " + newQty + "where BId=" + key + ";";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Book Updated Successfully");
                Con.Close();
                populate();
                //Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int n = 0, Grdtotal = 0;
        private void AddBtn_Click(object sender, EventArgs e)
        {
           
            if(QtyTb.Text =="" || Convert.ToInt32(QtyTb.Text)>stock)
            {
                MessageBox.Show("Not Enough Stock");
            }
            else
            {
                int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = BTitleTb.Text;
                newRow.Cells[2].Value = PriceTb.Text;
                newRow.Cells[3].Value = QtyTb.Text;
                newRow.Cells[4].Value = total;
                
                BillDGV.Rows.Add(newRow);
                n++;
                UpdateBook();

                Grdtotal += total;
                TotalLbl.Text = "Total: Rs " + Grdtotal;
            }
        }

        int key = 0,stock = 0;
        private void BookListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BTitleTb.Text = BookListDGV.SelectedRows[0].Cells[1].Value.ToString();
            //QtyTb.Text = BookListDGV.SelectedRows[0].Cells[4].Value.ToString();
            PriceTb.Text = BookListDGV.SelectedRows[0].Cells[5].Value.ToString();

            if (BTitleTb.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(BookListDGV.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(BookListDGV.SelectedRows[0].Cells[4].Value.ToString());
            }
        }

        private void TotalLbl_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        string prodname;
        int prodid, prodqty, prodprice, tottal, pos = 60;

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (ClientBtn.Text == "" || BTitleTb.Text == "")
            {
                MessageBox.Show("Select Client Name");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BillTbl values('" + UsernameLbl.Text + "','" + ClientBtn.Text + "'," + Grdtotal + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Saved Successfully");
                    Con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }



                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }


            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Book Shop", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID PRODUCT   PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {

                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                pos = pos + 20;

            }
            e.Graphics.DrawString("Grand Total: RS" + Grdtotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(60, pos + 50));
            e.Graphics.DrawString("***********BookStore***********", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(40, pos + 85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            Grdtotal = 0;
        }

        private void Reset()
        {
            BTitleTb.Text = "";
            PriceTb.Text = "";
            QtyTb.Text = "";
            ClientBtn.Text = "";
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
