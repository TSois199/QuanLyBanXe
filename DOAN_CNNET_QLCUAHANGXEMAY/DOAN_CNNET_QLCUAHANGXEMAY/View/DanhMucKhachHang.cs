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
    public partial class DanhMucKhachHang : Form
    {
        DataColumn[] key = new DataColumn[1];
        Control_KhachHang x = new Control_KhachHang();
        string table = "KhachHang";
        public DanhMucKhachHang()
        {
            InitializeComponent();
        }
        void AddHeader()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("MaKH", "Mã khách hàng");
            dataGridView1.Columns[0].DataPropertyName = "MaKH";
            dataGridView1.Columns.Add("TenKH", "Tên khách hàng");
            dataGridView1.Columns[1].DataPropertyName = "TenKH";
            dataGridView1.Columns.Add("GioiTinh", "Giới tính");
            dataGridView1.Columns[2].DataPropertyName = "GioiTinh";
            dataGridView1.Columns.Add("NgaySinh", "Ngày sinh");
            dataGridView1.Columns[3].DataPropertyName = "NgaySinh";
            dataGridView1.Columns.Add("MaXe", "Mã xe");
            dataGridView1.Columns[4].DataPropertyName = "MaXe";
            dataGridView1.Columns.Add("NgayMua", "Ngày mua");
            dataGridView1.Columns[5].DataPropertyName = "NgayMua";
            dataGridView1.Columns.Add("HanBH", "Hạn bảo hành");
            dataGridView1.Columns[6].DataPropertyName = "HanBH";
        }

        void loadDTG()
        {
            if (dataGridView1.DataSource != null)
                dataGridView1.Rows.Clear();
            DataTable dtX = x.select(table);
            dataGridView1.DataSource = dtX;
            key[0] = dtX.Columns[0];
            dtX.PrimaryKey = key;
        }

        void loadXe()
        {
            string table = "Xe";
            if (dataGridView1.DataSource != null)
                dataGridView1.Rows.Clear();
            DataTable dt = x.select(table);
            cbb_maxe.DataSource = dt;
            cbb_maxe.DisplayMember = "TenXe";
            cbb_maxe.ValueMember = "MaXe";
        }

        void loadAllKH()
        {
            AddHeader();
            loadDTG();
        }
        private void DanhMucKhachHang_Load(object sender, EventArgs e)
        {
            loadXe();
            loadAllKH();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                Model_KhachHang newx = new Model_KhachHang();
                newx.maKH = tb_makh.Text;
                newx.tenKH = tb_tenkh.Text;
                newx.gioiTinh = cbb_gioitinh.SelectedItem.ToString();
                newx.ngaySinh = dtp_1.Text;
                newx.maXe = cbb_maxe.SelectedValue.ToString();
                newx.ngayMua = dtp_2.Text;
                newx.hanBH = dtp_3.Text;
                newx.matkhaudn = tb_matkhau.Text;
                if (x.checkTrungMa(newx.maKH, table) == 1)
                {
                    MessageBox.Show("Trùng mã khách hàng có từ trước!");
                    tb_makh.Clear();
                    tb_tenkh.Clear();
                    tb_matkhau.Clear();
                    tb_makh.Focus();
                    return;
                }
                x.insert(newx, table);
                MessageBox.Show("Nhập thành công rồi nha!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex != null ? ex.Message : "Lỗi rồi !");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Model_KhachHang newx = new Model_KhachHang();
            newx.maKH = tb_makh.Text;
            if (x.checkTrungMa(newx.maKH, table) == 1)
            {
                x.delete(newx, table);
                MessageBox.Show("Xóa thành công rồi nha!");
                tb_makh.Clear();
                tb_tenkh.Clear();
                tb_matkhau.Clear();
                tb_makh.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Lỗi rồi nha ");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Model_KhachHang newx = new Model_KhachHang();
            newx.maKH = tb_makh.Text;
            if (x.checkTrungMa(newx.maKH, table) == 1)
            {
                btn_luu.Enabled = true;
            }
            else
                MessageBox.Show("Khách hàng cần sửa không tồn tại");
        }
        
        private void btn_luu_Click(object sender, EventArgs e)
        {
            Model_KhachHang newx = new Model_KhachHang();
            newx.maKH = tb_makh.Text;
            newx.tenKH = tb_tenkh.Text;
            newx.gioiTinh = cbb_gioitinh.SelectedItem.ToString();
            newx.ngaySinh = dtp_1.Text;
            newx.maXe = cbb_maxe.SelectedValue.ToString();
            newx.ngayMua = dtp_2.Text;
            newx.hanBH = dtp_3.Text;
            newx.matkhaudn = tb_matkhau.Text;
            if (x.checkTrungMa(newx.maKH, table) == 1)
            {
                x.update(newx, table);
                MessageBox.Show("Sửa thành công!");
                tb_makh.Clear();
                tb_tenkh.Clear();
                tb_matkhau.Clear();
                tb_makh.Focus();
                btn_luu.Enabled = false;
                return;
            }
            else
            {
                MessageBox.Show("Khách hàng cần sửa không tồn tại");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_makh.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_tenkh.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbb_gioitinh.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dtp_1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbb_maxe.SelectedValue = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dtp_2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dtp_3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tb_matkhau.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
