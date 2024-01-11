using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentistry_Management
{
    public partial class Dentist : Form
    {
        public Dentist()
        {
            InitializeComponent();
        }
        public static string MaNSDangChon;
        Modify modify = new Modify();
        Modify modify2 = new Modify();
        SqlConnection conn = new SqlConnection(@"Data Source=THANHTRUNG\PC1;Initial Catalog=QUANLYNHAKHOA;Persist Security Info=True;User ID=sa;Password=heongusi22;");

        private void NhaSiDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (NhaSiDGV.Rows.Count > 1)
            {
                MaNS.Text = NhaSiDGV.SelectedRows[0].Cells[0].Value.ToString();
                TenNS.Text = NhaSiDGV.SelectedRows[0].Cells[1].Value.ToString();
                PhaiNS.SelectedItem = NhaSiDGV.SelectedRows[0].Cells[2].Value.ToString();
                NgaySinhNS.Value = (DateTime)NhaSiDGV.SelectedRows[0].Cells[3].Value;
                DienThoaiNS.Text = NhaSiDGV.SelectedRows[0].Cells[4].Value.ToString();
                EmailNS.Text = NhaSiDGV.SelectedRows[0].Cells[5].Value.ToString();
                DiaChiNS.Text = NhaSiDGV.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void Dentist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYNHAKHOADataSet9.LichLamViec' table. You can move, or remove it, as needed.
            //this.lichLamViecTableAdapter.Fill(this.qUANLYNHAKHOADataSet9.LichLamViec);
            // TODO: This line of code loads data into the 'qUANLYNHAKHOADataSet2.NhaSi' table. You can move, or remove it, as needed.
            //this.nhaSiTableAdapter.Fill(this.qUANLYNHAKHOADataSet2.NhaSi);
            try
            {
                NhaSiDGV.DataSource = modify.Table("SELECT * FROM NhaSi NS ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }
        // Clear text box
        private void Clear()
        {
            MaNS.Text = "";
            TenNS.Text = "";
            PhaiNS.SelectedIndex = -1;
            DienThoaiNS.Text = "";
            EmailNS.Text = "";
            DiaChiNS.Text = "";
        }
        // Them NS
        private void ThemBtn_Click(object sender, EventArgs e)
        {
            if (TenNS.Text == "" || PhaiNS.Text == "" || DienThoaiNS.Text == "" || EmailNS.Text == "" || DiaChiNS.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm nha sĩ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO NhaSi(TenNS,PhaiNS,NgaySinhNS,DienThoaiNS,EmailNS,DiaChiNS) " +
                                                        "VALUES (@TenNS,@PhaiNS,@NgaySinhNS,@DienThoaiNS,@EmailNS,@DiaChiNS) ", conn);

                        cmd.Parameters.AddWithValue("@TenNS", TenNS.Text);
                        cmd.Parameters.AddWithValue("@PhaiNS", PhaiNS.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@NgaySinhNS", NgaySinhNS.Value.Date.ToString());
                        cmd.Parameters.AddWithValue("@DienThoaiNS", DienThoaiNS.Text);
                        cmd.Parameters.AddWithValue("@EmailNS", EmailNS.Text);
                        cmd.Parameters.AddWithValue("@DiaChiNS", DiaChiNS.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm nha sĩ thành công!@");
                        conn.Close();
                        Dentist_Load(sender,e);
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm nha sĩ: " + ex.Message);
                }
            }
        }

     

        private void CapNhatBtn_Click(object sender, EventArgs e)
        {
            if (MaNS.Text == "")
            { MessageBox.Show("Vui lòng điền mã nha sĩ muốn cập nhật"); }
            else
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn sửa nha sĩ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE NhaSi SET TenNS = @TenNS,PhaiNS = @PhaiNS,NgaySinhNS = @NgaySinhNS,DienThoaiNS = @DienThoaiNS,EmailNS = @EmailNS,DiaChiNS = @DiaChiNS " +
                                                        " WHERE MaNS ='" + MaNS.Text + "' ", conn);

                        cmd.Parameters.AddWithValue("@TenNS", TenNS.Text);
                        cmd.Parameters.AddWithValue("@PhaiNS", PhaiNS.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@NgaySinhNS", NgaySinhNS.Value.Date.ToString());
                        cmd.Parameters.AddWithValue("@DienThoaiNS", DienThoaiNS.Text);
                        cmd.Parameters.AddWithValue("@EmailNS", EmailNS.Text);
                        cmd.Parameters.AddWithValue("@DiaChiNS", DiaChiNS.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật nha sĩ thành công!@");
                        conn.Close();
                        Dentist_Load(sender, e);
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa: " + ex.Message);
                }
            }
        }

        private void XoaBtn_Click(object sender, EventArgs e)
        {
            if (NhaSiDGV.Rows.Count > 1)
            {
                string choose = NhaSiDGV.SelectedRows[0].Cells[0].Value.ToString();

                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa nha sĩ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE NhaSi WHERE MaNS = '" + choose + "'", conn);
                        cmd.ExecuteNonQuery();
                        //modify.Command(query);
                        MessageBox.Show("Xóa nha sĩ thành công!");
                        conn.Close();
                        Dentist_Load(sender, e);
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nha sĩ: " + ex.Message);
                }
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void MaNS_TextChanged(object sender, EventArgs e)
        {
            string maNS = MaNS.Text.Trim();
            if (maNS == "")
            {
                Dentist_Load(sender, e);

            }
            else
            {
                
                
                
                string query = "SELECT * FROM NhaSi WHERE MaNS LIKE '%" + maNS + "%'";
                NhaSiDGV.DataSource = modify.Table(query);
                

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Homes obj = new Homes();
            obj.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();
            obj.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Staffs obj = new Staffs();
            obj.Show();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Appointments obj = new Appointments();
            obj.Show();
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Medicine obj = new Medicine();
            obj.Show();
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Statistics obj = new Statistics();
            obj.Show();
            this.Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }

        private void ChiTietLichTrinhBtn_Click(object sender, EventArgs e)
        {
            if (NhaSiDGV.Rows.Count > 1)
            {
                MaNSDangChon = NhaSiDGV.SelectedRows[0].Cells[0].Value.ToString();
                //MessageBox.Show(MaNSDangChon);
                WorkTimes obj = new WorkTimes();
                obj.Show();
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nha sĩ");
            }
        }

    }
}
