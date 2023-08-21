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
using System.Data;
namespace DOAN_CNNET_QLCUAHANGXEMAY
{
    public partial class DanhMucHoaDon : Form
    {
        DataColumn[] key = new DataColumn[1];
        Control_HoaDon hd = new Control_HoaDon();
        string table = "HoaDon";
        public DanhMucHoaDon()
        {
            InitializeComponent();
        }
        void AddHeader()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("MaHD", "Mã Hóa Đơn");
            dataGridView1.Columns[0].DataPropertyName = "MaHD";
            dataGridView1.Columns.Add("MaKH", "Khách Hàng");
            dataGridView1.Columns[1].DataPropertyName = "MaKH";
            dataGridView1.Columns.Add("MaXe", "Xe");
            dataGridView1.Columns[2].DataPropertyName = "MaXe";
            dataGridView1.Columns.Add("MaNV", "Nhân Viên");
            dataGridView1.Columns[3].DataPropertyName = "MaNV";
            dataGridView1.Columns.Add("MANCC", "Nhà Cung Cấp");
            dataGridView1.Columns[4].DataPropertyName = "MANCC";
            dataGridView1.Columns.Add("SoLuong", "Số Lượng");
            dataGridView1.Columns[5].DataPropertyName = "SoLuong";
            dataGridView1.Columns.Add("DonGia", "Đơn Giá");
            dataGridView1.Columns[6].DataPropertyName = "DonGia";
            dataGridView1.Columns.Add("ThanhTien", "Thành Tiền");
            dataGridView1.Columns[7].DataPropertyName = "ThanhTien";

        }

        void loadDTG()
        {
            DataTable dtX = hd.select(table);
            dataGridView1.DataSource = dtX;
            key[0] = dtX.Columns[0];
            dtX.PrimaryKey = key;
        }

        void loadKhachHang()
        {
            string table = "KhachHang";
            DataTable dt = hd.select(table);
            cbb_makh.DataSource = dt;
            cbb_makh.DisplayMember = "TenKH";
            cbb_makh.ValueMember = "MaKH";
        }
        void loadXe()
        {
            string table = "Xe";
            DataTable dt = hd.select(table);
            cbb_maxe.DataSource = dt;
            cbb_maxe.DisplayMember = "TenXe";
            cbb_maxe.ValueMember = "MaXe";
        }
        void loadNhanVien()
        {
            string table = "NhanVien";
            DataTable dt = hd.select(table);
            cbb_manv.DataSource = dt;
            cbb_manv.DisplayMember = "TenNV";
            cbb_manv.ValueMember = "MaNV";
        }
        void loadNHACUNGCAP()
        {
            string table = "NHACUNGCAP";
            DataTable dt = hd.select(table);
            cbb_ncc.DataSource = dt;
            cbb_ncc.DisplayMember = "TENNCC";
            cbb_ncc.ValueMember = "MANCC";
        }

        void loadAll()
        {
            AddHeader();
            loadDTG();
        }

        private void DanhMucHoaDon_Load(object sender, EventArgs e)
        {
            loadKhachHang();
            loadXe();
            loadNhanVien();
            loadNHACUNGCAP();
            loadGia();
            loadAll();
        }

        

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                Model_HoaDon newhd = new Model_HoaDon();
                newhd.maHD = tb_hd.Text;
                newhd.maKH = cbb_makh.SelectedValue.ToString();
                newhd.maXe = cbb_maxe.SelectedValue.ToString();
                newhd.maNV = cbb_manv.SelectedValue.ToString();
                newhd.manhaCC = cbb_ncc.SelectedValue.ToString();
                newhd.donGia = cbb_dongia.SelectedValue.ToString();
                newhd.slmua = tb_sl.Text;
                newhd.thanhtienhd = (int.Parse(cbb_dongia.SelectedValue.ToString()) * int.Parse(tb_sl.Text)).ToString();
                if (hd.checkTrungMa(newhd.maHD, table) == 1)
                {
                    MessageBox.Show("Trùng mã hóa đơn có từ trước!");
                    return;
                }
                hd.insert(newhd, table);
                MessageBox.Show("Nhập hóa đơn thành công rồi nha!");
                tb_hd.Clear();
                tb_sl.Clear();
                tb_hd.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex != null ? ex.Message : "Lỗi rồi !");
            }
        }
        void loadGia()
        {
            string table = "Xe";
            string ma = "MaXe";
            string change = cbb_maxe.SelectedValue.ToString();
            DataTable dt = hd.selectedChance(table, ma, change);
            cbb_dongia.DataSource = dt;
            cbb_dongia.DisplayMember = "DonGia";
            cbb_dongia.ValueMember = "DonGia";
        }
        private void cbb_maxe_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadKhachHang();
            loadNhanVien();
            loadNHACUNGCAP();
            loadGia();
            loadAll();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Model_HoaDon newhd = new Model_HoaDon();
            newhd.maHD = tb_hd.Text;
            if (hd.checkTrungMa(newhd.maHD, table) == 1)
            {
                btn_luu.Enabled = true;
            }
            else
                MessageBox.Show("Hoá đơn cần sửa không tồn tại");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Model_HoaDon newhd = new Model_HoaDon();
            newhd.maHD = tb_hd.Text;
            if (hd.checkTrungMa(newhd.maHD, table) == 1)
            {
                hd.delete(newhd, table);
                MessageBox.Show("Xóa thành công rồi nha!");
                tb_hd.Clear();
                tb_sl.Clear();
                tb_hd.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Lỗi rồi nha ");
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            Model_HoaDon newhd = new Model_HoaDon();
            newhd.maHD = tb_hd.Text;
            newhd.maKH = cbb_makh.SelectedValue.ToString();
            newhd.maXe = cbb_maxe.SelectedValue.ToString();
            newhd.maNV = cbb_manv.SelectedValue.ToString();
            newhd.manhaCC = cbb_ncc.SelectedValue.ToString();
            newhd.donGia = cbb_dongia.SelectedValue.ToString();
            newhd.slmua = tb_sl.Text;
            newhd.thanhtienhd = (int.Parse(cbb_dongia.SelectedValue.ToString()) * int.Parse(tb_sl.Text)).ToString();
            if (hd.checkTrungMa(newhd.maHD, table) == 1)
            {
                hd.update(newhd, table);
                MessageBox.Show("Sửa thành công!");
                tb_hd.Clear();
                tb_sl.Clear();
                tb_hd.Focus();
                btn_luu.Enabled = false;
                return;
            }
            else
            {
                MessageBox.Show("Hoá đơn cần sửa không tồn tại");
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                tb_hd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cbb_makh.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cbb_maxe.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cbb_manv.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cbb_ncc.SelectedValue = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                tb_sl.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
        }
        
    }
}
