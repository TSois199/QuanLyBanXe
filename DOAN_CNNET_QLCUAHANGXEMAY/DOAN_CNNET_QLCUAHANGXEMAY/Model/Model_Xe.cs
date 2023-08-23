using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DOAN_CNNET_QLCUAHANGXEMAY
{
    class Model_Xe
    {
        private string MaXeMay;
        public string maXe
        {
            get { return MaXeMay; }
            set { MaXeMay = value; }
        }
        private string TenXeMay;
        public string tenXe
        {
            get { return TenXeMay; }
            set { TenXeMay = value; }
        }
        private string LoaiXeMay;
        public string loaiXe
        {
            get { return LoaiXeMay; }
            set { LoaiXeMay = value; }
        }
        private string MaHangXe;
        public string maHang
        {
            get { return MaHangXe; }
            set { MaHangXe = value; }
        }
        private string DonGiaXe;
        public string donGia
        {
            get { return DonGiaXe; }
            set { DonGiaXe = value; }
        }
        private string NgayNhapXe;
        public string ngayNhap
        {
            get { return NgayNhapXe; }
            set { NgayNhapXe = value; }
        }
        private string PhanKhoiXe;
        public string phanKhoi
        {
            get { return PhanKhoiXe; }
            set { PhanKhoiXe = value; }
        }
        private string MauSacXe;
        public string mauSac
        {
            get { return MauSacXe; }
            set { MauSacXe = value; }
        }

        public Model_Xe(string ma, string ten, string loai, string mah, string dg, string day, string pk, string ms)
        {
            MaXeMay = ma;
            TenXeMay = ten;
            LoaiXeMay = loai;
            MaHangXe = mah;
            DonGiaXe = dg;
            NgayNhapXe = day;
            PhanKhoiXe = pk;
            MauSacXe = ms;
        }
        public Model_Xe()
        {

        }
    }
}
