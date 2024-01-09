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
    public partial class Dentist : Form
    {
        public Dentist()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        SqlConnection conn = new SqlConnection(@"Data Source=THANHTRUNG\PC1;Initial Catalog=QUANLYNHAKHOA;Persist Security Info=True;User ID=sa;Password=heongusi22;");

        private void Dentist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYNHAKHOADataSet2.NhaSi' table. You can move, or remove it, as needed.
            this.nhaSiTableAdapter.Fill(this.qUANLYNHAKHOADataSet2.NhaSi);
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
            PhaiNS.Text = "";
            NgaySinhNS.Text = "";
            DienThoaiNS.Text = "";
            EmailNS.Text = "";
            DiaChiNS.Text = "";

        }
        // Them NS
        private void ThemBtn_Click(object sender, EventArgs e)
        {
            if (TenNS.Text == "" || PhaiNS.Text == "" || NgaySinhNS.Text == "" || DienThoaiNS.Text == "" || EmailNS.Text == "" || DiaChiNS.Text == "")
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
                        cmd.Parameters.AddWithValue("@PhaiNS", PhaiNS.Text);
                        cmd.Parameters.AddWithValue("@NgaySinhNS", NgaySinhNS.Text);
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

        private void NhaSiDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (NhaSiDGV.Rows.Count > 1)
            {
                MaNS.Text = NhaSiDGV.SelectedRows[0].Cells[0].Value.ToString();
                TenNS.Text = NhaSiDGV.SelectedRows[0].Cells[1].Value.ToString();
                PhaiNS.SelectedItem = NhaSiDGV.SelectedRows[0].Cells[2].Value.ToString();
                NgaySinhNS.Text = NhaSiDGV.SelectedRows[0].Cells[3].Value.ToString();
                DienThoaiNS.Text = NhaSiDGV.SelectedRows[0].Cells[4].Value.ToString();
                EmailNS.Text = NhaSiDGV.SelectedRows[0].Cells[5].Value.ToString();
                DiaChiNS.Text = NhaSiDGV.SelectedRows[0].Cells[6].Value.ToString();
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
                        cmd.Parameters.AddWithValue("@PhaiNS", PhaiNS.Text);
                        cmd.Parameters.AddWithValue("@NgaySinhNS", NgaySinhNS.Text);
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

                string query = "DELETE NhaSi ";
                query += "WHERE TenNS = '" + choose + "'";
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
    }
}
