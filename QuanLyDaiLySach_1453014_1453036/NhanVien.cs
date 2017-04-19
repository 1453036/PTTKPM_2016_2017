using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLySach_1453014_1453036
{
    class NhanVien
    {
        private string _maNhanVien;
        private string _hoTen;
        private string _ngaySinh;
        private string _noiSinh;
        private string _soDienThoai;
        private string _chungMinhThu;
        private string _diaChi;      
        private int _luong;
        private string _loaiNhanVien;
        private string _caLam;
        private string _hinhThucLam;

        public string MaNhanVien
        {
            get
            {
                return _maNhanVien;
            }

            set
            {
                _maNhanVien = value;
            }
        }
        
        public string HoTen
        {
            get
            {
                return _hoTen;
            }

            set
            {
                _hoTen = value;
            }
        }

        public string NgaySinh
        {
            get
            {
                return _ngaySinh;
            }

            set
            {
                _ngaySinh = value;
            }
        }

        public string NoiSinh
        {
            get
            {
                return _noiSinh;
            }

            set
            {
                _noiSinh = value;
            }
        }

        public string SoDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }

        public string ChungMinhThu
        {
            get { return _chungMinhThu; }
            set { _chungMinhThu = value; }
        }

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        public int Luong
        {
            get { return _luong; }
            set{ _luong = value; }
        }

        public string LoaiNhanVien
        {
            get { return _loaiNhanVien; }
            set { _loaiNhanVien = value; }
        }

        public string CaLam
        {
            get { return _caLam; }
            set { _caLam = value; }
        }

        public string HinhThucLam
        {
            get { return _hinhThucLam; }
            set { _hinhThucLam = value; }
        }
    }
}
