using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

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
    }
}
