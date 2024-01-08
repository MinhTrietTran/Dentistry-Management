using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentistry_Management
{
    internal class NhanVien
    {
        private int _maNV;
        private string _tenNV;
        private string _phaiNV;
        private string _ngaySinhNV;
        private string _dienThoaiNV;
        private string _emailNV;
        private string _diaChiNV;
        private string _taiKhoanNV;

        public NhanVien()
        {
        }

        public NhanVien(int maNV, string tenNV, string phaiNV, string ngaySinhNV, string dienThoaiNV, string emailNV, string diaChiNV, string taiKhoanNV)
        {
            _maNV = maNV;
            _tenNV = tenNV;
            _phaiNV = phaiNV;
            _ngaySinhNV = ngaySinhNV;
            _dienThoaiNV = dienThoaiNV;
            _emailNV = emailNV;
            _diaChiNV = diaChiNV;
            _taiKhoanNV = taiKhoanNV;
        }

        public int MaNV { get => _maNV; set => _maNV = value; }
        public string TenNV { get => _tenNV; set => _tenNV = value; }
        public string PhaiNV { get => _phaiNV; set => _phaiNV = value; }
        public string NgaySinhNV { get => _ngaySinhNV; set => _ngaySinhNV = value; }
        public string DienThoaiNV { get => _dienThoaiNV; set => _dienThoaiNV = value; }
        public string EmailNV { get => _emailNV; set => _emailNV = value; }
        public string DiaChiNV { get => _diaChiNV; set => _diaChiNV = value; }
        public string TaiKhoanNV { get => _taiKhoanNV; set => _taiKhoanNV = value; }
    }
}
