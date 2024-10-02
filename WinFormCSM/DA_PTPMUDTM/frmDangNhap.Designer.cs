namespace DA_PTPMUDTM
{
    partial class frmDangNhap
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
            this.uC_DangNhap1 = new frm_DangNhap.UC_DangNhap();
            this.SuspendLayout();
            // 
            // uC_DangNhap1
            // 
            this.uC_DangNhap1.AutoSize = true;
            this.uC_DangNhap1.Location = new System.Drawing.Point(34, 1);
            this.uC_DangNhap1.Name = "uC_DangNhap1";
            this.uC_DangNhap1.Size = new System.Drawing.Size(1137, 615);
            this.uC_DangNhap1.TabIndex = 0;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 618);
            this.Controls.Add(this.uC_DangNhap1);
            this.Name = "frmDangNhap";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private frm_DangNhap.UC_DangNhap uC_DangNhap1;
    }
}

