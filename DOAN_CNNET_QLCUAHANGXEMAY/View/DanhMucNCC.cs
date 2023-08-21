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
    public partial class DanhMucNCC : Form
    {
        DataColumn[] key = new DataColumn[1];
        Control_NCC ncc = new Control_NCC();
        string table = "NHACUNGCAP";
        public DanhMucNCC()
        {
            InitializeComponent();
        }
        void AddHeader()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("MANCC", "Mã Nhà Cung Cấp");
            dataGridView1.Columns[0].DataPropertyName = "MANCC";
            dataGridView1.Columns.Add("TENNCC", "Tên Nhà Cung Cấp");
            dataGridView1.Columns[1].DataPropertyName = "TENNCC";

        }

        void loadDTG()
        {
            if (dataGridView1.DataSource != null)
                dataGridView1.Rows.Clear();
            DataTable dtNCC = ncc.select(table);
            dataGridView1.DataSource = dtNCC;
            key[0] = dtNCC.Columns[0];
            dtNCC.PrimaryKey = key;
        }
        void loadAllNhaCungCap()
        {
            AddHeader();
            loadDTG();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                tb_mancc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tb_tenncc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void DanhMucNCC_Load(object sender, EventArgs e)
        {
            loadAllNhaCungCap();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                tb_mancc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tb_tenncc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            try
            {
                Model_NCC newncc = new Model_NCC();
                newncc.manhaCC = tb_mancc.Text;
                newncc.tennhaCC = tb_tenncc.Text;
                if (ncc.checkTrungMa(newncc.manhaCC, table) == 1)
                {
                    MessageBox.Show("Trùng mã nhà cung cấp có từ trước!");
                    return;
                }
                ncc.insert(newncc, table);
                MessageBox.Show("Thêm nhà cung cấp thành công rồi nha!");
                tb_mancc.Clear();
                tb_tenncc.Clear();
                tb_mancc.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex != null ? ex.Message : "Lỗi rồi !");
            }
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            Model_NCC newncc = new Model_NCC();
            newncc.manhaCC = tb_mancc.Text;
            newncc.tennhaCC = tb_tenncc.Text;
            if (ncc.checkTrungMa(newncc.manhaCC, table) == 1)
            {
                ncc.delete(newncc, table);
                MessageBox.Show("Xóa thành công rồi nha!");
                tb_mancc.Clear();
                tb_tenncc.Clear();
                tb_mancc.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Lỗi rồi nha ");
            }
        }

        private void btn_dong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            Model_NCC newncc = new Model_NCC();
            newncc.manhaCC = tb_mancc.Text;
            newncc.tennhaCC = tb_tenncc.Text;
            if (ncc.checkTrungMa(newncc.manhaCC, table) == 1)
            {

                btn_luu.Enabled = true;

            }
            else
                MessageBox.Show("Nhà cung cấp cần sửa không tồn tại");
        }

        private void btn_luu_Click_1(object sender, EventArgs e)
        {
            Model_NCC newncc = new Model_NCC();
            newncc.manhaCC = tb_mancc.Text;
            newncc.tennhaCC = tb_tenncc.Text;
            if (ncc.checkTrungMa(newncc.manhaCC, table) == 1)
            {
                ncc.update(newncc, table);
                MessageBox.Show("Sửa thành công!");
                tb_mancc.Clear();
                tb_tenncc.Clear();
                tb_mancc.Focus();
                btn_luu.Enabled = false;
                return;
            }
            else
            {
                MessageBox.Show("Nhà cung cấp không tồn tại!");
            }
        }
    }
}
