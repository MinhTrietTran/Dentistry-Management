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

        }

        private void MaNS_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTenNS();
        }
    }
}
