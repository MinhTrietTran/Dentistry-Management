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
        SqlConnection conn = new SqlConnection(@"Data Source=THANHTRUNG\PC1;Initial Catalog=QUANLYNHAKHOA;Persist Security Info=True;User ID=sa;Password=heongusi22;");
        private void XoaBtn_Click(object sender, EventArgs e)
        {

        }
        
        private void HienThiDanhSach()
        {
            DataTable dataTable = new DataTable();
            conn.Open();
            string Query = "SELECT * FROM NhanVien";
            SqlDataAdapter adapter = new SqlDataAdapter(Query,conn);
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())  
            adapter.Fill(dataTable);
            NhanVienDGV.DataSource = dataTable;
            conn.Close();
        }
        
        private void ThemBtn_Click(object sender, EventArgs e)
        {
            if(TenNV.Text == "" || PhaiNV.Text == "" || NgaySinhNV.Text == "" || DienThoaiNV.Text == "" || EmailNV.Text == "" || DiaChiNV.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien(TenNV,PhaiNV,NgaySinhNV,DienThoaiNV,EmailNV,DiaChiNV) " +
                                                    "VALUES (@TenNV,@PhaiNV,@NgaySinhNV,@DienThoaiNV,@EmailNV,@DiaChiNV) ", conn);
               
                    cmd.Parameters.AddWithValue("@TenNV", TenNV.Text);
                    cmd.Parameters.AddWithValue("@PhaiNV", PhaiNV.Text);
                    cmd.Parameters.AddWithValue("@NgaySinhNV", NgaySinhNV.Text);
                    cmd.Parameters.AddWithValue("@DienThoaiNV", DienThoaiNV.Text);
                    cmd.Parameters.AddWithValue("@EmailNV", EmailNV.Text);
                    cmd.Parameters.AddWithValue("@DiaChiNV", DiaChiNV.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công!@");
                    conn.Close();
                    HienThiDanhSach();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi thêm nhân viên: " + ex.Message);
                }
            }
                    
        }
        Modify modify = new Modify();
        private void Staffs_Load(object sender, EventArgs e)
        {
            try
            {
                NhanVienDGV.DataSource = modify.Table("SELECT * FROM NhanVien");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
          

        }
    }
}
