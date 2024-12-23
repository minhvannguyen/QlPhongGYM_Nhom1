namespace WindowsFormsApp2
{
    partial class Form_LeTan
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
            this.button4 = new System.Windows.Forms.Button();
            this.bt_qlthe = new System.Windows.Forms.Button();
            this.bt_QL_KhoaTap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(435, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lễ tân";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(498, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 83);
            this.button4.TabIndex = 15;
            this.button4.Text = "quản lý hoá đơn";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_qlthe
            // 
            this.bt_qlthe.AutoSize = true;
            this.bt_qlthe.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_qlthe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_qlthe.Location = new System.Drawing.Point(283, 169);
            this.bt_qlthe.Name = "bt_qlthe";
            this.bt_qlthe.Size = new System.Drawing.Size(171, 83);
            this.bt_qlthe.TabIndex = 14;
            this.bt_qlthe.Text = "quản lý ThẻTV";
            this.bt_qlthe.UseVisualStyleBackColor = false;
            this.bt_qlthe.Click += new System.EventHandler(this.bt_qlthe_Click);
            // 
            // bt_QL_KhoaTap
            // 
            this.bt_QL_KhoaTap.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_QL_KhoaTap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_QL_KhoaTap.Location = new System.Drawing.Point(395, 284);
            this.bt_QL_KhoaTap.Name = "bt_QL_KhoaTap";
            this.bt_QL_KhoaTap.Size = new System.Drawing.Size(171, 83);
            this.bt_QL_KhoaTap.TabIndex = 18;
            this.bt_QL_KhoaTap.Text = "quản lý khoá tập";
            this.bt_QL_KhoaTap.UseVisualStyleBackColor = false;
            this.bt_QL_KhoaTap.Click += new System.EventHandler(this.bt_QL_KhoaTap_Click);
            // 
            // Form_LeTan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.bt_QL_KhoaTap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bt_qlthe);
            this.MaximizeBox = false;
            this.Name = "Form_LeTan";
            this.Text = "Form_LeTan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bt_qlthe;
        private System.Windows.Forms.Button bt_QL_KhoaTap;
    }
}