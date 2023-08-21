using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DOAN_CNNET_QLCUAHANGXEMAY
{
    public class ConnSQL
    {
        public static string sevName = @"LAPTOP-IRLS8GIA\SQLEXPRESS";
        public static string dbName = "QL_Xe_DoAn";
        string stringconn = "Data Source =" + sevName + "; Initial Catalog =" + dbName + "; Integrated Security = True";
        public SqlConnection KetNoiCSDL()
        {

            SqlConnection conn = new SqlConnection(stringconn);
            return conn;
        }
    }
}
