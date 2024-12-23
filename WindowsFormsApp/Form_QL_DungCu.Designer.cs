namespace WindowsFormsApp2
{
    partial class Form_QL_DungCu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_dsdungcu = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_dungcuid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tendungcu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tinhtrang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_giatri = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_hoadon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_taohd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(430, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản lý dụng cụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "label4";
            // 
            // bt_dsdungcu
            // 
            this.bt_dsdungcu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_dsdungcu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bt_dsdungcu.Location = new System.Drawing.Point(-2, -2);
            this.bt_dsdungcu.Name = "bt_dsdungcu";
            this.bt_dsdungcu.Size = new System.Drawing.Size(168, 42);
            this.bt_dsdungcu.TabIndex = 0;
            this.bt_dsdungcu.Text = "Danh sách dụng cụ";
            this.bt_dsdungcu.UseVisualStyleBackColor = false;
            this.bt_dsdungcu.Click += new System.EventHandler(this.bt_dsdungcu_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_them.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bt_them.Location = new System.Drawing.Point(165, -2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(70, 42);
            this.bt_them.TabIndex = 1;
            this.bt_them.Text = "Thêm ";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bt_xoa.Location = new System.Drawing.Point(307, -2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(74, 42);
            this.bt_xoa.TabIndex = 3;
            this.bt_xoa.Text = "Xoá";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_sua.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bt_sua.Location = new System.Drawing.Point(234, -2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(74, 42);
            this.bt_sua.TabIndex = 5;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(380, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bt_taohd);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bt_sua);
            this.panel1.Controls.Add(this.bt_xoa);
            this.panel1.Controls.Add(this.bt_them);
            this.panel1.Controls.Add(this.bt_dsdungcu);
            this.panel1.Location = new System.Drawing.Point(40, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 44);
            this.panel1.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(894, 272);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tb_dungcuid
            // 
            this.tb_dungcuid.Location = new System.Drawing.Point(134, 32);
            this.tb_dungcuid.Name = "tb_dungcuid";
            this.tb_dungcuid.Size = new System.Drawing.Size(254, 26);
            this.tb_dungcuid.TabIndex = 22;
            this.tb_dungcuid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_dungcuid_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Dụng cụ ID:";
            // 
            // tb_tendungcu
            // 
            this.tb_tendungcu.Location = new System.Drawing.Point(134, 76);
            this.tb_tendungcu.Name = "tb_tendungcu";
            this.tb_tendungcu.Size = new System.Drawing.Size(254, 26);
            this.tb_tendungcu.TabIndex = 24;
            this.tb_tendungcu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_tendungcu_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên dụng cụ:";
            // 
            // tb_tinhtrang
            // 
            this.tb_tinhtrang.Location = new System.Drawing.Point(134, 116);
            this.tb_tinhtrang.Name = "tb_tinhtrang";
            this.tb_tinhtrang.Size = new System.Drawing.Size(254, 26);
            this.tb_tinhtrang.TabIndex = 26;
            this.tb_tinhtrang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_tinhtrang_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tình trạng:";
            // 
            // tb_giatri
            // 
            this.tb_giatri.Location = new System.Drawing.Point(602, 32);
            this.tb_giatri.Name = "tb_giatri";
            this.tb_giatri.Size = new System.Drawing.Size(254, 26);
            this.tb_giatri.TabIndex = 28;
            this.tb_giatri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_giatri_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Giá trị:";
            // 
            // tb_hoadon
            // 
            this.tb_hoadon.Location = new System.Drawing.Point(602, 73);
            this.tb_hoadon.Name = "tb_hoadon";
            this.tb_hoadon.Size = new System.Drawing.Size(254, 26);
            this.tb_hoadon.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Hoá đơn ID: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_hoadon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_giatri);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_tinhtrang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_tendungcu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_dungcuid);
            this.groupBox1.Location = new System.Drawing.Point(40, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 178);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // bt_taohd
            // 
            this.bt_taohd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_taohd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bt_taohd.Location = new System.Drawing.Point(781, 0);
            this.bt_taohd.Name = "bt_taohd";
            this.bt_taohd.Size = new System.Drawing.Size(111, 42);
            this.bt_taohd.TabIndex = 8;
            this.bt_taohd.Text = "Tạo HĐ";
            this.bt_taohd.UseVisualStyleBackColor = false;
            this.bt_taohd.Click += new System.EventHandler(this.bt_taohd_Click);
            // 
            // Form_QL_DungCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 624);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_QL_DungCu";
            this.Text = "Form_QL_DungCu";
            this.Load += new System.EventHandler(this.Form_QL_DungCu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_dsdungcu;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_dungcuid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tendungcu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tinhtrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_giatri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_hoadon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_taohd;
    }
}