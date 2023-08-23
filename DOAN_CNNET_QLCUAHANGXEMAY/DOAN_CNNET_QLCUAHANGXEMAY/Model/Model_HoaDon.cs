using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DOAN_CNNET_QLCUAHANGXEMAY
{
    class Model_HoaDon
    {
        private string MaHoaDon;
        public string maHD
        {
            get { return MaHoaDon; }
            set { MaHoaDon = value; }
        }
        private string MaKhachHang;
        public string maKH
        {
            get { return MaKhachHang; }
            set { MaKhachHang = value; }
        }
        private string MaXeMay;
        public string maXe
        {
            get { return MaXeMay; }
            set { MaXeMay = value; }
        }
        private string MaNV;
        public string maNV
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        private string MaNhaCC;
        public string manhaCC
        {
            get { return MaNhaCC; }
            set { MaNhaCC = value; }
        }
        private string SoLuongMua;
        public string slmua
        {
            get { return SoLuongMua; }
            set { SoLuongMua = value; }
        }
        private string DonGiaXe;
        public string donGia
        {
            get { return DonGiaXe; }
            set { DonGiaXe = value; }
        }
        private string ThanhTienHD;
        public string thanhtienhd
        {
            get { return ThanhTienHD; }
            set { ThanhTienHD = value; }
        }
        public Model_HoaDon(string mahd, string makh, string max, string manv, string mancc, string sl, string dg, string tt)
        {

            MaHoaDon = mahd;
            MaKhachHang = makh;
            MaXeMay = max;
            MaNhaCC = mancc;
            SoLuongMua = sl;
            DonGiaXe = dg;
            ThanhTienHD = tt;
        }
        public Model_HoaDon()
        {

        }
    }
}
