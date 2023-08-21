using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DOAN_CNNET_QLCUAHANGXEMAY
{
    class Model_NhanVien
    {
        private string MaNV;
        public string maNV
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        private string TenNV;
        public string tenNV
        {
            get { return TenNV; }
            set { TenNV = value; }
        }
        private string GioiTinh;
        public string gioiTinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }
        private string SDT;
        public string sdt
        {
            get { return SDT; }
            set { SDT = value; }
        }
        private string DiaChi;
        public string diaChi
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }
        private string ChucVu;
        public string chucVu
        {
            get { return ChucVu; }
            set { ChucVu = value; }
        }
        private string MatKhau;
        public string matKhau
        {
            get { return MatKhau; }
            set { MatKhau = value; }
        }

        public Model_NhanVien(string ma, string ten, string gt, string sdt, string dc, string cv, string mk)
        {

            MaNV = ma;
            TenNV = ten;
            GioiTinh = gt;
            SDT = sdt;
            DiaChi = dc;
            ChucVu = cv;
            MatKhau = mk;
        }
        public Model_NhanVien()
        {

        }
    }
}
