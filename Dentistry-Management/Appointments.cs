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

namespace Dentistry_Management
{
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();

            if(Login.QuyenTruyCap == "NhaSi")
            {
                ThemBtn.Enabled = false;
                CapNhatBtn.Enabled = false;
                XoaBtn.Enabled = false;
            }
            GioCH2.Format = DateTimePickerFormat.Time;
            GioCH2.ShowUpDown = true;

        }

        Modify modify = new Modify();
        SqlConnection conn = new SqlConnection(@"Data Source=THANHTRUNG\PC1;Initial Catalog=QUANLYNHAKHOA;Persist Security Info=True;User ID=sa;Password=heongusi22;");

        private void Appointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYNHAKHOADataSet8.CuocHen' table. You can move, or remove it, as needed.
            this.cuocHenTableAdapter3.Fill(this.qUANLYNHAKHOADataSet8.CuocHen);
            try
            {
                CuocHenDGV.DataSource = modify.Table("SELECT * FROM CuocHen ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Clear()
        {
            GioCH1.FormatCustom = "";
            GioCH1.Format = DateTimePickerFormat.Custom;

            GioCH2.Text = string.Empty;


            ThuTuCH.Text = "";
            IsLanDau.SelectedIndex = -1;
            GhiChu.Text = "";

            NgayGui.FormatCustom = "";
            NgayGui.Format = DateTimePickerFormat.Custom;

            BenhNhan.Text = "";
            NhaSi.Text = "";
            TroLy.Text = "";
            Phong.SelectedIndex = -1;
        }




        // Điều khiển luồng
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Homes obj = new Homes();
            obj.Show();
            this.Hide();
        }

        private void BenhNhanBtn_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();  
            obj.Show();
            this.Hide();
        }

        private void NhaSiBtn_Click(object sender, EventArgs e)
        {
            Dentist obj = new Dentist();
            obj.Show();
            this.Hide();
        }

        private void NhanVienBtn_Click(object sender, EventArgs e)
        {
            Staffs obj = new Staffs();
            obj.Show();
            this.Hide();    
        }

        private void ThuocBtn_Click(object sender, EventArgs e)
        {
            Medicine obj = new Medicine();
            obj.Show();
            this.Hide();
        }

        private void ThongKeBtn_Click(object sender, EventArgs e)
        {

        }
        private void DangXuatBtn_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();
            obj.Show();
            this.Hide();
        }

        // Thoát
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Thêm
        private void ThemBtn_Click(object sender, EventArgs e)
        {
            if (GioCH1.Value.ToString() == "" || GioCH2.ToString() == "" || ThuTuCH.Text == "" || IsLanDau.SelectedIndex == -1 || NgayGui.Value.ToString() == "" || BenhNhan.Text == "" || NhaSi.Text == "" || Phong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm cuộc hẹn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO CuocHen(GioCH,ThuTuCH,IsLanDau,GhiChu,NgayGui,BenhNhan,NhaSi, TroLy,Phong) " +
                                                        "VALUES (@GioCH,@ThuTuCH,@IsLanDau,@GhiChu,@NgayGui,@BenhNhan,@NhaSi, @TroLy,@Phong) ", conn);

                        DateTime GioCH = GioCH1.Value.Date.Add(GioCH2.Value.TimeOfDay);
                        cmd.Parameters.AddWithValue("@GioCH", GioCH.ToString());
                        cmd.Parameters.AddWithValue("@ThuTuCH", ThuTuCH.Text);
                        int isLanDau = 1;
                        if(IsLanDau.Text == "Tái khám") 
                        {
                            isLanDau = 0;
                        };
                        cmd.Parameters.AddWithValue("@IsLanDau", isLanDau.ToString());
                        cmd.Parameters.AddWithValue("@GhiChu", GhiChu.Text);
                        cmd.Parameters.AddWithValue("@NgayGui", NgayGui.Value.Date.ToString());
                        cmd.Parameters.AddWithValue("@BenhNhan", BenhNhan.Text);
                        cmd.Parameters.AddWithValue("@NhaSi", NhaSi.Text);
                        cmd.Parameters.AddWithValue("@TroLy", TroLy.Text);
                        cmd.Parameters.AddWithValue("@Phong", Phong.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm cuộc hẹn thành công!@");
                        conn.Close();
                        Appointments_Load(sender, e);
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm Cuộc hẹn: " + ex.Message);
                }
            }
        }

        private void CuocHenDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaCH.Text = CuocHenDGV.SelectedRows[0].Cells[0].Value.ToString();
            GioCH1.Value = (DateTime)CuocHenDGV.SelectedRows[0].Cells[1].Value;
            GioCH2.Value = (DateTime)CuocHenDGV.SelectedRows[0].Cells[1].Value;
            ThuTuCH.Text = CuocHenDGV.SelectedRows[0].Cells[2].Value.ToString();
            IsLanDau.SelectedIndex = int.Parse(CuocHenDGV.SelectedRows[0].Cells[3].Value.ToString());
            GhiChu.Text = CuocHenDGV.SelectedRows[0].Cells[4].Value.ToString();
            NgayGui.Value = (DateTime)CuocHenDGV.SelectedRows[0].Cells[5].Value;
            conn.Open();
            string sqlQuery = "SELECT TenBN FROM BenhNhan WHERE MaBN = @MaBN";
            using (SqlCommand command = new SqlCommand(sqlQuery, conn))
            {
                // Thêm tham số vào truy vấn để tránh SQL Injection
                command.Parameters.AddWithValue("@MaBN", CuocHenDGV.SelectedRows[0].Cells[6].Value.ToString());

                // Thực hiện truy vấn
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Đọc tên bệnh nhân từ kết quả truy vấn
                    string employeeName = reader["TenBN"].ToString();

                    // Lưu vào biến nếu cần
                    BenhNhan.Text = employeeName;
                }
            }
            string sqlQuery1 = "SELECT TenNS FROM NhaSi WHERE MaNS = @MaNS";
            using (SqlCommand command = new SqlCommand(sqlQuery1, conn))
            {
                // Thêm tham số vào truy vấn để tránh SQL Injection
                command.Parameters.AddWithValue("@MaNS", CuocHenDGV.SelectedRows[0].Cells[7].Value.ToString());

                // Thực hiện truy vấn
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Đọc tên nha sĩ từ kết quả truy vấn
                    string employeeName = reader["TenNS"].ToString();

                    // Lưu vào biến nếu cần
                    NhaSi.Text = employeeName;
                }
            }
            using (SqlCommand command = new SqlCommand(sqlQuery1, conn))
            {
                // Thêm tham số vào truy vấn để tránh SQL Injection
                command.Parameters.AddWithValue("@MaNS", CuocHenDGV.SelectedRows[0].Cells[8].Value.ToString());

                // Thực hiện truy vấn
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Đọc tên nha sĩ từ kết quả truy vấn
                    string employeeName = reader["TenNS"].ToString();

                    // Lưu vào biến nếu cần
                    NhaSi.Text = employeeName;
                }
            }
            conn.Close();
            Phong.Text = CuocHenDGV.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void CapNhatBtn_Click(object sender, EventArgs e)
        {
            if (MaCH.Text == "")
            {
                MessageBox.Show("Chưa chọn cuộc hẹn muốn chỉnh sửa");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn sửa cuộc hẹn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE CuocHen SET GioCH = @GioCH,ThuTuCH = @ThuTuCH,IsLanDau = @IsLanDau,GhiChu = @GhiChu,NgayGui = @NgayGui,BenhNhan = @BenhNhan,NhaSi = @NhaSi, TroLy = @TroLy,Phong = @Phong) " +
                                                        " WHERE MaCH ='" + MaCH.Text + "' ", conn);

                        DateTime GioCH = GioCH1.Value.Date.Add(GioCH2.Value.TimeOfDay);
                        cmd.Parameters.AddWithValue("@GioCH", GioCH.ToString());
                        cmd.Parameters.AddWithValue("@ThuTuCH", ThuTuCH.Text);
                        int isLanDau = 1;
                        if (IsLanDau.Text == "Tái khám")
                        {
                            isLanDau = 0;
                        };
                        cmd.Parameters.AddWithValue("@IsLanDau", isLanDau.ToString());
                        cmd.Parameters.AddWithValue("@GhiChu", GhiChu.Text);
                        cmd.Parameters.AddWithValue("@NgayGui", NgayGui.Value.Date.ToString());
                        cmd.Parameters.AddWithValue("@BenhNhan", BenhNhan.Text);
                        cmd.Parameters.AddWithValue("@NhaSi", NhaSi.Text);
                        cmd.Parameters.AddWithValue("@TroLy", TroLy.Text);
                        cmd.Parameters.AddWithValue("@Phong", Phong.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật cuộc hẹn thành công!@");
                        conn.Close();
                        Appointments_Load(sender, e);
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật Cuộc hẹn: " + ex.Message);
                }
            }
        }

        private void XoaBtn_Click(object sender, EventArgs e)
        {
            if (CuocHenDGV.Rows.Count > 1)
            {
                string choose = CuocHenDGV.SelectedRows[0].Cells[0].Value.ToString();
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa cuộc hẹn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE CuocHen WHERE MaCH= '" + choose + "'", conn);
                        cmd.ExecuteNonQuery();
                        //modify.Command(query);
                        MessageBox.Show("Xóa Cuộc hẹn thành công!");
                        conn.Close();
                        Appointments_Load(sender, e);
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa cuộc hẹn: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Danh sách cuộc h rỗng! ");
            }
        }
    }
}
