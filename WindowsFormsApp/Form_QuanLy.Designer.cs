namespace WindowsFormsApp2
{
    partial class Form_QuanLy
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
            this.bt_QL_DungCu = new System.Windows.Forms.Button();
            this.bt_LeTan = new System.Windows.Forms.Button();
            this.bt_QL_NhanSu = new System.Windows.Forms.Button();
            this.bt_QL_KhoaTap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Quản lý";
            // 
            // bt_QL_DungCu
            // 
            this.bt_QL_DungCu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_QL_DungCu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_QL_DungCu.Location = new System.Drawing.Point(158, 221);
            this.bt_QL_DungCu.Name = "bt_QL_DungCu";
            this.bt_QL_DungCu.Size = new System.Drawing.Size(171, 83);
            this.bt_QL_DungCu.TabIndex = 11;
            this.bt_QL_DungCu.Text = "quản lý dụng cụ";
            this.bt_QL_DungCu.UseVisualStyleBackColor = false;
            this.bt_QL_DungCu.Click += new System.EventHandler(this.bt_QL_DungCu_Click);
            // 
            // bt_LeTan
            // 
            this.bt_LeTan.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_LeTan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_LeTan.Location = new System.Drawing.Point(331, 340);
            this.bt_LeTan.Name = "bt_LeTan";
            this.bt_LeTan.Size = new System.Drawing.Size(171, 83);
            this.bt_LeTan.TabIndex = 8;
            this.bt_LeTan.Text = "Lễ tân - quản lý khách";
            this.bt_LeTan.UseVisualStyleBackColor = false;
            this.bt_LeTan.Click += new System.EventHandler(this.bt_LeTan_Click);
            // 
            // bt_QL_NhanSu
            // 
            this.bt_QL_NhanSu.AutoSize = true;
            this.bt_QL_NhanSu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_QL_NhanSu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_QL_NhanSu.Location = new System.Drawing.Point(331, 105);
            this.bt_QL_NhanSu.Name = "bt_QL_NhanSu";
            this.bt_QL_NhanSu.Size = new System.Drawing.Size(171, 83);
            this.bt_QL_NhanSu.TabIndex = 7;
            this.bt_QL_NhanSu.Text = "quản lý nhân sự";
            this.bt_QL_NhanSu.UseVisualStyleBackColor = false;
            this.bt_QL_NhanSu.Click += new System.EventHandler(this.bt_QL_NhanSu_Click);
            // 
            // bt_QL_KhoaTap
            // 
            this.bt_QL_KhoaTap.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_QL_KhoaTap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_QL_KhoaTap.Location = new System.Drawing.Point(509, 221);
            this.bt_QL_KhoaTap.Name = "bt_QL_KhoaTap";
            this.bt_QL_KhoaTap.Size = new System.Drawing.Size(171, 83);
            this.bt_QL_KhoaTap.TabIndex = 10;
            this.bt_QL_KhoaTap.Text = "quản lý khoá tập";
            this.bt_QL_KhoaTap.UseVisualStyleBackColor = false;
            this.bt_QL_KhoaTap.Click += new System.EventHandler(this.bt_QL_KhoaTap_Click);
            // 
            // Form_QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_QL_DungCu);
            this.Controls.Add(this.bt_QL_KhoaTap);
            this.Controls.Add(this.bt_LeTan);
            this.Controls.Add(this.bt_QL_NhanSu);
            this.MaximizeBox = false;
            this.Name = "Form_QuanLy";
            this.Text = "Form_QuanLy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_QL_DungCu;
        private System.Windows.Forms.Button bt_LeTan;
        private System.Windows.Forms.Button bt_QL_NhanSu;
        private System.Windows.Forms.Button bt_QL_KhoaTap;
    }
}