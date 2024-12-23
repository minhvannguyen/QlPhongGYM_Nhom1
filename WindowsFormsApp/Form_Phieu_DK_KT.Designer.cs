namespace WindowsFormsApp2
{
    partial class Form_Phieu_DK_KT
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
            this.tb_khoatapID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_LoaiKT = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_dsPT = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_TaoKT = new System.Windows.Forms.Button();
            this.cb_PTid = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_theTVid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_SoBuoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_hoadon = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_khoatapID
            // 
            this.tb_khoatapID.Location = new System.Drawing.Point(239, 152);
            this.tb_khoatapID.Name = "tb_khoatapID";
            this.tb_khoatapID.Size = new System.Drawing.Size(439, 26);
            this.tb_khoatapID.TabIndex = 157;
            this.tb_khoatapID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_khoatapID_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 156;
            this.label10.Text = "Khoá tập ID: ";
            // 
            // cb_LoaiKT
            // 
            this.cb_LoaiKT.FormattingEnabled = true;
            this.cb_LoaiKT.Location = new System.Drawing.Point(238, 275);
            this.cb_LoaiKT.Name = "cb_LoaiKT";
            this.cb_LoaiKT.Size = new System.Drawing.Size(280, 28);
            this.cb_LoaiKT.TabIndex = 155;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_dsPT);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.bt_TaoKT);
            this.groupBox2.Location = new System.Drawing.Point(756, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 231);
            this.groupBox2.TabIndex = 154;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // bt_dsPT
            // 
            this.bt_dsPT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_dsPT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_dsPT.Location = new System.Drawing.Point(53, 168);
            this.bt_dsPT.Name = "bt_dsPT";
            this.bt_dsPT.Size = new System.Drawing.Size(128, 39);
            this.bt_dsPT.TabIndex = 141;
            this.bt_dsPT.Text = "Xem DS PT";
            this.bt_dsPT.UseVisualStyleBackColor = false;
            this.bt_dsPT.Click += new System.EventHandler(this.bt_dsPT_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(53, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 39);
            this.button2.TabIndex = 140;
            this.button2.Text = "Tạo hoá đơn";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(53, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 39);
            this.button1.TabIndex = 136;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_TaoKT
            // 
            this.bt_TaoKT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_TaoKT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_TaoKT.Location = new System.Drawing.Point(53, 33);
            this.bt_TaoKT.Name = "bt_TaoKT";
            this.bt_TaoKT.Size = new System.Drawing.Size(128, 39);
            this.bt_TaoKT.TabIndex = 131;
            this.bt_TaoKT.Text = "Tạo khoá tập";
            this.bt_TaoKT.UseVisualStyleBackColor = false;
            this.bt_TaoKT.Click += new System.EventHandler(this.bt_TaoKT_Click);
            // 
            // cb_PTid
            // 
            this.cb_PTid.FormattingEnabled = true;
            this.cb_PTid.Location = new System.Drawing.Point(239, 318);
            this.cb_PTid.Name = "cb_PTid";
            this.cb_PTid.Size = new System.Drawing.Size(215, 28);
            this.cb_PTid.TabIndex = 152;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 151;
            this.label9.Text = "Loại khoá tập:";
            // 
            // tb_theTVid
            // 
            this.tb_theTVid.Location = new System.Drawing.Point(239, 193);
            this.tb_theTVid.Name = "tb_theTVid";
            this.tb_theTVid.Size = new System.Drawing.Size(439, 26);
            this.tb_theTVid.TabIndex = 148;
            this.tb_theTVid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_theTVid_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 147;
            this.label6.Text = "TheTV ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 144;
            this.label4.Text = "PT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(346, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 141;
            this.label1.Text = "Phiếu đăng ký khoá tập";
            // 
            // tb_SoBuoi
            // 
            this.tb_SoBuoi.Location = new System.Drawing.Point(238, 362);
            this.tb_SoBuoi.Name = "tb_SoBuoi";
            this.tb_SoBuoi.Size = new System.Drawing.Size(73, 26);
            this.tb_SoBuoi.TabIndex = 159;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 158;
            this.label2.Text = "Tổng số buổi: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 161;
            this.label3.Text = "Hoá đơn ID: ";
            // 
            // tb_hoadon
            // 
            this.tb_hoadon.Location = new System.Drawing.Point(239, 234);
            this.tb_hoadon.Name = "tb_hoadon";
            this.tb_hoadon.Size = new System.Drawing.Size(439, 26);
            this.tb_hoadon.TabIndex = 160;
            this.tb_hoadon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_hoadon_KeyDown);
            // 
            // Form_Phieu_DK_KT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_hoadon);
            this.Controls.Add(this.tb_SoBuoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_khoatapID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_LoaiKT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cb_PTid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_theTVid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_Phieu_DK_KT";
            this.Text = "Form_Phieu_DK_KT";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_khoatapID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_LoaiKT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_TaoKT;
        private System.Windows.Forms.ComboBox cb_PTid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_theTVid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_dsPT;
        private System.Windows.Forms.TextBox tb_SoBuoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_hoadon;
    }
}