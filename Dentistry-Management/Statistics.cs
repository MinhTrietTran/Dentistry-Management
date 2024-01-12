using Guna.UI2.HtmlRenderer.Adapters;
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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            GetMaNS();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=THANHTRUNG\PC1;Initial Catalog=QUANLYNHAKHOA;Persist Security Info=True;User ID=sa;Password=heongusi22;");
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Homes obj = new Homes();
            obj.Show();
            this.Close();
        }

        private void BenhNhanBtn_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();
            obj.Show();
            this.Close();    
        }

        private void NhanVienBtn_Click(object sender, EventArgs e)
        {
            Staffs obj = new Staffs();
            obj.Show();
            this.Close();
        }

        private void NhaSiBtn_Click(object sender, EventArgs e)
        {
            Dentist obj = new Dentist();
            obj.Show();
            this.Close();
        }

        private void CuocHenBtn_Click(object sender, EventArgs e)
        {
            Appointments obj = new Appointments();
            obj.Show();
            this.Close();
        }

        private void ThuocBtn_Click(object sender, EventArgs e)
        {
            Medicine obj = new Medicine();
            obj.Show(); 
            this.Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void GetMaNS()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT MaNS FROM NhaSi", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaNS", typeof(int));
            dt.Load(rdr);
            MaNS.ValueMember = "MaNS";
            MaNS.DataSource = dt;
            conn.Close();
        }
        private void GetTenNS()
        {
            conn.Open();
            string Query = "SELECT * FROM NhaSi WHERE MaNS = " +MaNS.SelectedValue.ToString()+  "";
            SqlCommand cmd = new SqlCommand(Query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                TenNS.Text = dr["TenNS"].ToString();
            }
            conn.Close();
        }
        private void Clear()
        {
            MaNS.SelectedIndex = 0;
            TenNS.Text = "";
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYNHAKHOADataSet11.CuocHen' table. You can move, or remove it, as needed.
            this.cuocHenTableAdapter.Fill(this.qUANLYNHAKHOADataSet11.CuocHen);

        }

        private void MaNS_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTenNS();
        }

        Modify modify = new Modify();
        int tong = 0;
        private void CuocHen_Click(object sender, EventArgs e)
        {
            TuaDe.Text = "Thống kê cuộc hẹn";
            // Create a DataTable to hold the result set
            DataTable dataTable = new DataTable();

            conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM CuocHen WHERE CONVERT(DATE,GioCH) BETWEEN @NgayBatDau AND @NgayKetThuc AND (NhaSi = @MaNS OR TroLy = @MaNS)", conn);
                cmd.Parameters.AddWithValue("@NgayBatDau", Start.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@NgayKetThuc", End.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@MaNS", MaNS.Text);
                //cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(dataTable);

                SqlCommand cmd1 = new SqlCommand(" SELECT COUNT(*) FROM CuocHen WHERE CONVERT(DATE,GioCH) BETWEEN @NgayBatDau AND @NgayKetThuc AND (NhaSi = @MaNS OR TroLy = @MaNS)", conn);
                
                cmd1.Parameters.AddWithValue("@NgayBatDau", Start.Value.ToString("yyyy-MM-dd"));
                cmd1.Parameters.AddWithValue("@NgayKetThuc", End.Value.ToString("yyyy-MM-dd"));
                cmd1.Parameters.AddWithValue("@MaNS", MaNS.Text);
                tong = (int)cmd1.ExecuteScalar();

            }
            ThongKeDGV.DataSource = dataTable;
            conn.Close();
            Tong.Text = tong.ToString();
        }
    }
}
