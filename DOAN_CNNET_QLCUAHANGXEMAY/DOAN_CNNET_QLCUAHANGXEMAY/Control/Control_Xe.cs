using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DOAN_CNNET_QLCUAHANGXEMAY
{
    class Control_Xe
    {
        ConnSQL connect = new ConnSQL();
        DataSet ds;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommandBuilder cB;

        public DataTable select(string table)
        {
            ds = new DataSet();
            string stringselectX = "select MaXe, TenXe, LoaiXe, HangXe.TenHang, DonGia, NgayNhap, PhanKhoi, MauXe from xe, HangXe where Xe.MaHang = HangXe.MaHang";
            SqlCommand cmd = new SqlCommand(stringselectX, connect.KetNoiCSDL());
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, table);
            dt = ds.Tables[table];
            return dt;
        }
        public int checkTrungMa(string ma, string table)
        {
            DataRow drCheck = ds.Tables[table].Rows.Find(ma);
            if (drCheck != null)
            {
                return 1;
            }
            return 0;
        }
        public void insert(Model_Xe x, string table)
        {
            DataRow dr = ds.Tables[table].NewRow();
            dr[0] = x.maXe;
            dr[1] = x.tenXe;
            dr[2] = x.loaiXe;
            dr[3] = x.maHang;
            dr[4] = x.donGia;
            dr[5] = x.ngayNhap;
            dr[6] = x.phanKhoi;
            dr[7] = x.mauSac;
            ds.Tables[table].Rows.Add(dr);
            cB = new SqlCommandBuilder(da);
            da.Update(ds, table);
        }
        public void update(Model_Xe x, string table)
        {
            DataRow dr = ds.Tables[table].Rows.Find(x.maXe);
            if (dr != null)
            {
                dr[1] = x.tenXe;
                dr[2] = x.loaiXe;
                dr[3] = x.maHang;
                dr[4] = x.donGia;
                dr[5] = x.ngayNhap;
                dr[6] = x.phanKhoi;
                dr[7] = x.mauSac;

            }
            SqlCommandBuilder cB = new SqlCommandBuilder(da);
            da.Update(ds, table);

        }

        public void delete(Model_Xe x, string table)
        {
            DataRow dr = ds.Tables[table].Rows.Find(x.maXe);
            if (dr != null)
            {
                dr.Delete();
            }
            SqlCommandBuilder cB = new SqlCommandBuilder(da);
            da.Update(ds, table);
        }
    }
}
