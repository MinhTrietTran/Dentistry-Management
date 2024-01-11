namespace Dentistry_Management
{
    partial class WorkTimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkTimes));
            this.MaNS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TenNS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LichLamViecDGV = new System.Windows.Forms.DataGridView();
            this.XoaBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CapNhatBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ThemBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qUANLYNHAKHOADataSet10 = new Dentistry_Management.QUANLYNHAKHOADataSet10();
            this.lichLamViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lichLamViecTableAdapter = new Dentistry_Management.QUANLYNHAKHOADataSet10TableAdapters.LichLamViecTableAdapter();
            this.maNhaSiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuTrongTuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioBatDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioKetThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.GioBatDau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GioKetThuc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ThuTrongTuan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.LichLamViecDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYNHAKHOADataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichLamViecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MaNS
            // 
            this.MaNS.Location = new System.Drawing.Point(208, 23);
            this.MaNS.Name = "MaNS";
            this.MaNS.ReadOnly = true;
            this.MaNS.Size = new System.Drawing.Size(73, 20);
            this.MaNS.TabIndex = 29;
            this.MaNS.TextChanged += new System.EventHandler(this.MaNS_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(205, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã nha sĩ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(54, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "LỊCH LÀM VIỆC";
            // 
            // TenNS
            // 
            this.TenNS.Location = new System.Drawing.Point(308, 23);
            this.TenNS.Name = "TenNS";
            this.TenNS.ReadOnly = true;
            this.TenNS.Size = new System.Drawing.Size(155, 20);
            this.TenNS.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(305, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tên nha sĩ";
            // 
            // LichLamViecDGV
            // 
            this.LichLamViecDGV.AutoGenerateColumns = false;
            this.LichLamViecDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LichLamViecDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LichLamViecDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhaSiDataGridViewTextBoxColumn,
            this.thuTrongTuanDataGridViewTextBoxColumn,
            this.gioBatDauDataGridViewTextBoxColumn,
            this.gioKetThucDataGridViewTextBoxColumn});
            this.LichLamViecDGV.DataSource = this.lichLamViecBindingSource;
            this.LichLamViecDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LichLamViecDGV.Location = new System.Drawing.Point(0, 143);
            this.LichLamViecDGV.Name = "LichLamViecDGV";
            this.LichLamViecDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LichLamViecDGV.Size = new System.Drawing.Size(475, 225);
            this.LichLamViecDGV.TabIndex = 33;
            this.LichLamViecDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LichLamViecDGV_CellClick);
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
            this.XoaBtn.Location = new System.Drawing.Point(367, 102);
            this.XoaBtn.Margin = new System.Windows.Forms.Padding(5);
            this.XoaBtn.Name = "XoaBtn";
            this.XoaBtn.Size = new System.Drawing.Size(91, 40);
            this.XoaBtn.TabIndex = 52;
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
            this.CapNhatBtn.Location = new System.Drawing.Point(178, 102);
            this.CapNhatBtn.Margin = new System.Windows.Forms.Padding(5);
            this.CapNhatBtn.Name = "CapNhatBtn";
            this.CapNhatBtn.Size = new System.Drawing.Size(91, 40);
            this.CapNhatBtn.TabIndex = 51;
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
            this.ThemBtn.Location = new System.Drawing.Point(15, 102);
            this.ThemBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ThemBtn.Name = "ThemBtn";
            this.ThemBtn.Size = new System.Drawing.Size(91, 40);
            this.ThemBtn.TabIndex = 50;
            this.ThemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ThemBtn.Click += new System.EventHandler(this.ThemBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // lichLamViecTableAdapter
            // 
            this.lichLamViecTableAdapter.ClearBeforeFill = true;
            // 
            // maNhaSiDataGridViewTextBoxColumn
            // 
            this.maNhaSiDataGridViewTextBoxColumn.DataPropertyName = "MaNhaSi";
            this.maNhaSiDataGridViewTextBoxColumn.HeaderText = "Mã nha sĩ";
            this.maNhaSiDataGridViewTextBoxColumn.Name = "maNhaSiDataGridViewTextBoxColumn";
            // 
            // thuTrongTuanDataGridViewTextBoxColumn
            // 
            this.thuTrongTuanDataGridViewTextBoxColumn.DataPropertyName = "ThuTrongTuan";
            this.thuTrongTuanDataGridViewTextBoxColumn.HeaderText = "Thứ";
            this.thuTrongTuanDataGridViewTextBoxColumn.Name = "thuTrongTuanDataGridViewTextBoxColumn";
            // 
            // gioBatDauDataGridViewTextBoxColumn
            // 
            this.gioBatDauDataGridViewTextBoxColumn.DataPropertyName = "GioBatDau";
            this.gioBatDauDataGridViewTextBoxColumn.HeaderText = "Bắt đầu";
            this.gioBatDauDataGridViewTextBoxColumn.Name = "gioBatDauDataGridViewTextBoxColumn";
            // 
            // gioKetThucDataGridViewTextBoxColumn
            // 
            this.gioKetThucDataGridViewTextBoxColumn.DataPropertyName = "GioKetThuc";
            this.gioKetThucDataGridViewTextBoxColumn.HeaderText = "Kết thúc";
            this.gioKetThucDataGridViewTextBoxColumn.Name = "gioKetThucDataGridViewTextBoxColumn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(46, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Thứ";
            // 
            // GioBatDau
            // 
            this.GioBatDau.Location = new System.Drawing.Point(178, 74);
            this.GioBatDau.Name = "GioBatDau";
            this.GioBatDau.Size = new System.Drawing.Size(73, 20);
            this.GioBatDau.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(178, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Giờ bắt đầu";
            // 
            // GioKetThuc
            // 
            this.GioKetThuc.Location = new System.Drawing.Point(320, 74);
            this.GioKetThuc.Name = "GioKetThuc";
            this.GioKetThuc.Size = new System.Drawing.Size(73, 20);
            this.GioKetThuc.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(320, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Giờ kết thúc";
            // 
            // ThuTrongTuan
            // 
            this.ThuTrongTuan.FormattingEnabled = true;
            this.ThuTrongTuan.Items.AddRange(new object[] {
            "Thứ hai",
            "Thứ ba",
            "Thứ tư",
            "Thứ năm",
            "Thứ sáu",
            "Thứ bảy",
            "Chủ nhật"});
            this.ThuTrongTuan.Location = new System.Drawing.Point(40, 73);
            this.ThuTrongTuan.Name = "ThuTrongTuan";
            this.ThuTrongTuan.Size = new System.Drawing.Size(82, 21);
            this.ThuTrongTuan.TabIndex = 60;
            // 
            // WorkTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(475, 368);
            this.Controls.Add(this.ThuTrongTuan);
            this.Controls.Add(this.GioKetThuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GioBatDau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.XoaBtn);
            this.Controls.Add(this.CapNhatBtn);
            this.Controls.Add(this.ThemBtn);
            this.Controls.Add(this.LichLamViecDGV);
            this.Controls.Add(this.TenNS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaNS);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkTimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkTimes";
            this.Load += new System.EventHandler(this.WorkTimes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LichLamViecDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYNHAKHOADataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichLamViecBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MaNS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TenNS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView LichLamViecDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 XoaBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 CapNhatBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 ThemBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private QUANLYNHAKHOADataSet10 qUANLYNHAKHOADataSet10;
        private System.Windows.Forms.BindingSource lichLamViecBindingSource;
        private QUANLYNHAKHOADataSet10TableAdapters.LichLamViecTableAdapter lichLamViecTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhaSiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuTrongTuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioBatDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioKetThucDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GioBatDau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GioKetThuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ThuTrongTuan;
    }
}