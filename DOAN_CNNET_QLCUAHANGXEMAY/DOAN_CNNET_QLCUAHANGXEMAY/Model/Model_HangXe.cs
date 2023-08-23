using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DOAN_CNNET_QLCUAHANGXEMAY
{
    public class Model_HangXe
    {
        private string MaHangXe;
        public string maHang
        {
            get { return MaHangXe; }
            set { MaHangXe = value; }
        }
        private string TenHangXe;
        public string tenHang
        {
            get { return TenHangXe; }
            set { TenHangXe = value; }
        }

        public Model_HangXe(string ma, string ten)
        {
            MaHangXe = ma;
            TenHangXe = ten;
        }
        public Model_HangXe()
        {

        }
    }
}
