namespace Dentistry_Management
{
    partial class DonThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonThuoc));
            this.GioKetThuc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lichLamViecTableAdapter = new Dentistry_Management.QUANLYNHAKHOADataSet10TableAdapters.LichLamViecTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.XoaBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CapNhatBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ThemBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.qUANLYNHAKHOADataSet10 = new Dentistry_Management.QUANLYNHAKHOADataSet10();
            this.lichLamViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TenNS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaNS = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYNHAKHOADataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichLamViecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GioKetThuc
            // 
            this.GioKetThuc.Location = new System.Drawing.Point(282, 72);
            this.GioKetThuc.Multiline = true;
            this.GioKetThuc.Name = "GioKetThuc";
            this.GioKetThuc.Size = new System.Drawing.Size(151, 68);
            this.GioKetThuc.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(151, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 72;
            this.label5.Text = "Ngày kê đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(26, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "Mã đơn thuốc";
            // 
            // lichLamViecTableAdapter
            // 
            this.lichLamViecTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(279, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 74;
            this.label6.Text = "Đơn thuốc";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // XoaBtn
            // 
            this.XoaBtn.ActiveBorderThickness = 1;
            this.XoaBtn.ActiveCornerRadius = 20;
            this.XoaBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.XoaBtn.ActiveForecolor = System.Drawing.Color.White;
            this.XoaBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.XoaBtn.BackColor = System.Drawing.Color.White;
            this.XoaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("XoaBtn.BackgroundImage")));
            this.XoaBtn.ButtonText = "Xóa";
            this.XoaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XoaBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.XoaBtn.IdleBorderThickness = 1;
            this.XoaBtn.IdleCornerRadius = 20;
            this.XoaBtn.IdleFillColor = System.Drawing.Color.DarkRed;
            this.XoaBtn.IdleForecolor = System.Drawing.Color.White;
            this.XoaBtn.IdleLineColor = System.Drawing.Color.DarkRed;
            this.XoaBtn.Location = new System.Drawing.Point(196, 100);
            this.XoaBtn.Margin = new System.Windows.Forms.Padding(5);
            this.XoaBtn.Name = "XoaBtn";
            this.XoaBtn.Size = new System.Drawing.Size(69, 40);
            this.XoaBtn.TabIndex = 69;
            this.XoaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CapNhatBtn
            // 
            this.CapNhatBtn.ActiveBorderThickness = 1;
            this.CapNhatBtn.ActiveCornerRadius = 20;
            this.CapNhatBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.CapNhatBtn.ActiveForecolor = System.Drawing.Color.White;
            this.CapNhatBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.CapNhatBtn.BackColor = System.Drawing.Color.White;
            this.CapNhatBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CapNhatBtn.BackgroundImage")));
            this.CapNhatBtn.ButtonText = "Cập nhật";
            this.CapNhatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CapNhatBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapNhatBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.CapNhatBtn.IdleBorderThickness = 1;
            this.CapNhatBtn.IdleCornerRadius = 20;
            this.CapNhatBtn.IdleFillColor = System.Drawing.Color.SandyBrown;
            this.CapNhatBtn.IdleForecolor = System.Drawing.Color.Black;
            this.CapNhatBtn.IdleLineColor = System.Drawing.Color.SandyBrown;
            this.CapNhatBtn.Location = new System.Drawing.Point(95, 100);
            this.CapNhatBtn.Margin = new System.Windows.Forms.Padding(5);
            this.CapNhatBtn.Name = "CapNhatBtn";
            this.CapNhatBtn.Size = new System.Drawing.Size(91, 40);
            this.CapNhatBtn.TabIndex = 68;
            this.CapNhatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThemBtn
            // 
            this.ThemBtn.ActiveBorderThickness = 1;
            this.ThemBtn.ActiveCornerRadius = 20;
            this.ThemBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ThemBtn.ActiveForecolor = System.Drawing.Color.White;
            this.ThemBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ThemBtn.BackColor = System.Drawing.Color.White;
            this.ThemBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ThemBtn.BackgroundImage")));
            this.ThemBtn.ButtonText = "Thêm";
            this.ThemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThemBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.ThemBtn.IdleBorderThickness = 1;
            this.ThemBtn.IdleCornerRadius = 20;
            this.ThemBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ThemBtn.IdleForecolor = System.Drawing.Color.White;
            this.ThemBtn.IdleLineColor = System.Drawing.Color.Green;
            this.ThemBtn.Location = new System.Drawing.Point(14, 100);
            this.ThemBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ThemBtn.Name = "ThemBtn";
            this.ThemBtn.Size = new System.Drawing.Size(71, 40);
            this.ThemBtn.TabIndex = 67;
            this.ThemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qUANLYNHAKHOADataSet10
            // 
            this.qUANLYNHAKHOADataSet10.DataSetName = "QUANLYNHAKHOADataSet10";
            this.qUANLYNHAKHOADataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lichLamViecBindingSource
            // 
            this.lichLamViecBindingSource.DataMember = "LichLamViec";
            this.lichLamViecBindingSource.DataSource = this.qUANLYNHAKHOADataSet10;
            // 
            // TenNS
            // 
            this.TenNS.Location = new System.Drawing.Point(278, 27);
            this.TenNS.Name = "TenNS";
            this.TenNS.ReadOnly = true;
            this.TenNS.Size = new System.Drawing.Size(155, 20);
            this.TenNS.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(275, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "Tên bệnh nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(52, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 63;
            this.label2.Text = "Đơn thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(151, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "Mã bệnh nhân";
            // 
            // MaNS
            // 
            this.MaNS.Location = new System.Drawing.Point(154, 27);
            this.MaNS.Name = "MaNS";
            this.MaNS.ReadOnly = true;
            this.MaNS.Size = new System.Drawing.Size(73, 20);
            this.MaNS.TabIndex = 62;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 76;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker1.TabIndex = 77;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 178);
            this.dataGridView1.TabIndex = 78;
            // 
            // DonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 329);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GioKetThuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.XoaBtn);
            this.Controls.Add(this.CapNhatBtn);
            this.Controls.Add(this.ThemBtn);
            this.Controls.Add(this.TenNS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaNS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonThuoc";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYNHAKHOADataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichLamViecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox GioKetThuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private QUANLYNHAKHOADataSet10TableAdapters.LichLamViecTableAdapter lichLamViecTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 XoaBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 CapNhatBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 ThemBtn;
        private QUANLYNHAKHOADataSet10 qUANLYNHAKHOADataSet10;
        private System.Windows.Forms.BindingSource lichLamViecBindingSource;
        private System.Windows.Forms.TextBox TenNS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaNS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}