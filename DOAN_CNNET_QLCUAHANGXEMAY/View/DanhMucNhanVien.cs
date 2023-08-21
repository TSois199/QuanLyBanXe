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
    public partial class DanhMucNhanVien : Form
    {
        DataColumn[] key = new DataColumn[1];
        Control_NhanVien x = new Control_NhanVien();
        string table = "NhanVien";
        public DanhMucNhanVien()
        {
            InitializeComponent();
        }

        void AddHeader()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("MaNV", "Mã nhân viên");
            dataGridView1.Columns[0].DataPropertyName = "MaNV";
            dataGridView1.Columns.Add("TenNV", "Tên nhân viên");
            dataGridView1.Columns[1].DataPropertyName = "TenNV";
            dataGridView1.Columns.Add("GioiTinh", "Giới tính");
            dataGridView1.Columns[2].DataPropertyName = "GioiTinh";
            dataGridView1.Columns.Add("SDT", "Số điện thoại");
            dataGridView1.Columns[3].DataPropertyName = "SDT";
            dataGridView1.Columns.Add("DiaChi", "Địa chỉ");
            dataGridView1.Columns[4].DataPropertyName = "DiaChi";
            dataGridView1.Columns.Add("ChucVu", "Chức vụ");
            dataGridView1.Columns[5].DataPropertyName = "ChucVu";
            dataGridView1.Columns.Add("MatKhau", "Mật khẩu");
            dataGridView1.Columns[6].DataPropertyName = "MatKhau";
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

        void loadAllNV()
        {
            AddHeader();
            loadDTG();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                Model_NhanVien newx = new Model_NhanVien();
                newx.maNV = tb_ma.Text;
                newx.tenNV = tb_ten.Text;
                newx.gioiTinh = tb_gioitinh.Text;
                newx.sdt = tb_sdt.Text;
                newx.diaChi = tb_diachi.Text;
                newx.chucVu = tb_chucvu.Text;
                newx.matKhau = tb_matkhau.Text;
                if (x.checkTrungMa(newx.maNV, table) == 1)
                {
                    MessageBox.Show("Mã nhân viên có từ trước!");
                    return;
                }
                x.insert(newx, table);
                MessageBox.Show("Thêm nhân viên thành công rồi nha!");
                tb_ma.Clear();
                tb_ten.Clear();
                tb_gioitinh.Clear();
                tb_sdt.Clear();
                tb_diachi.Clear();
                tb_chucvu.Clear();
                tb_matkhau.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex != null ? ex.Message : "Lỗi rồi !");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Model_NhanVien newx = new Model_NhanVien();
            newx.maNV = tb_ma.Text;
            if (x.checkTrungMa(newx.maNV, table) == 1)
            {
                x.delete(newx, table);
                MessageBox.Show("Xóa thành công rồi nha!");
                tb_ma.Clear();
                tb_ten.Clear();
                tb_gioitinh.Clear();
                tb_sdt.Clear();
                tb_diachi.Clear();
                tb_chucvu.Clear();
                tb_matkhau.Clear();
                return;
            }
            else
            {
                MessageBox.Show("Lỗi rồi nha ");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Model_NhanVien newx = new Model_NhanVien();
            newx.maNV = tb_ma.Text;
            if (x.checkTrungMa(newx.maNV, table) == 1)
            {
                btn_luu.Enabled = true;
            }
            else
                MessageBox.Show("Nhân viên cần sửa không tồn tại");
        }

        private void DanhMucNhanVien_Load(object sender, EventArgs e)
        {
            loadAllNV();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            Model_NhanVien newx = new Model_NhanVien();
            newx.maNV = tb_ma.Text;
            newx.tenNV = tb_ten.Text;
            newx.gioiTinh = tb_gioitinh.Text;
            newx.sdt = tb_sdt.Text;
            newx.diaChi = tb_diachi.Text;
            newx.chucVu = tb_chucvu.Text;
            newx.matKhau = tb_matkhau.Text;
            if (x.checkTrungMa(newx.maNV, table) == 1)
            {
                x.update(newx, table);
                MessageBox.Show("Sửa thành công!");
                tb_ma.Clear();
                tb_ten.Clear();
                tb_gioitinh.Clear();
                tb_sdt.Clear();
                tb_diachi.Clear();
                tb_chucvu.Clear();
                tb_matkhau.Clear();
                btn_luu.Enabled = false;
                return;
            }
            else
            {
                MessageBox.Show("Nhân viên cần sửa không tồn tại");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_ma.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_ten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_gioitinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_sdt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_diachi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tb_chucvu.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tb_matkhau.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb_sdt_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (tb_sdt.Text.Length == 10)
                this.errorProvider1.Clear();
            else
                this.errorProvider1.SetError(ctr, "sđt phải đủ 10 số");
        }

        

    }
}
