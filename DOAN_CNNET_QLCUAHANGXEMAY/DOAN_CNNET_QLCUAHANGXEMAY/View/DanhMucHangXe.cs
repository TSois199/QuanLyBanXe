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
    public partial class DanhMucHangXe : Form
    {
        DataColumn[] key = new DataColumn[1];
        Control_HangXe hx = new Control_HangXe();
        string table = "HangXe";
        public DanhMucHangXe()
        {
            InitializeComponent();
        }

        void AddHeader()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("MaHang", "Mã Hãng Xe");
            dataGridView1.Columns[0].DataPropertyName = "MaHang";
            dataGridView1.Columns.Add("TenHang", "Tên Hãng Xe");
            dataGridView1.Columns[1].DataPropertyName = "TenHang";

        }

        void loadDTG()
        {
            if (dataGridView1.DataSource != null)
                dataGridView1.Rows.Clear();
            DataTable dtHX = hx.select(table);
            dataGridView1.DataSource = dtHX;
            key[0] = dtHX.Columns[0];
            dtHX.PrimaryKey = key;
        }
        void loadAllHangXe()
        {
            AddHeader();
            loadDTG();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                Model_HangXe newhx = new Model_HangXe();
                newhx.maHang = tb_mahang.Text;
                newhx.tenHang = tb_tenhang.Text;
                if (hx.checkTrungMa(newhx.maHang, table) == 1)
                {
                    MessageBox.Show("Trùng mã hãng xe có từ trước!");
                    return;
                }
                hx.insert(newhx, table);
                MessageBox.Show("Thêm hãng xe thành công rồi nha!");
                tb_mahang.Clear();
                tb_tenhang.Clear();
                tb_mahang.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex != null ? ex.Message : "Lỗi rồi !");
            }
        }

        private void DanhMucHangXe_Load(object sender, EventArgs e)
        {
            loadAllHangXe();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                tb_mahang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tb_tenhang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Model_HangXe newhx = new Model_HangXe();
            newhx.maHang = tb_mahang.Text;
            newhx.tenHang = tb_tenhang.Text;
            if (hx.checkTrungMa(newhx.maHang, table) == 1)
            {
                hx.delete(newhx, table);
                MessageBox.Show("Xóa thành công rồi nha!");
                tb_mahang.Clear();
                tb_tenhang.Clear();
                tb_mahang.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Lỗi rồi nha ");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Model_HangXe newhx = new Model_HangXe();
            newhx.maHang = tb_mahang.Text;
            newhx.tenHang = tb_tenhang.Text;
            if (hx.checkTrungMa(newhx.maHang, table) == 1)
            {

                btn_luu.Enabled = true;

            }
            else
                MessageBox.Show("Chưa có mã hãng xe");
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            Model_HangXe newhx = new Model_HangXe();
            newhx.maHang = tb_mahang.Text;
            newhx.tenHang = tb_tenhang.Text;
            if (hx.checkTrungMa(newhx.maHang, table) == 1)
            {
                hx.update(newhx, table);
                MessageBox.Show("Sửa thành công!");
                tb_mahang.Clear();
                tb_tenhang.Clear();
                tb_mahang.Focus();
                btn_luu.Enabled = false;
                return;
            }
            else
            {
                MessageBox.Show("Mã hãng xe không tồn tại!");
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
                tb_mahang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tb_tenhang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            }
        }
        
        
    }
}
