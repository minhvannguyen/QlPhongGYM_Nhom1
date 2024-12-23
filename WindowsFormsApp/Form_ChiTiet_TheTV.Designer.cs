namespace WindowsFormsApp2
{
    partial class Form_ChiTiet_TheTV
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
            this.tb_ngayhethan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_namsinh = new System.Windows.Forms.TextBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_gmail = new System.Windows.Forms.TextBox();
            this.cb_loaiThe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_taohd = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_TheTVID = new System.Windows.Forms.TextBox();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_dk = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_ngaylap = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_hoadon = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ngayhethan
            // 
            this.tb_ngayhethan.Location = new System.Drawing.Point(247, 330);
            this.tb_ngayhethan.Name = "tb_ngayhethan";
            this.tb_ngayhethan.Size = new System.Drawing.Size(190, 26);
            this.tb_ngayhethan.TabIndex = 86;
            this.tb_ngayhethan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ngayhethan_KeyDown);
            this.tb_ngayhethan.Leave += new System.EventHandler(this.tb_ngayhethan_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 85;
            this.label9.Text = "Năm sinh:";
            // 
            // tb_namsinh
            // 
            this.tb_namsinh.Location = new System.Drawing.Point(248, 287);
            this.tb_namsinh.Name = "tb_namsinh";
            this.tb_namsinh.Size = new System.Drawing.Size(192, 26);
            this.tb_namsinh.TabIndex = 84;
            this.tb_namsinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_namsinh_KeyDown);
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_thoat.Location = new System.Drawing.Point(37, 304);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(128, 39);
            this.bt_thoat.TabIndex = 83;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 81;
            this.label8.Text = "Gmail:";
            // 
            // tb_gmail
            // 
            this.tb_gmail.Location = new System.Drawing.Point(247, 245);
            this.tb_gmail.Name = "tb_gmail";
            this.tb_gmail.Size = new System.Drawing.Size(439, 26);
            this.tb_gmail.TabIndex = 80;
            this.tb_gmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_gmail_KeyDown);
            // 
            // cb_loaiThe
            // 
            this.cb_loaiThe.FormattingEnabled = true;
            this.cb_loaiThe.Location = new System.Drawing.Point(555, 373);
            this.cb_loaiThe.Name = "cb_loaiThe";
            this.cb_loaiThe.Size = new System.Drawing.Size(131, 28);
            this.cb_loaiThe.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 78;
            this.label7.Text = "Loại TheTV:";
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(321, 377);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(54, 24);
            this.rb_nu.TabIndex = 77;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(248, 377);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(67, 24);
            this.rb_nam.TabIndex = 76;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(247, 159);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(439, 26);
            this.tb_diachi.TabIndex = 75;
            this.tb_diachi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_diachi_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Địa chỉ:";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(247, 202);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(439, 26);
            this.tb_sdt.TabIndex = 73;
            this.tb_sdt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_sdt_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Ngày hết hạn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Giới tính:";
            // 
            // tb_hoten
            // 
            this.tb_hoten.Location = new System.Drawing.Point(247, 118);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(439, 26);
            this.tb_hoten.TabIndex = 68;
            this.tb_hoten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_hoten_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Họ và Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(401, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 32);
            this.label1.TabIndex = 66;
            this.label1.Text = "Chi tiết thẻ thành viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_taohd);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tb_TheTVID);
            this.groupBox1.Controls.Add(this.bt_reset);
            this.groupBox1.Controls.Add(this.bt_dk);
            this.groupBox1.Controls.Add(this.bt_thoat);
            this.groupBox1.Location = new System.Drawing.Point(819, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 367);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // bt_taohd
            // 
            this.bt_taohd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_taohd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_taohd.Location = new System.Drawing.Point(37, 124);
            this.bt_taohd.Name = "bt_taohd";
            this.bt_taohd.Size = new System.Drawing.Size(128, 39);
            this.bt_taohd.TabIndex = 90;
            this.bt_taohd.Text = "Tạo hoá đơn";
            this.bt_taohd.UseVisualStyleBackColor = false;
            this.bt_taohd.Click += new System.EventHandler(this.bt_taohd_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_xoa.Location = new System.Drawing.Point(37, 259);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(128, 39);
            this.bt_xoa.TabIndex = 89;
            this.bt_xoa.Text = "Xoá";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(109, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 39);
            this.button2.TabIndex = 88;
            this.button2.Text = "sửa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(27, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 39);
            this.button1.TabIndex = 87;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_TheTVID
            // 
            this.tb_TheTVID.Location = new System.Drawing.Point(27, 34);
            this.tb_TheTVID.Name = "tb_TheTVID";
            this.tb_TheTVID.Size = new System.Drawing.Size(148, 26);
            this.tb_TheTVID.TabIndex = 86;
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_reset.Location = new System.Drawing.Point(37, 214);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(128, 39);
            this.bt_reset.TabIndex = 85;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_dk
            // 
            this.bt_dk.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_dk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_dk.Location = new System.Drawing.Point(37, 169);
            this.bt_dk.Name = "bt_dk";
            this.bt_dk.Size = new System.Drawing.Size(128, 39);
            this.bt_dk.TabIndex = 84;
            this.bt_dk.Text = "Đăng ký";
            this.bt_dk.UseVisualStyleBackColor = false;
            this.bt_dk.Click += new System.EventHandler(this.bt_dk_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(443, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 88;
            this.label10.Text = "(YYYY/MM/DD)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(474, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 90;
            this.label11.Text = "Ngày lập:";
            // 
            // tb_ngaylap
            // 
            this.tb_ngaylap.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_ngaylap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ngaylap.Location = new System.Drawing.Point(555, 287);
            this.tb_ngaylap.Name = "tb_ngaylap";
            this.tb_ngaylap.Size = new System.Drawing.Size(192, 19);
            this.tb_ngaylap.TabIndex = 89;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(74, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 163;
            this.label12.Text = "Hoá đơn ID: ";
            // 
            // tb_hoadon
            // 
            this.tb_hoadon.Location = new System.Drawing.Point(247, 420);
            this.tb_hoadon.Name = "tb_hoadon";
            this.tb_hoadon.Size = new System.Drawing.Size(439, 26);
            this.tb_hoadon.TabIndex = 162;
            // 
            // Form_ChiTiet_TheTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 541);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_hoadon);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_ngaylap);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_ngayhethan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_namsinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_gmail);
            this.Controls.Add(this.cb_loaiThe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rb_nu);
            this.Controls.Add(this.rb_nam);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_hoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_ChiTiet_TheTV";
            this.Text = "Form_ChiTiet_TheTV";
            this.Load += new System.EventHandler(this.Form_ChiTiet_TheTV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_ngayhethan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_namsinh;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_gmail;
        private System.Windows.Forms.ComboBox cb_loaiThe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_dk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_TheTVID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_ngaylap;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_taohd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_hoadon;
    }
}