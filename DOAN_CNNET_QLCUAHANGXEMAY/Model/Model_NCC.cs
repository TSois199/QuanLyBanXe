using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DOAN_CNNET_QLCUAHANGXEMAY
{
    class Model_NCC
    {
        private string MaNhaCC;
        public string manhaCC
        {
            get { return MaNhaCC; }
            set { MaNhaCC = value; }
        }
        private string TenNhaCC;
        public string tennhaCC
        {
            get { return TenNhaCC; }
            set { TenNhaCC = value; }
        }

        public Model_NCC(string ma, string ten)
        {
            MaNhaCC = ma;
            TenNhaCC = ten;
        }
        public Model_NCC()
        {

        }
    }
}
