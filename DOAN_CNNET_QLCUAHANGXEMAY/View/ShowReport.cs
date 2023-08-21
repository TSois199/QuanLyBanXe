using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DOAN_CNNET_QLCUAHANGXEMAY
{
    public partial class ShowReport : Form
    {
        Control_HoaDon hd = new Control_HoaDon();
        string table = "HoaDon";
        public ShowReport()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt = hd.select(table);
            MyReport rpt = new MyReport();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;

            //SeDatabaseLogon để không phải nhập lại khi showreport
            rpt.SetDatabaseLogon(@"LAPTOP-IRLS8GIA\SQLEXPRESS", "QL_Xe_DoAn");

            crystalReportViewer1.Refresh();
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.DisplayStatusBar = false;
        }

        private void ShowReport_Load(object sender, EventArgs e)
        {
            MyReport rpt = new MyReport();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }
    }
}
