namespace WindowsFormsApp2
{
    partial class Form_QL_NhanSu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_dsPT = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_dsNhanSu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(371, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản lý nhân sự";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(885, 394);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bt_dsPT);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.bt_dsNhanSu);
            this.panel1.Location = new System.Drawing.Point(42, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 42);
            this.panel1.TabIndex = 9;
            // 
            // bt_dsPT
            // 
            this.bt_dsPT.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_dsPT.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bt_dsPT.Location = new System.Drawing.Point(182, -2);
            this.bt_dsPT.Name = "bt_dsPT";
            this.bt_dsPT.Size = new System.Drawing.Size(132, 42);
            this.bt_dsPT.TabIndex = 7;
            this.bt_dsPT.Text = "Danh sách PT";
            this.bt_dsPT.UseVisualStyleBackColor = false;
            this.bt_dsPT.Click += new System.EventHandler(this.bt_dsPT_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(313, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thêm ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_dsNhanSu
            // 
            this.bt_dsNhanSu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_dsNhanSu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bt_dsNhanSu.Location = new System.Drawing.Point(-2, -2);
            this.bt_dsNhanSu.Name = "bt_dsNhanSu";
            this.bt_dsNhanSu.Size = new System.Drawing.Size(185, 42);
            this.bt_dsNhanSu.TabIndex = 0;
            this.bt_dsNhanSu.Text = "Danh sách nhân sự";
            this.bt_dsNhanSu.UseVisualStyleBackColor = false;
            this.bt_dsNhanSu.Click += new System.EventHandler(this.bt_dsNhanSu_Click);
            // 
            // Form_QL_NhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 607);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_QL_NhanSu";
            this.Text = "Form_QL_NhanSu";
            this.Load += new System.EventHandler(this.Form_QL_NhanSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_dsPT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_dsNhanSu;
    }
}