using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DOAN_CNNET_QLCUAHANGXEMAY
{
    class Control_HoaDon
    {
        ConnSQL connect = new ConnSQL();
        DataSet ds;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommandBuilder cB;

        public DataTable select(string table)
        {
            ds = new DataSet();
            string stringselectX = "select * from " + table;
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
        public void insert(Model_HoaDon hd, string table)
        {
            DataRow dr = ds.Tables[table].NewRow();
            dr[0] = hd.maHD;
            dr[1] = hd.maKH;
            dr[2] = hd.maXe;
            dr[3] = hd.maNV;
            dr[4] = hd.manhaCC;
            dr[5] = hd.slmua;
            dr[6] = hd.donGia;
            dr[7] = hd.thanhtienhd;
            ds.Tables[table].Rows.Add(dr);
            cB = new SqlCommandBuilder(da);
            da.Update(ds, table);
        }
        public void update(Model_HoaDon hd, string table)
        {
            DataRow dr = ds.Tables[table].Rows.Find(hd.maHD);
            if (dr != null)
            {
                dr[1] = hd.maKH;
                dr[2] = hd.maXe;
                dr[3] = hd.maNV;
                dr[4] = hd.manhaCC;
                dr[5] = hd.slmua;
                dr[6] = hd.donGia;
                dr[7] = hd.thanhtienhd;

            }
            SqlCommandBuilder cB = new SqlCommandBuilder(da);
            da.Update(ds, table);

        }

        public void delete(Model_HoaDon hd, string table)
        {
            DataRow dr = ds.Tables[table].Rows.Find(hd.maHD);
            if (dr != null)
            {
                dr.Delete();
            }
            SqlCommandBuilder cB = new SqlCommandBuilder(da);
            da.Update(ds, table);
        }
        public DataTable selectedChance(string table, string ma, string change)
        {
            ds = new DataSet();
            string selectString = "select * from " + table + " where " + ma + "='" + change + "'";
            SqlCommand cmd = new SqlCommand(selectString, connect.KetNoiCSDL());
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, table);
            dt = ds.Tables[table];
            return dt;
        }
    }
}
