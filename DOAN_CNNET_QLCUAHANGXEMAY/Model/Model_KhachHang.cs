using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DOAN_CNNET_QLCUAHANGXEMAY
{
    class Model_KhachHang
    {
        private string MaKH;
        public string maKH
        {
            get { return MaKH; }
            set { MaKH = value; }
        }
        private string TenKH;
        public string tenKH
        {
            get { return TenKH; }
            set { TenKH = value; }
        }
        private string GioiTinh;
        public string gioiTinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }
        private string NgaySinh;
        public string ngaySinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }
        private string MaXe;
        public string maXe
        {
            get { return MaXe; }
            set { MaXe = value; }
        }
        private string NgayMua;
        public string ngayMua
        {
            get { return NgayMua; }
            set { NgayMua = value; }
        }
        private string HanBH;
        public string hanBH
        {
            get { return HanBH; }
            set { HanBH = value; }
        }
        private string MatKhauDN;
        public string matkhaudn
        {
            get { return MatKhauDN; }
            set { MatKhauDN = value; }
        }

        public Model_KhachHang(string ma, string ten, string gt, string ns, string mx, string nm, string bh,string mk)
        {

            MaKH = ma;
            TenKH = ten;
            GioiTinh = gt;
            NgaySinh = ns;
            MaXe = mx;
            NgayMua = nm;
            HanBH = bh;
            MatKhauDN = mk;
        }
        public Model_KhachHang()
        {

        }
    }
}
