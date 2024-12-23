namespace WindowsFormsApp2
{
    partial class Form_DK_TK_NhanSu
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
            this.buttonthoat = new System.Windows.Forms.Button();
            this.buttondk = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.labeldktknhansu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_namsinh = new System.Windows.Forms.TextBox();
            this.cb_quyenhan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_nvID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonthoat
            // 
            this.buttonthoat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonthoat.Location = new System.Drawing.Point(737, 487);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(128, 39);
            this.buttonthoat.TabIndex = 111;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = false;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
            // 
            // buttondk
            // 
            this.buttondk.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttondk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttondk.Location = new System.Drawing.Point(399, 487);
            this.buttondk.Name = "buttondk";
            this.buttondk.Size = new System.Drawing.Size(128, 39);
            this.buttondk.TabIndex = 110;
            this.buttondk.Text = "Đăng ký";
            this.buttondk.UseVisualStyleBackColor = false;
            this.buttondk.Click += new System.EventHandler(this.buttondk_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(640, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 109;
            this.label8.Text = "Quyền hạn: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 108;
            this.label7.Text = "Giới tính:";
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(486, 391);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(52, 24);
            this.rb_nu.TabIndex = 107;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "nu";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(399, 391);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(65, 24);
            this.rb_nam.TabIndex = 106;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 105;
            this.label6.Text = "Mật khẩu:";
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(399, 344);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(466, 26);
            this.tb_matkhau.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 99;
            this.label3.Text = "Số điện thoại:";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(399, 300);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(466, 26);
            this.tb_sdt.TabIndex = 98;
            this.tb_sdt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_sdt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 97;
            this.label2.Text = "Địa chỉ:";
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(399, 254);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(466, 26);
            this.tb_diachi.TabIndex = 96;
            this.tb_diachi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_diachi_KeyDown);
            // 
            // labeldktknhansu
            // 
            this.labeldktknhansu.AutoSize = true;
            this.labeldktknhansu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labeldktknhansu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labeldktknhansu.Location = new System.Drawing.Point(351, 9);
            this.labeldktknhansu.Name = "labeldktknhansu";
            this.labeldktknhansu.Size = new System.Drawing.Size(526, 37);
            this.labeldktknhansu.TabIndex = 95;
            this.labeldktknhansu.Text = "ĐĂNG KÝ TÀI KHOẢN NHÂN SỰ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "Năm Sinh:";
            // 
            // tb_namsinh
            // 
            this.tb_namsinh.Location = new System.Drawing.Point(399, 209);
            this.tb_namsinh.Name = "tb_namsinh";
            this.tb_namsinh.Size = new System.Drawing.Size(466, 26);
            this.tb_namsinh.TabIndex = 93;
            this.tb_namsinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_namsinh_KeyDown);
            // 
            // cb_quyenhan
            // 
            this.cb_quyenhan.FormattingEnabled = true;
            this.cb_quyenhan.Location = new System.Drawing.Point(737, 390);
            this.cb_quyenhan.Name = "cb_quyenhan";
            this.cb_quyenhan.Size = new System.Drawing.Size(128, 28);
            this.cb_quyenhan.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 113;
            this.label9.Text = "Họ và Tên:";
            // 
            // tb_hoten
            // 
            this.tb_hoten.Location = new System.Drawing.Point(399, 168);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(466, 26);
            this.tb_hoten.TabIndex = 112;
            this.tb_hoten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_hoten_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 115;
            this.label10.Text = "Nhân viên ID:";
            // 
            // tb_nvID
            // 
            this.tb_nvID.Location = new System.Drawing.Point(399, 124);
            this.tb_nvID.Name = "tb_nvID";
            this.tb_nvID.Size = new System.Drawing.Size(466, 26);
            this.tb_nvID.TabIndex = 114;
            this.tb_nvID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_nvID_KeyDown);
            // 
            // Form_DK_TK_NhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 631);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_nvID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_hoten);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.buttondk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rb_nu);
            this.Controls.Add(this.rb_nam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.labeldktknhansu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_namsinh);
            this.Controls.Add(this.cb_quyenhan);
            this.MaximizeBox = false;
            this.Name = "Form_DK_TK_NhanSu";
            this.Text = "Form_DK_TK_NhanSu";
            this.Load += new System.EventHandler(this.Form_DK_TK_NhanSu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.Button buttondk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.Label labeldktknhansu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_namsinh;
        private System.Windows.Forms.ComboBox cb_quyenhan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_nvID;
    }
}