namespace Dentistry_Management
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.ComboBox();
            this.TaiKhoan = new System.Windows.Forms.TextBox();
            this.MatKhau = new System.Windows.Forms.TextBox();
            this.DangNhap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Reset = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 77);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(340, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Nha Khoa";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(84, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(84, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu";
            // 
            // Role
            // 
            this.Role.FormattingEnabled = true;
            this.Role.Items.AddRange(new object[] {
            "Quản trị viên",
            "Nhân viên",
            "Nha sĩ"});
            this.Role.Location = new System.Drawing.Point(88, 201);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(200, 28);
            this.Role.TabIndex = 4;
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.Location = new System.Drawing.Point(88, 291);
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Size = new System.Drawing.Size(200, 26);
            this.TaiKhoan.TabIndex = 5;
            // 
            // MatKhau
            // 
            this.MatKhau.Location = new System.Drawing.Point(88, 370);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Size = new System.Drawing.Size(200, 26);
            this.MatKhau.TabIndex = 6;
            this.MatKhau.UseSystemPasswordChar = true;
            // 
            // DangNhap
            // 
            this.DangNhap.ActiveBorderThickness = 1;
            this.DangNhap.ActiveCornerRadius = 20;
            this.DangNhap.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.DangNhap.ActiveForecolor = System.Drawing.Color.White;
            this.DangNhap.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.DangNhap.BackColor = System.Drawing.Color.White;
            this.DangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DangNhap.BackgroundImage")));
            this.DangNhap.ButtonText = "Đăng nhập";
            this.DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DangNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhap.ForeColor = System.Drawing.Color.SeaGreen;
            this.DangNhap.IdleBorderThickness = 1;
            this.DangNhap.IdleCornerRadius = 20;
            this.DangNhap.IdleFillColor = System.Drawing.Color.Blue;
            this.DangNhap.IdleForecolor = System.Drawing.Color.White;
            this.DangNhap.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DangNhap.Location = new System.Drawing.Point(119, 418);
            this.DangNhap.Margin = new System.Windows.Forms.Padding(5);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(144, 40);
            this.DangNhap.TabIndex = 7;
            this.DangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DangNhap.Click += new System.EventHandler(this.DangNhap_Click);
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.Location = new System.Drawing.Point(149, 473);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(84, 22);
            this.Reset.TabIndex = 8;
            this.Reset.Text = "Làm mới";
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 514);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.DangNhap);
            this.Controls.Add(this.MatKhau);
            this.Controls.Add(this.TaiKhoan);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 DangNhap;
        private System.Windows.Forms.TextBox MatKhau;
        private System.Windows.Forms.TextBox TaiKhoan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Reset;
    }
}

