using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Dentistry_Management
{
    public partial class WorkTimes : Form
    {
        public WorkTimes()
        {
            InitializeComponent();
        }
        private BindingSource bs = new BindingSource();
        Modify modify = new Modify();


        SqlConnection conn = new SqlConnection(@"Data Source=THANHTRUNG\PC1;Initial Catalog=QUANLYNHAKHOA;Persist Security Info=True;User ID=sa;Password=heongusi22;");


        private void Clear()
        {
            ThuTrongTuan.Text = "";
            GioBatDau.Text = "";
            GioKetThuc.Text = "";
        }
        private void WorkTimes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYNHAKHOADataSet10.LichLamViec' table. You can move, or remove it, as needed.
            this.lichLamViecTableAdapter.Fill(this.qUANLYNHAKHOADataSet10.LichLamViec);
            MaNS.Text = Dentist.MaNSDangChon;
            string queryString = "SELECT TenNS FROM NhaSi WHERE MaNS = '"+Dentist.MaNSDangChon+"'";

            using (conn)
            {
                SqlCommand command = new SqlCommand(queryString, conn);
                conn.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TenNS.Text = reader[0].ToString();
                    }
                }
            }
            try
            {
                string query = "SELECT * FROM LichLamViec";
                bs.DataSource = modify.Table(query);
                LichLamViecDGV.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load bảng: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dentist obj = new Dentist();
            obj.Show();
            this.Hide();
        }

        private void MaNS_TextChanged(object sender, EventArgs e)
        {
            string maNS = MaNS.Text.Trim();
            if (maNS == "")
            {
                WorkTimes_Load(sender, e);

            }
            else
            {
             
                if (maNS == "")
                {
                    bs.RemoveFilter();
                }
                else
                {
                    bs.Filter = "MaNhaSi = '" + maNS + "'";
                }

            }
        }

        private void ThemBtn_Click(object sender, EventArgs e)
        {
            if (ThuTrongTuan.SelectedIndex == -1 || GioBatDau.Text == "" || GioKetThuc.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm lịch làm việc cho nha sĩ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO LichLamViec(ThuTrongTuan,GioBatDau,GioKetThuc) " +
                                                        "VALUES (@ThuTrongTuan,@GioBatDau,@GioKetThuc) ", conn);

                        cmd.Parameters.AddWithValue("@ThuTrongTuan", ThuTrongTuan.Text);
                        cmd.Parameters.AddWithValue("@GioBatDau", GioBatDau.Text);
                        cmd.Parameters.AddWithValue("@GioKetThuc", GioKetThuc.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm lịch làm việc thành công!@");
                        conn.Close();
                        WorkTimes_Load(sender, e);
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm lịch làm việc: " + ex.Message);
                }
            }
        }

        private void LichLamViecDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ThuTrongTuan.SelectedItem = LichLamViecDGV.SelectedRows[0].Cells[1].Value.ToString();
            GioBatDau.Text = LichLamViecDGV.SelectedRows[0].Cells[2].Value.ToString();
            GioKetThuc.Text = LichLamViecDGV.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
