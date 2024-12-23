namespace WindowsFormsApp2
{
    partial class Form_ChiTietKTcs
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
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_DanhGia = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.bt_hienthi = new System.Windows.Forms.Button();
            this.dgv_LichTrinh = new System.Windows.Forms.DataGridView();
            this.tb_Gmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_HoaDonID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_TongSo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_HoTenPT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_TheTV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_PTID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_LoaiKT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_HoTenKhach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_KhoaTapID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_nvID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichTrinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(457, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 25);
            this.label12.TabIndex = 135;
            this.label12.Text = "Lịch trình";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bt_DanhGia);
            this.groupBox1.Controls.Add(this.bt_Xoa);
            this.groupBox1.Controls.Add(this.bt_Luu);
            this.groupBox1.Location = new System.Drawing.Point(887, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 238);
            this.groupBox1.TabIndex = 134;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(33, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tạo HĐ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_DanhGia
            // 
            this.bt_DanhGia.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_DanhGia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_DanhGia.Location = new System.Drawing.Point(33, 183);
            this.bt_DanhGia.Name = "bt_DanhGia";
            this.bt_DanhGia.Size = new System.Drawing.Size(95, 42);
            this.bt_DanhGia.TabIndex = 7;
            this.bt_DanhGia.Text = "Đánh giá";
            this.bt_DanhGia.UseVisualStyleBackColor = false;
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Xoa.Location = new System.Drawing.Point(33, 135);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(95, 42);
            this.bt_Xoa.TabIndex = 6;
            this.bt_Xoa.Text = "Xoá";
            this.bt_Xoa.UseVisualStyleBackColor = false;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Luu
            // 
            this.bt_Luu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Luu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Luu.Location = new System.Drawing.Point(33, 87);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(95, 42);
            this.bt_Luu.TabIndex = 5;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = false;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_hienthi
            // 
            this.bt_hienthi.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_hienthi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_hienthi.Location = new System.Drawing.Point(364, 55);
            this.bt_hienthi.Name = "bt_hienthi";
            this.bt_hienthi.Size = new System.Drawing.Size(77, 32);
            this.bt_hienthi.TabIndex = 8;
            this.bt_hienthi.Text = "Tìm";
            this.bt_hienthi.UseVisualStyleBackColor = false;
            this.bt_hienthi.Click += new System.EventHandler(this.bt_hienthi_Click);
            // 
            // dgv_LichTrinh
            // 
            this.dgv_LichTrinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LichTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LichTrinh.Location = new System.Drawing.Point(21, 300);
            this.dgv_LichTrinh.Name = "dgv_LichTrinh";
            this.dgv_LichTrinh.RowHeadersWidth = 62;
            this.dgv_LichTrinh.RowTemplate.Height = 28;
            this.dgv_LichTrinh.Size = new System.Drawing.Size(1023, 277);
            this.dgv_LichTrinh.TabIndex = 133;
            this.dgv_LichTrinh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_LichTrinh_MouseClick);
            // 
            // tb_Gmail
            // 
            this.tb_Gmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Gmail.Location = new System.Drawing.Point(630, 156);
            this.tb_Gmail.Name = "tb_Gmail";
            this.tb_Gmail.Size = new System.Drawing.Size(219, 19);
            this.tb_Gmail.TabIndex = 132;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(478, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 131;
            this.label11.Text = "Gmail Khách:";
            // 
            // tb_sdt
            // 
            this.tb_sdt.BackColor = System.Drawing.SystemColors.Window;
            this.tb_sdt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_sdt.Location = new System.Drawing.Point(628, 58);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(221, 19);
            this.tb_sdt.TabIndex = 130;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 129;
            this.label6.Text = "SĐT khách:";
            // 
            // tb_HoaDonID
            // 
            this.tb_HoaDonID.BackColor = System.Drawing.SystemColors.Window;
            this.tb_HoaDonID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_HoaDonID.Location = new System.Drawing.Point(146, 157);
            this.tb_HoaDonID.Name = "tb_HoaDonID";
            this.tb_HoaDonID.Size = new System.Drawing.Size(221, 19);
            this.tb_HoaDonID.TabIndex = 128;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 127;
            this.label5.Text = "Hoá đơn ID:";
            // 
            // tb_TongSo
            // 
            this.tb_TongSo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TongSo.Location = new System.Drawing.Point(630, 191);
            this.tb_TongSo.Name = "tb_TongSo";
            this.tb_TongSo.Size = new System.Drawing.Size(50, 19);
            this.tb_TongSo.TabIndex = 126;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 125;
            this.label4.Text = "Tổng số buổi:";
            // 
            // tb_HoTenPT
            // 
            this.tb_HoTenPT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_HoTenPT.Location = new System.Drawing.Point(630, 122);
            this.tb_HoTenPT.Name = "tb_HoTenPT";
            this.tb_HoTenPT.Size = new System.Drawing.Size(219, 19);
            this.tb_HoTenPT.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 123;
            this.label3.Text = "Họ tên PT:";
            // 
            // tb_TheTV
            // 
            this.tb_TheTV.BackColor = System.Drawing.SystemColors.Window;
            this.tb_TheTV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TheTV.Location = new System.Drawing.Point(146, 93);
            this.tb_TheTV.Name = "tb_TheTV";
            this.tb_TheTV.Size = new System.Drawing.Size(221, 19);
            this.tb_TheTV.TabIndex = 122;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 121;
            this.label10.Text = "Thẻ TV ID:";
            // 
            // tb_PTID
            // 
            this.tb_PTID.BackColor = System.Drawing.SystemColors.Window;
            this.tb_PTID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_PTID.Location = new System.Drawing.Point(146, 125);
            this.tb_PTID.Name = "tb_PTID";
            this.tb_PTID.Size = new System.Drawing.Size(221, 19);
            this.tb_PTID.TabIndex = 120;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 119;
            this.label9.Text = "PT ID:";
            // 
            // tb_LoaiKT
            // 
            this.tb_LoaiKT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_LoaiKT.Location = new System.Drawing.Point(146, 188);
            this.tb_LoaiKT.Name = "tb_LoaiKT";
            this.tb_LoaiKT.Size = new System.Drawing.Size(219, 19);
            this.tb_LoaiKT.TabIndex = 118;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 117;
            this.label8.Text = "Loại Khoá tập:";
            // 
            // tb_HoTenKhach
            // 
            this.tb_HoTenKhach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_HoTenKhach.Location = new System.Drawing.Point(630, 90);
            this.tb_HoTenKhach.Name = "tb_HoTenKhach";
            this.tb_HoTenKhach.Size = new System.Drawing.Size(219, 19);
            this.tb_HoTenKhach.TabIndex = 116;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 115;
            this.label7.Text = "Họ tên khách:";
            // 
            // tb_KhoaTapID
            // 
            this.tb_KhoaTapID.BackColor = System.Drawing.SystemColors.Window;
            this.tb_KhoaTapID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_KhoaTapID.Location = new System.Drawing.Point(146, 61);
            this.tb_KhoaTapID.Name = "tb_KhoaTapID";
            this.tb_KhoaTapID.Size = new System.Drawing.Size(221, 19);
            this.tb_KhoaTapID.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 113;
            this.label2.Text = "Khoá tập ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(404, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 112;
            this.label1.Text = "Chi tiết khoá tập";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(478, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 20);
            this.label13.TabIndex = 116;
            this.label13.Text = "NhanVienID Phiên:";
            // 
            // tb_nvID
            // 
            this.tb_nvID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nvID.ForeColor = System.Drawing.Color.Black;
            this.tb_nvID.Location = new System.Drawing.Point(630, 226);
            this.tb_nvID.Name = "tb_nvID";
            this.tb_nvID.ReadOnly = true;
            this.tb_nvID.Size = new System.Drawing.Size(148, 19);
            this.tb_nvID.TabIndex = 117;
            // 
            // Form_ChiTietKTcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 599);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_nvID);
            this.Controls.Add(this.bt_hienthi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_LichTrinh);
            this.Controls.Add(this.tb_Gmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_HoaDonID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_TongSo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_HoTenPT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_TheTV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_PTID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_LoaiKT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_HoTenKhach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_KhoaTapID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_ChiTietKTcs";
            this.Text = "Form_ChiTietKTcs";
            this.Load += new System.EventHandler(this.Form_ChiTietKTcs_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichTrinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_DanhGia;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.DataGridView dgv_LichTrinh;
        private System.Windows.Forms.TextBox tb_Gmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_HoaDonID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_TongSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_HoTenPT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_TheTV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_PTID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_LoaiKT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_HoTenKhach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_KhoaTapID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_hienthi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_nvID;
    }
}