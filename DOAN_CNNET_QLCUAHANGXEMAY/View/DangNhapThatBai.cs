using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_CNNET_QLCUAHANGXEMAY.View
{
    public partial class DangNhapThatBai : Form
    {
        public DangNhapThatBai()
        {
            InitializeComponent();
        }
        int i, n;


        private void DangNhapThatBai_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            i = 100;
            n = i;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = n;
            i--;
            this.label_demlui.Text = "Thời gian còn lại là " + i.ToString() + "Giây";

            if (i >= 0)
            {
                progressBar1.Value = i;
            }
            if (i < 0)
            {
                this.timer1.Enabled = false;
                View.DangNhapHeThong hehe = new View.DangNhapHeThong();
                hehe.Show();
                this.Hide();
            }
        }
    }
}
