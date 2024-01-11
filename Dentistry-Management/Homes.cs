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
    public partial class Homes : Form
    {
        public Homes()
        {
            InitializeComponent();
            DemBenhNhan();
            DemNhaSi();
            DemCuocHen();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=THANHTRUNG\PC1;Initial Catalog=QUANLYNHAKHOA;Persist Security Info=True;User ID=sa;Password=heongusi22;");
        private void DemBenhNhan()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM BenhNhan", conn);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            SoBenhNhan.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
        private void DemNhaSi()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM NhaSi", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SoNhaSi.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
        private void DemCuocHen()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM CuocHen", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SoCuocHen.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Login obj = new Login();    
            obj.Show();
            this.Hide();    
        }

        private void CuocHenBtn_Click(object sender, EventArgs e)
        {
            Appointments obj = new Appointments();
            obj.Show();
            this.Hide();
        }

        private void ThongKeBtn_Click(object sender, EventArgs e)
        {
            Statistics obj = new Statistics();
            obj.Show();
            this.Hide();
        }

        private void Homes_Load(object sender, EventArgs e)
        {

        }
    }
}
