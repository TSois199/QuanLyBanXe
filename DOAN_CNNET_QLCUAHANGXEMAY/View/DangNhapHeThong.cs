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
namespace DOAN_CNNET_QLCUAHANGXEMAY.View
{
    public partial class DangNhapHeThong : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-IRLS8GIA\SQLEXPRESS;Initial Catalog=QL_Xe_DoAn;Integrated Security=True");
        public static string UserName = "";
        public DangNhapHeThong()
        {
            InitializeComponent();
        }
        int dem = 0;
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DangNhap";
                cmd.Parameters.AddWithValue("@UserName", txt_taikhoan.Text);
                cmd.Parameters.AddWithValue("@Password", txt_matkhau.Text);
                cmd.Connection = conn;
                UserName = txt_taikhoan.Text;
                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                if (code == 1)
                {
                    MessageBox.Show("Chào mừng Nhân viên " + UserName + " đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DOAN_CNNET_QLCUAHANGXEMAY f = new DOAN_CNNET_QLCUAHANGXEMAY();
                    f.Show();
                }
                else if (code == 2)
                {
                    MessageBox.Show("Chào mừng khách hàng " + UserName + " đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DOAN_CNNET_QLCUAHANGXEMAY f = new DOAN_CNNET_QLCUAHANGXEMAY();
                    f.Show();
                }
                else
                {
                    dem++;
                    MessageBox.Show("Bạn đã đăng nhập thất bại");
                    this.txt_taikhoan.Focus();
                    if (dem == 3)
                    {
                        MessageBox.Show("Tài khoản của bạn đã bị khóa");
                        btn_dangnhap.Enabled = false;
                        View.DangNhapThatBai hehe = new View.DangNhapThatBai();
                        hehe.Show();
                        this.Hide();
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DangNhapHeThong_Load(object sender, EventArgs e)
        {
            txt_matkhau.PasswordChar = '*';
        }

        private void chk_show_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_show.Checked)
            {
                txt_matkhau.PasswordChar = (char)0;
            }
            else
            {
                txt_matkhau.PasswordChar = '*';
            }
        }

        private void DangNhapHeThong_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát chương trình không ? ", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
