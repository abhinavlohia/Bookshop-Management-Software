
namespace BookShop_Management_System
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UPassTb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.LoginBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.UPassTb);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(23, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 383);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.05755F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(653, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 11.91367F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.Location = new System.Drawing.Point(289, 233);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(130, 41);
            this.LoginBtn.TabIndex = 7;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(130, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // UPassTb
            // 
            this.UPassTb.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UPassTb.Location = new System.Drawing.Point(289, 180);
            this.UPassTb.Name = "UPassTb";
            this.UPassTb.PasswordChar = '*';
            this.UPassTb.Size = new System.Drawing.Size(257, 36);
            this.UPassTb.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.98561F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(253, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Shop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.91367F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(289, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cancel";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(734, 431);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UPassTb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}