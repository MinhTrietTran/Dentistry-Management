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

namespace Dentistry_Management
{
    public partial class Staffs : Form
    {
        public Staffs()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        NhanVien quanLy;

        private void Clear()
        {
            MaNV.Text = "";
            TenNV.Text = "";
            PhaiNV.Text = "";
            NgaySinhNV.Text = "";
            DienThoaiNV.Text = "";
            EmailNV.Text = "";
            DiaChiNV.Text = "";

        }

        private void Staffs_Load(object sender, EventArgs e)
        {
            try
            {
                NhanVienDGV.DataSource = modify.Table("SELECT * FROM NhanVien NV ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void GetValuesTextBoxes()
        {
            int _maNV = int.Parse(MaNV.Text);
            string _tenNV = TenNV.Text;
            string _phaiNV = PhaiNV.Text;
            string _ngaySinhNV = NgaySinhNV.Text;
            string _dienThoaiNV = DienThoaiNV.Text;
            string _emailNV = EmailNV.Text; 
            string _diaChiNV = DiaChiNV.Text;
            
            quanLy = new NhanVien(_maNV,_tenNV,_phaiNV,_ngaySinhNV,_dienThoaiNV,_emailNV,_diaChiNV,"");
        }

        SqlConnection conn = new SqlConnection(@"Data Source=THANHTRUNG\PC1;Initial Catalog=QUANLYNHAKHOA;Persist Security Info=True;User ID=sa;Password=heongusi22;");
        
        private void HienThiDanhSach()
        {
            DataTable dataTable = new DataTable();
            conn.Open();
            string Query = "SELECT * FROM NhanVien NV ";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            adapter.Fill(dataTable);
            NhanVienDGV.DataSource = dataTable;
            conn.Close();
            Clear();
        }
        // Them nv
        private void ThemBtn_Click(object sender, EventArgs e)
        {
            if (TenNV.Text == "" || PhaiNV.SelectedIndex ==-1|| DienThoaiNV.Text == "" || EmailNV.Text == "" || DiaChiNV.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien(TenNV,PhaiNV,NgaySinhNV,DienThoaiNV,EmailNV,DiaChiNV) " +
                                                        "VALUES (@TenNV,@PhaiNV,@NgaySinhNV,@DienThoaiNV,@EmailNV,@DiaChiNV) ", conn);

                        cmd.Parameters.AddWithValue("@TenNV", TenNV.Text);
                        cmd.Parameters.AddWithValue("@PhaiNV", PhaiNV.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@NgaySinhNV", NgaySinhNV.Value.Date.ToString());   
                        cmd.Parameters.AddWithValue("@DienThoaiNV", DienThoaiNV.Text);
                        cmd.Parameters.AddWithValue("@EmailNV", EmailNV.Text);
                        cmd.Parameters.AddWithValue("@DiaChiNV", DiaChiNV.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm nhân viên thành công!@");
                        conn.Close();
                        HienThiDanhSach();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm nhân viên: " + ex.Message);
                }
            }

        }
        // Cap nhat nv
        private void CapNhatBtn_Click(object sender, EventArgs e)
        {
            if (MaNV.Text == "" )
            { MessageBox.Show("Vui lòng điền mã nhân viên muốn cập nhật"); }
            else
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn sửa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET TenNV = @TenNV,PhaiNV = @PhaiNV,NgaySinhNV = @NgaySinhNV,DienThoaiNV = @DienThoaiNV,EmailNV = @EmailNV,DiaChiNV = @DiaChiNV " +
                                                        " WHERE MaNV ='" + MaNV.Text + "' ", conn);

                        cmd.Parameters.AddWithValue("@TenNV", TenNV.Text);
                        cmd.Parameters.AddWithValue("@PhaiNV", PhaiNV.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@NgaySinhNV", NgaySinhNV.Value.Date.ToString());
                        cmd.Parameters.AddWithValue("@DienThoaiNV", DienThoaiNV.Text);
                        cmd.Parameters.AddWithValue("@EmailNV", EmailNV.Text);
                        cmd.Parameters.AddWithValue("@DiaChiNV", DiaChiNV.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật nhân viên thành công!@");
                        conn.Close();
                        HienThiDanhSach();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa: " + ex.Message);
                }
            }
        }

        // Xem thong tin theo hang
        private void NhanVienDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                MaNV.Text = NhanVienDGV.SelectedRows[0].Cells[0].Value.ToString();
                TenNV.Text = NhanVienDGV.SelectedRows[0].Cells[1].Value.ToString();
                PhaiNV.SelectedItem = NhanVienDGV.SelectedRows[0].Cells[2].Value.ToString();
            NgaySinhNV.Value = (DateTime)NhanVienDGV.SelectedRows[0].Cells[3].Value;
            DienThoaiNV.Text = NhanVienDGV.SelectedRows[0].Cells[4].Value.ToString();
                EmailNV.Text = NhanVienDGV.SelectedRows[0].Cells[5].Value.ToString();
                DiaChiNV.Text = NhanVienDGV.SelectedRows[0].Cells[6].Value.ToString();
           
        }
        // Xoa nv
        private void XoaBtn_Click(object sender, EventArgs e)
        {
            if (NhanVienDGV.Rows.Count > 1)
            {
                string choose = NhanVienDGV.SelectedRows[0].Cells[0].Value.ToString();

                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE NhanVien WHERE MaNV = '" + choose + "'", conn);
                        cmd.ExecuteNonQuery();
                        //modify.Command(query);
                        MessageBox.Show("Xóa nhân viên thành công!");
                        conn.Close();   
                        HienThiDanhSach();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên: " + ex.Message);
                }
            }
        }

        private void MaNV_TextChanged(object sender, EventArgs e)
        {
            string maNV = MaNV.Text.Trim();
            if (maNV == "")
            {
                Staffs_Load(sender, e);

            }
            else
            {
                string query = "SELECT * FROM NhanVien WHERE MaNV LIKE '%" + maNV + "%'";
                NhanVienDGV.DataSource = modify.Table(query);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
