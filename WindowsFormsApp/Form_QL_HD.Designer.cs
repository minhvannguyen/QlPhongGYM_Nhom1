namespace WindowsFormsApp2
{
    partial class Form_QL_HD
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_in = new System.Windows.Forms.Button();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.bt_tao = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_dshd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(975, 236);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bt_in);
            this.panel1.Controls.Add(this.bt_timkiem);
            this.panel1.Controls.Add(this.bt_tao);
            this.panel1.Controls.Add(this.tb_search);
            this.panel1.Controls.Add(this.bt_xoa);
            this.panel1.Controls.Add(this.bt_dshd);
            this.panel1.Location = new System.Drawing.Point(58, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 42);
            this.panel1.TabIndex = 86;
            // 
            // bt_in
            // 
            this.bt_in.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_in.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bt_in.Location = new System.Drawing.Point(234, -2);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(74, 42);
            this.bt_in.TabIndex = 8;
            this.bt_in.Text = "In HĐ";
            this.bt_in.UseVisualStyleBackColor = false;
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_timkiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_timkiem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bt_timkiem.Location = new System.Drawing.Point(862, 3);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(106, 36);
            this.bt_timkiem.TabIndex = 6;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // bt_tao
            // 
            this.bt_tao.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_tao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bt_tao.Location = new System.Drawing.Point(165, -2);
            this.bt_tao.Name = "bt_tao";
            this.bt_tao.Size = new System.Drawing.Size(70, 42);
            this.bt_tao.TabIndex = 1;
            this.bt_tao.Text = "Tạo";
            this.bt_tao.UseVisualStyleBackColor = false;
            this.bt_tao.Click += new System.EventHandler(this.bt_tao_Click);
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tb_search.Location = new System.Drawing.Point(649, 6);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(207, 26);
            this.tb_search.TabIndex = 4;
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
            // bt_dshd
            // 
            this.bt_dshd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_dshd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bt_dshd.Location = new System.Drawing.Point(-2, -2);
            this.bt_dshd.Name = "bt_dshd";
            this.bt_dshd.Size = new System.Drawing.Size(168, 42);
            this.bt_dshd.TabIndex = 0;
            this.bt_dshd.Text = "Danh sách hoá đơn";
            this.bt_dshd.UseVisualStyleBackColor = false;
            this.bt_dshd.Click += new System.EventHandler(this.bt_dshd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(426, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 85;
            this.label1.Text = "Quản lý hoá đơn";
            // 
            // Form_QL_HD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "Form_QL_HD";
            this.Text = "Form_QL_HD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.Button bt_tao;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_dshd;
        private System.Windows.Forms.Label label1;
    }
}