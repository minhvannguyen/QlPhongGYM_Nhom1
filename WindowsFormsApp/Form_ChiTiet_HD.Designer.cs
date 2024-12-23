namespace WindowsFormsApp2
{
    partial class Form_ChiTiet_HD
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
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_hoadon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_in = new System.Windows.Forms.Button();
            this.bt_xuat = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.cb_LoaiHĐ = new System.Windows.Forms.ComboBox();
            this.cb_KieuThanhToan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_NgayLap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Gia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_km = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nvID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_qlhd = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nv = new System.Windows.Forms.TextBox();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_search);
            this.groupBox2.Controls.Add(this.tb_hoadon);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(499, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 159);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_search.Location = new System.Drawing.Point(63, 97);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(105, 36);
            this.bt_search.TabIndex = 6;
            this.bt_search.Text = "Tìm kiếm";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // tb_hoadon
            // 
            this.tb_hoadon.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tb_hoadon.Location = new System.Drawing.Point(26, 59);
            this.tb_hoadon.Name = "tb_hoadon";
            this.tb_hoadon.Size = new System.Drawing.Size(175, 26);
            this.tb_hoadon.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(24, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Hoá đơn ID:";
            // 
            // bt_in
            // 
            this.bt_in.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_in.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_in.Location = new System.Drawing.Point(128, 432);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(105, 36);
            this.bt_in.TabIndex = 4;
            this.bt_in.Text = "In hoá đơn";
            this.bt_in.UseVisualStyleBackColor = false;
            // 
            // bt_xuat
            // 
            this.bt_xuat.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_xuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_xuat.Location = new System.Drawing.Point(378, 432);
            this.bt_xuat.Name = "bt_xuat";
            this.bt_xuat.Size = new System.Drawing.Size(105, 36);
            this.bt_xuat.TabIndex = 3;
            this.bt_xuat.Text = "Xuất";
            this.bt_xuat.UseVisualStyleBackColor = false;
            this.bt_xuat.Click += new System.EventHandler(this.bt_xuat_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_xoa.Location = new System.Drawing.Point(604, 432);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(105, 36);
            this.bt_xoa.TabIndex = 2;
            this.bt_xoa.Text = "Xoá";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // cb_LoaiHĐ
            // 
            this.cb_LoaiHĐ.FormattingEnabled = true;
            this.cb_LoaiHĐ.Location = new System.Drawing.Point(269, 144);
            this.cb_LoaiHĐ.Name = "cb_LoaiHĐ";
            this.cb_LoaiHĐ.Size = new System.Drawing.Size(148, 28);
            this.cb_LoaiHĐ.TabIndex = 100;
            // 
            // cb_KieuThanhToan
            // 
            this.cb_KieuThanhToan.FormattingEnabled = true;
            this.cb_KieuThanhToan.Location = new System.Drawing.Point(269, 190);
            this.cb_KieuThanhToan.Name = "cb_KieuThanhToan";
            this.cb_KieuThanhToan.Size = new System.Drawing.Size(148, 28);
            this.cb_KieuThanhToan.TabIndex = 99;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 98;
            this.label7.Text = "Kiểu thanh toán:";
            // 
            // tb_NgayLap
            // 
            this.tb_NgayLap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_NgayLap.Location = new System.Drawing.Point(651, 283);
            this.tb_NgayLap.Name = "tb_NgayLap";
            this.tb_NgayLap.Size = new System.Drawing.Size(148, 19);
            this.tb_NgayLap.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 94;
            this.label5.Text = "Ngày lập:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 88;
            this.label9.Text = "Loại Hoá đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(441, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 104;
            this.label1.Text = "Hoá đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 110;
            this.label10.Text = "Giá tiền:";
            // 
            // tb_Gia
            // 
            this.tb_Gia.Location = new System.Drawing.Point(269, 276);
            this.tb_Gia.Name = "tb_Gia";
            this.tb_Gia.Size = new System.Drawing.Size(148, 26);
            this.tb_Gia.TabIndex = 111;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 112;
            this.label8.Text = "Khuyến mãi:";
            // 
            // tb_km
            // 
            this.tb_km.Location = new System.Drawing.Point(269, 233);
            this.tb_km.Name = "tb_km";
            this.tb_km.Size = new System.Drawing.Size(148, 26);
            this.tb_km.TabIndex = 113;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 114;
            this.label3.Text = "NhanVienID Phiên:";
            // 
            // tb_nvID
            // 
            this.tb_nvID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nvID.ForeColor = System.Drawing.Color.Black;
            this.tb_nvID.Location = new System.Drawing.Point(651, 327);
            this.tb_nvID.Name = "tb_nvID";
            this.tb_nvID.ReadOnly = true;
            this.tb_nvID.Size = new System.Drawing.Size(148, 19);
            this.tb_nvID.TabIndex = 115;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_quaylai);
            this.groupBox1.Controls.Add(this.bt_reset);
            this.groupBox1.Controls.Add(this.bt_qlhd);
            this.groupBox1.Location = new System.Drawing.Point(798, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 181);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bt_qlhd
            // 
            this.bt_qlhd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_qlhd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_qlhd.Location = new System.Drawing.Point(25, 44);
            this.bt_qlhd.Name = "bt_qlhd";
            this.bt_qlhd.Size = new System.Drawing.Size(105, 36);
            this.bt_qlhd.TabIndex = 68;
            this.bt_qlhd.Text = "Quản lí HĐ";
            this.bt_qlhd.UseVisualStyleBackColor = false;
            this.bt_qlhd.Click += new System.EventHandler(this.bt_qlhd_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_reset.Location = new System.Drawing.Point(25, 90);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(105, 36);
            this.bt_reset.TabIndex = 69;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 117;
            this.label4.Text = "ID nhân viên:";
            // 
            // tb_nv
            // 
            this.tb_nv.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_nv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nv.Location = new System.Drawing.Point(269, 98);
            this.tb_nv.Name = "tb_nv";
            this.tb_nv.Size = new System.Drawing.Size(148, 19);
            this.tb_nv.TabIndex = 118;
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_quaylai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_quaylai.Location = new System.Drawing.Point(25, 139);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(105, 36);
            this.bt_quaylai.TabIndex = 70;
            this.bt_quaylai.Text = "Quay lại";
            this.bt_quaylai.UseVisualStyleBackColor = false;
            // 
            // Form_ChiTiet_HD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_nv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nvID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_km);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_Gia);
            this.Controls.Add(this.bt_in);
            this.Controls.Add(this.bt_xuat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.cb_LoaiHĐ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_KieuThanhToan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_NgayLap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.MaximizeBox = false;
            this.Name = "Form_ChiTiet_HD";
            this.Text = "Form_ChiTiet_HD";
            this.TransparencyKey = System.Drawing.SystemColors.ControlLight;
            this.Load += new System.EventHandler(this.Form_ChiTiet_HD_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.TextBox tb_hoadon;
        private System.Windows.Forms.Button bt_xuat;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.ComboBox cb_LoaiHĐ;
        private System.Windows.Forms.ComboBox cb_KieuThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_NgayLap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_Gia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_km;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nvID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_qlhd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nv;
        private System.Windows.Forms.Button bt_quaylai;
    }
}