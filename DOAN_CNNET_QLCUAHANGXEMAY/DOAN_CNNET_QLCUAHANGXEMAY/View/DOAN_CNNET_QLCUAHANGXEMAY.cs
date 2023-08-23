using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_CNNET_QLCUAHANGXEMAY
{
    public partial class DOAN_CNNET_QLCUAHANGXEMAY : Form
    {
        public DOAN_CNNET_QLCUAHANGXEMAY()
        {
            InitializeComponent();
        }
        private void xeToolStripMenuItem_Click(object sender, EventArgs e)
        {

                DanhMucXe dmx = new DanhMucXe();
                dmx.Show();
                dmx.MdiParent = this;
        }

        private void hãngXeToolStripMenuItem_Click(object sender, EventArgs e)
        {

                DanhMucHangXe dmhx = new DanhMucHangXe();
                dmhx.Show();
                dmhx.MdiParent = this;
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
                DanhMucKhachHang dmkh = new DanhMucKhachHang();
                dmkh.Show();
                dmkh.MdiParent = this;
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucNCC dmncc = new DanhMucNCC();
            dmncc.Show();
            dmncc.MdiParent = this;
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucNhanVien dmnv = new DanhMucNhanVien();
            dmnv.Show();
            dmnv.MdiParent = this;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            View.DangNhapHeThong dx = new View.DangNhapHeThong();
            dx.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucHoaDon dmhd = new DanhMucHoaDon();
            dmhd.Show();
            dmhd.MdiParent = this;
        }

        private void checkDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowReport rpt = new ShowReport();
            rpt.Show();
            rpt.MdiParent = this;
        }
    }
}
