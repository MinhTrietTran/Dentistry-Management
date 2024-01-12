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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }
        public static string MaBNDangDung;
        Modify modify = new Modify();
        SqlConnection conn = new SqlConnection(@"Data Source=THANHTRUNG\PC1;Initial Catalog=QUANLYNHAKHOA;Persist Security Info=True;User ID=sa;Password=heongusi22;");

        private void Patients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYNHAKHOADataSet4.BenhNhan' table. You can move, or remove it, as needed.
            this.benhNhanTableAdapter.Fill(this.qUANLYNHAKHOADataSet4.BenhNhan);
            try
            {
                BenhNhanDGV.DataSource = modify.Table("SELECT * FROM BenhNhan BN");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Clear text box
        private void Clear()
        {
            MaBN.Text = "";
            TenBN.Text = "";
            PhaiBN.SelectedIndex = -1;
            DienThoaiBN.Text = "";
            DiaChiBN.Text = "";
            ThongTinTongQuanSKRangMieng.Text = "";
            GhiChu.Text = "";
            NhaSiMacDinh.Text = "";
        }

        private void Thembtn_Click(object sender, EventArgs e)
        {
            if (TenBN.Text == "" || PhaiBN.Text == "" || DienThoaiBN.Text == "" || DiaChiBN.Text == "" || ThongTinTongQuanSKRangMieng.Text == "" || GhiChu.Text == "") 
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm bệnh nhân này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO BenhNhan(TenBN,PhaiBN,DienThoaiBN,DiaChiBN, NgaySinhBN, ThongTinTongQuanSKRangMieng, GhiChu) " +
                                                        "VALUES (@TenBN,@PhaiBN,@DienThoaiBN,@DiaChiBN, @NgaySinhBN, @ThongTinTongQuanSKRangMieng, @GhiChu) ", conn);

                        cmd.Parameters.AddWithValue("@TenBN", TenBN.Text);
                        cmd.Parameters.AddWithValue("@PhaiBN", PhaiBN.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DienThoaiBN", DienThoaiBN.Text);
                        cmd.Parameters.AddWithValue("@DiaChiBN", DiaChiBN.Text);
                        cmd.Parameters.AddWithValue("@NgaySinhBN", NgaySinhBN.Value.Date.ToString());
                        cmd.Parameters.AddWithValue("@ThongTinTongQuanSKRangMieng", ThongTinTongQuanSKRangMieng.Text);
                        cmd.Parameters.AddWithValue("@GhiChu", GhiChu.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm bệnh nhân thành công!@");
                        conn.Close();
                        Patients_Load(sender, e);
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm bệnh nhân: " + ex.Message);
                }
            }
        }

        private void BenhNhanDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                MaBN.Text = BenhNhanDGV.SelectedRows[0].Cells[0].Value.ToString();
                TenBN.Text = BenhNhanDGV.SelectedRows[0].Cells[1].Value.ToString();
                PhaiBN.SelectedItem = BenhNhanDGV.SelectedRows[0].Cells[2].Value.ToString();
                DienThoaiBN.Text = BenhNhanDGV.SelectedRows[0].Cells[3].Value.ToString();
                DiaChiBN.Text = BenhNhanDGV.SelectedRows[0].Cells[4].Value.ToString();
                NgaySinhBN.Value = (DateTime)BenhNhanDGV.SelectedRows[0].Cells[5].Value;
                ThongTinTongQuanSKRangMieng.Text = BenhNhanDGV.SelectedRows[0].Cells[6].Value.ToString();
                GhiChu.Text = BenhNhanDGV.SelectedRows[0].Cells[7].Value.ToString();
                NhaSiMacDinh.Text = BenhNhanDGV.SelectedRows[0].Cells[8].Value.ToString();

        }

        private void CapNhatBtn_Click(object sender, EventArgs e)
        {
            if (MaBN.Text == "")
            { MessageBox.Show("Vui lòng điền mã bệnh nhân muốn cập nhật"); }
            else
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn sửa bệnh nhân này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE BenhNhan SET TenBN = @TenBN, PhaiBN = @PhaiBN, DienThoaiBN = @DienThoaiBN, DiaChiBN = @DiaChiBN, NgaySinhBN = @NgaySinhBN, ThongTinTongQuanSKRangMieng = @ThongTinTongQuanSKRangMieng, GhiChu = @GhiChu" +
                                                        " WHERE MaBN ='" + MaBN.Text + "' ", conn);

                        cmd.Parameters.AddWithValue("@TenBN", TenBN.Text);
                        cmd.Parameters.AddWithValue("@PhaiBN", PhaiBN.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DienThoaiBN", DienThoaiBN.Text);
                        cmd.Parameters.AddWithValue("@DiaChiBN", DiaChiBN.Text);
                        cmd.Parameters.AddWithValue("@NgaySinhBN", NgaySinhBN.Value.Date.ToString());
                        cmd.Parameters.AddWithValue("@ThongTinTongQuanSKRangMieng", ThongTinTongQuanSKRangMieng.Text);
                        cmd.Parameters.AddWithValue("@GhiChu", GhiChu.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật bệnh nhân thành công!@");
                        conn.Close();
                        Patients_Load(sender, e);
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
            if (BenhNhanDGV.Rows.Count > 1)
            {
                string choose = BenhNhanDGV.SelectedRows[0].Cells[0].Value.ToString();
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa bệnh nhân này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE BenhNhan WHERE MaBN = '" + choose + "'", conn);
                        cmd.ExecuteNonQuery();
                        //modify.Command(query);
                        MessageBox.Show("Xóa bệnh nhân thành công!");
                        conn.Close();
                        Patients_Load(sender, e);
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa bệnh nhân: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Danh sách bệnh nhân rỗng! ");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaBN_TextChanged(object sender, EventArgs e)
        {
            string maNS = MaBN.Text.Trim();
            if (maNS == "")
            {
                Patients_Load(sender, e);

            }
            else
            {
                string query = "SELECT * FROM BenhNhan WHERE MaBN LIKE '%" + maNS + "%'";
                BenhNhanDGV.DataSource = modify.Table(query);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Homes obj = new Homes();
            obj.Show();
            this.Hide(); 
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Dentist obj = new Dentist();
            obj.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Staffs obj = new Staffs();
            obj.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Appointments obj = new Appointments();
            obj.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Medicine obj = new Medicine();
            obj.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Statistics obj = new Statistics();
            obj.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void ThanhToanBtn_Click(object sender, EventArgs e)
        {
            MaBNDangDung = BenhNhanDGV.SelectedRows[0].Cells[0].Value.ToString();
            //MessageBox.Show(MaNSDangChon);
            Payment obj = new Payment();
            obj.Show();
        }

        private void KeHoachDieuTriBtn_Click(object sender, EventArgs e)
        {
            MaBNDangDung = BenhNhanDGV.SelectedRows[0].Cells[0].Value.ToString();
            TreatmentPlan obj = new TreatmentPlan();
            obj.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MaBNDangDung = BenhNhanDGV.SelectedRows[0].Cells[0].Value.ToString();
            Payment obj = new Payment();
            obj.Show();
        }
    }
}
