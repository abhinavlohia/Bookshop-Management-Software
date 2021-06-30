
namespace BookShop_Management_System
{
    partial class Books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button SaveBtn;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            this.panel2 = new System.Windows.Forms.Panel();
            this.BookDGV = new System.Windows.Forms.DataGridView();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.CatCbSearchCb = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.BcatCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BautTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTitleTb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            SaveBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = System.Drawing.Color.RoyalBlue;
            SaveBtn.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            SaveBtn.ForeColor = System.Drawing.Color.White;
            SaveBtn.Location = new System.Drawing.Point(167, 245);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new System.Drawing.Size(137, 45);
            SaveBtn.TabIndex = 20;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.UsernameLbl);
            this.panel2.Controls.Add(this.BookDGV);
            this.panel2.Controls.Add(this.RefreshBtn);
            this.panel2.Controls.Add(this.CatCbSearchCb);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.ResetBtn);
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.EditBtn);
            this.panel2.Controls.Add(SaveBtn);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.PriceTb);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.QtyTb);
            this.panel2.Controls.Add(this.BcatCb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BautTb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BTitleTb);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(368, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 751);
            this.panel2.TabIndex = 3;
            // 
            // BookDGV
            // 
            this.BookDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.BookDGV.EnableHeadersVisualStyles = false;
            this.BookDGV.Location = new System.Drawing.Point(19, 415);
            this.BookDGV.Name = "BookDGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BookDGV.RowHeadersVisible = false;
            this.BookDGV.RowHeadersWidth = 59;
            this.BookDGV.RowTemplate.Height = 32;
            this.BookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDGV.Size = new System.Drawing.Size(1004, 319);
            this.BookDGV.TabIndex = 28;
            this.BookDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDGV_CellContentClick);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.RefreshBtn.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.Location = new System.Drawing.Point(641, 365);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(119, 35);
            this.RefreshBtn.TabIndex = 27;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // CatCbSearchCb
            // 
            this.CatCbSearchCb.Font = new System.Drawing.Font("Century Gothic", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CatCbSearchCb.FormattingEnabled = true;
            this.CatCbSearchCb.Items.AddRange(new object[] {
            "Programming",
            "Networking",
            "Maths",
            "Physics",
            "Novels",
            "Biography"});
            this.CatCbSearchCb.Location = new System.Drawing.Point(388, 367);
            this.CatCbSearchCb.Name = "CatCbSearchCb";
            this.CatCbSearchCb.Size = new System.Drawing.Size(229, 30);
            this.CatCbSearchCb.TabIndex = 26;
            this.CatCbSearchCb.Text = "Filter By Category";
            this.CatCbSearchCb.SelectedIndexChanged += new System.EventHandler(this.CatCbSearchCb_SelectedIndexChanged);
            this.CatCbSearchCb.SelectionChangeCommitted += new System.EventHandler(this.CatCbSearchCb_SelectionChangeCommitted);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.98561F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.ForestGreen;
            this.label13.Location = new System.Drawing.Point(428, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 33);
            this.label13.TabIndex = 25;
            this.label13.Text = "Book List";
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.ResetBtn.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(693, 245);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(137, 45);
            this.ResetBtn.TabIndex = 23;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(518, 245);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(137, 45);
            this.DeleteBtn.TabIndex = 22;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(342, 245);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(137, 45);
            this.EditBtn.TabIndex = 21;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(869, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 30);
            this.label12.TabIndex = 19;
            this.label12.Text = "Price";
            // 
            // PriceTb
            // 
            this.PriceTb.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceTb.Location = new System.Drawing.Point(869, 167);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(138, 36);
            this.PriceTb.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(706, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 30);
            this.label11.TabIndex = 17;
            this.label11.Text = "Quantity";
            // 
            // QtyTb
            // 
            this.QtyTb.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QtyTb.Location = new System.Drawing.Point(706, 165);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(138, 36);
            this.QtyTb.TabIndex = 16;
            // 
            // BcatCb
            // 
            this.BcatCb.Font = new System.Drawing.Font("Century Gothic", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BcatCb.FormattingEnabled = true;
            this.BcatCb.Items.AddRange(new object[] {
            "Programming",
            "Networking",
            "Maths",
            "Physics",
            "Novels",
            "Biography"});
            this.BcatCb.Location = new System.Drawing.Point(473, 165);
            this.BcatCb.Name = "BcatCb";
            this.BcatCb.Size = new System.Drawing.Size(214, 30);
            this.BcatCb.TabIndex = 15;
            this.BcatCb.Text = "Select Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(473, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Categories";
            // 
            // BautTb
            // 
            this.BautTb.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BautTb.Location = new System.Drawing.Point(261, 165);
            this.BautTb.Name = "BautTb";
            this.BautTb.Size = new System.Drawing.Size(193, 36);
            this.BautTb.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(261, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.05755F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(997, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = " X";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(45, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book Title";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // BTitleTb
            // 
            this.BTitleTb.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTitleTb.Location = new System.Drawing.Point(45, 164);
            this.BTitleTb.Name = "BTitleTb";
            this.BTitleTb.Size = new System.Drawing.Size(197, 36);
            this.BTitleTb.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18.1295F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(428, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Shop";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(24, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 751);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(10, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(80, 63);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18.1295F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(93, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 43);
            this.label10.TabIndex = 10;
            this.label10.Text = "Book Shop";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Location = new System.Drawing.Point(35, 450);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(268, 58);
            this.panel6.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.98561F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(71, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 33);
            this.label9.TabIndex = 11;
            this.label9.Text = "Logout";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Location = new System.Drawing.Point(35, 358);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(268, 58);
            this.panel5.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.98561F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(71, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 33);
            this.label8.TabIndex = 11;
            this.label8.Text = "Dashboard";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(35, 273);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 58);
            this.panel4.TabIndex = 12;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.98561F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(71, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 33);
            this.label6.TabIndex = 11;
            this.label6.Text = "Users";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(35, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 58);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.98561F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(71, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 33);
            this.label7.TabIndex = 11;
            this.label7.Text = "Books";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Century Gothic", 13.98561F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLbl.ForeColor = System.Drawing.Color.Black;
            this.UsernameLbl.Location = new System.Drawing.Point(10, 12);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(98, 33);
            this.UsernameLbl.TabIndex = 42;
            this.UsernameLbl.Text = " Books";
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1434, 805);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BTitleTb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox QtyTb;
        private System.Windows.Forms.ComboBox BcatCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BautTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.ComboBox CatCbSearchCb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.DataGridView BookDGV;
        private System.Windows.Forms.Label UsernameLbl;
    }
}