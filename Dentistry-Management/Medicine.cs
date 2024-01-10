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
    public partial class Medicine : Form
    {
        public Medicine()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        SqlConnection conn = new SqlConnection(@"Data Source=THANHTRUNG\PC1;Initial Catalog=QUANLYNHAKHOA;Persist Security Info=True;User ID=sa;Password=heongusi22;");

        private void Clear()
        {
            MaThuoc.Text = "";
            TenThuoc.Text = "";
            XuatXu.Text = "";
            CongDung.Text = "";

        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            try
            {
                ThuocDGV.DataSource = modify.Table("SELECT * FROM Thuoc ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void ThemBtn_Click(object sender, EventArgs e)
        {
            if (TenThuoc.Text == "" || XuatXu.Text == "" || CongDung.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm mã thuốc này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Thuoc(TenThuoc,XuatXu,CongDung) " +
                                                        "VALUES (@TenThuoc,@XuatXu,@CongDung) ", conn);

                        cmd.Parameters.AddWithValue("@TenThuoc", TenThuoc.Text);
                        cmd.Parameters.AddWithValue("@XuatXu", XuatXu.Text);
                        cmd.Parameters.AddWithValue("@CongDung", CongDung.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mã thuốc thành công!@");
                        conn.Close();
                        Medicine_Load(sender, e);
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm mã thuốc: " + ex.Message);
                }
            }
        }

        private void CapNhatBtn_Click(object sender, EventArgs e)
        {
            if (MaThuoc.Text == "")
            { MessageBox.Show("Vui lòng điền mã thuốc muốn cập nhật"); }
            else
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn sửa mã thuốc này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Thuoc SET TenThuoc = @TenThuoc,XuatXu = @XuatXu,CongDung = @CongDung " +
                                                        " WHERE MaThuoc ='" + MaThuoc.Text + "' ", conn);

                        cmd.Parameters.AddWithValue("@TenThuoc", TenThuoc.Text);
                        cmd.Parameters.AddWithValue("@XuatXu", XuatXu.Text);
                        cmd.Parameters.AddWithValue("@CongDung", CongDung.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật nhân viên thành công!@");
                        conn.Close();
                        Medicine_Load(sender, e);
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa: " + ex.Message);
                }
            }
        }

        private void ThuocDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaThuoc.Text = ThuocDGV.SelectedRows[0].Cells[0].Value.ToString();
            TenThuoc.Text = ThuocDGV.SelectedRows[0].Cells[1].Value.ToString();
            XuatXu.Text = ThuocDGV.SelectedRows[0].Cells[2].Value.ToString();
            CongDung.Text = ThuocDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void XoaBtn_Click(object sender, EventArgs e)
        {
            if (ThuocDGV.Rows.Count > 1)
            {
                string choose = ThuocDGV.SelectedRows[0].Cells[0].Value.ToString();

                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa mã thuốc này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE Thuoc WHERE MaThuoc = '" + choose + "'", conn);
                        cmd.ExecuteNonQuery();
                        //modify.Command(query);
                        MessageBox.Show("Xóa mã thuốc thành công!");
                        conn.Close();
                        Medicine_Load(sender, e);
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa mã thuốc: " + ex.Message);
                }
            }
        }

        private void MaThuoc_TextChanged(object sender, EventArgs e)
        {
            string maThuoc = MaThuoc.Text.Trim();
            if (maThuoc == "")
            {
                Medicine_Load(sender, e);

            }
            else
            {
                string query = "SELECT * FROM Thuoc WHERE MaThuoc LIKE '%" + maThuoc + "%'";
                ThuocDGV.DataSource = modify.Table(query);
            }
        }

        private void TenThuoc_TextChanged(object sender, EventArgs e)
        {
            string tenThuoc = TenThuoc.Text.Trim();
            if (tenThuoc == "")
            {
                Medicine_Load(sender, e);

            }
            else
            {
                string query = "SELECT * FROM Thuoc WHERE TenThuoc LIKE '%" + tenThuoc + "%'";
                ThuocDGV.DataSource = modify.Table(query);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
