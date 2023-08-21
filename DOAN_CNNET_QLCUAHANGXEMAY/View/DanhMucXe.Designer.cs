namespace DOAN_CNNET_QLCUAHANGXEMAY
{
    partial class DanhMucXe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbb_mausac = new System.Windows.Forms.ComboBox();
            this.cbb_tenhang = new System.Windows.Forms.ComboBox();
            this.cbb_loaixe = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_phankhoi = new System.Windows.Forms.TextBox();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_tenxe = new System.Windows.Forms.TextBox();
            this.tb_maxe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(456, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 489);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục hãng xe";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(10, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 453);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_date);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbb_mausac);
            this.groupBox1.Controls.Add(this.cbb_tenhang);
            this.groupBox1.Controls.Add(this.cbb_loaixe);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_phankhoi);
            this.groupBox1.Controls.Add(this.tb_dongia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_tenxe);
            this.groupBox1.Controls.Add(this.tb_maxe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 488);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hãng xe";
            // 
            // dtp_date
            // 
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(128, 341);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(281, 30);
            this.dtp_date.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ngày nhập:";
            // 
            // cbb_mausac
            // 
            this.cbb_mausac.FormattingEnabled = true;
            this.cbb_mausac.Items.AddRange(new object[] {
            "Đỏ",
            "Xanh bạc",
            "Đỏ đen",
            "Xanh xám",
            "Trắng",
            "Hồng đen",
            "Bạc",
            "Xám nâu",
            "Tím",
            "Trắng loang xanh"});
            this.cbb_mausac.Location = new System.Drawing.Point(128, 450);
            this.cbb_mausac.Name = "cbb_mausac";
            this.cbb_mausac.Size = new System.Drawing.Size(281, 31);
            this.cbb_mausac.TabIndex = 15;
            // 
            // cbb_tenhang
            // 
            this.cbb_tenhang.FormattingEnabled = true;
            this.cbb_tenhang.Location = new System.Drawing.Point(128, 231);
            this.cbb_tenhang.Name = "cbb_tenhang";
            this.cbb_tenhang.Size = new System.Drawing.Size(281, 31);
            this.cbb_tenhang.TabIndex = 14;
            // 
            // cbb_loaixe
            // 
            this.cbb_loaixe.FormattingEnabled = true;
            this.cbb_loaixe.Items.AddRange(new object[] {
            "Xe số (côn tự động)",
            "Xe số (côn tay)",
            "Xe tay ga"});
            this.cbb_loaixe.Location = new System.Drawing.Point(128, 169);
            this.cbb_loaixe.Name = "cbb_loaixe";
            this.cbb_loaixe.Size = new System.Drawing.Size(281, 31);
            this.cbb_loaixe.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Màu sắc :";
            // 
            // tb_phankhoi
            // 
            this.tb_phankhoi.Location = new System.Drawing.Point(128, 382);
            this.tb_phankhoi.Multiline = true;
            this.tb_phankhoi.Name = "tb_phankhoi";
            this.tb_phankhoi.Size = new System.Drawing.Size(281, 44);
            this.tb_phankhoi.TabIndex = 11;
            // 
            // tb_dongia
            // 
            this.tb_dongia.Location = new System.Drawing.Point(128, 291);
            this.tb_dongia.Multiline = true;
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Size = new System.Drawing.Size(281, 44);
            this.tb_dongia.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phân khối :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Đơn giá :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên hãng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại xe :";
            // 
            // tb_tenxe
            // 
            this.tb_tenxe.Location = new System.Drawing.Point(128, 101);
            this.tb_tenxe.Multiline = true;
            this.tb_tenxe.Name = "tb_tenxe";
            this.tb_tenxe.Size = new System.Drawing.Size(281, 44);
            this.tb_tenxe.TabIndex = 3;
            // 
            // tb_maxe
            // 
            this.tb_maxe.Location = new System.Drawing.Point(128, 39);
            this.tb_maxe.Multiline = true;
            this.tb_maxe.Name = "tb_maxe";
            this.tb_maxe.Size = new System.Drawing.Size(281, 44);
            this.tb_maxe.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên xe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã xe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 52);
            this.label3.TabIndex = 17;
            this.label3.Text = "QUẢN LÝ XE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_luu);
            this.groupBox3.Controls.Add(this.btn_dong);
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 589);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(611, 117);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btn_luu
            // 
            this.btn_luu.Enabled = false;
            this.btn_luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Image = global::DOAN_CNNET_QLCUAHANGXEMAY.Properties.Resources.save2;
            this.btn_luu.Location = new System.Drawing.Point(378, 29);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(93, 75);
            this.btn_luu.TabIndex = 21;
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong.Image = global::DOAN_CNNET_QLCUAHANGXEMAY.Properties.Resources.close3;
            this.btn_dong.Location = new System.Drawing.Point(496, 29);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(93, 75);
            this.btn_dong.TabIndex = 20;
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::DOAN_CNNET_QLCUAHANGXEMAY.Properties.Resources.delete2;
            this.btn_xoa.Location = new System.Drawing.Point(256, 29);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(93, 75);
            this.btn_xoa.TabIndex = 19;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Image = global::DOAN_CNNET_QLCUAHANGXEMAY.Properties.Resources.add8;
            this.btn_them.Location = new System.Drawing.Point(16, 29);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(93, 75);
            this.btn_them.TabIndex = 15;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::DOAN_CNNET_QLCUAHANGXEMAY.Properties.Resources.edit2;
            this.btn_sua.Location = new System.Drawing.Point(137, 29);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(93, 75);
            this.btn_sua.TabIndex = 18;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // DanhMucXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1168, 718);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DanhMucXe";
            this.Text = "DanhMucXe";
            this.Load += new System.EventHandler(this.DanhMucXe_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_tenxe;
        private System.Windows.Forms.TextBox tb_maxe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbb_mausac;
        private System.Windows.Forms.ComboBox cbb_tenhang;
        private System.Windows.Forms.ComboBox cbb_loaixe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_phankhoi;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label9;
    }
}