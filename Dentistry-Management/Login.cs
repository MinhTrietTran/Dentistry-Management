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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        SqlConnection conn = new SqlConnection(@"Data Source=THANHTRUNG\PC1;Initial Catalog=QUANLYNHAKHOA;Persist Security Info=True;User ID=sa;Password=heongusi22;");
        private void Reset_Click(object sender, EventArgs e)
        {
            Role.SelectedIndex = 0;
            TaiKhoan.Text = "";
            MatKhau.Text = "";
        }
        public static string QuyenTruyCap;

        private void DangNhap_Click(object sender, EventArgs e)
        {
            if(Role.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn quyền truy cập của bạn");     
            }
            else if(Role.SelectedIndex == 0)
            {
                if(TaiKhoan.Text == "" || MatKhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu !");
                }
                else if (TaiKhoan.Text == "admin" && MatKhau.Text == "pwd")
                {
                    QuyenTruyCap = "Admin";
                    Patients obj = new Patients();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai");
                } 
                
            }
            else if(Role.SelectedIndex == 1)
            {

                if (TaiKhoan.Text == "" || MatKhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu !");
                }
                else
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM NhanVien WHERE EmailNV = '" + TaiKhoan.Text + "'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1" && MatKhau.Text == "1")
                    {
                        QuyenTruyCap = "NhanVien";
                        Homes obj = new Homes();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu sai");
                    }
                    conn.Close();
                }
            }
            else
            {
                if (TaiKhoan.Text == "" || MatKhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu !");
                }
                else
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM NhaSi WHERE EmailNS = '" + TaiKhoan.Text + "'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1" && MatKhau.Text == "1")
                    {
                        QuyenTruyCap = "NhaSi";
                        Staffs obj = new Staffs();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu sai");
                    }
                    conn.Close();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
