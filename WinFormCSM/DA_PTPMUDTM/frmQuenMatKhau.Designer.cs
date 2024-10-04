namespace DA_PTPMUDTM
{
    partial class frmQuenMatKhau
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
            this.pbMatKhauMoi = new System.Windows.Forms.PictureBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.pbMatKhauCu = new System.Windows.Forms.PictureBox();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.btnLayLaiMK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMatKhauMoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMatKhauCu)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMatKhauMoi
            // 
            this.pbMatKhauMoi.BackColor = System.Drawing.SystemColors.Window;
            this.pbMatKhauMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbMatKhauMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMatKhauMoi.Location = new System.Drawing.Point(785, 363);
            this.pbMatKhauMoi.Name = "pbMatKhauMoi";
            this.pbMatKhauMoi.Size = new System.Drawing.Size(40, 39);
            this.pbMatKhauMoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMatKhauMoi.TabIndex = 26;
            this.pbMatKhauMoi.TabStop = false;
            this.pbMatKhauMoi.Click += new System.EventHandler(this.pbMatKhauMoi_Click);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(423, 363);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(402, 45);
            this.txtMatKhauMoi.TabIndex = 25;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // pbMatKhauCu
            // 
            this.pbMatKhauCu.BackColor = System.Drawing.SystemColors.Window;
            this.pbMatKhauCu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbMatKhauCu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMatKhauCu.Location = new System.Drawing.Point(785, 287);
            this.pbMatKhauCu.Name = "pbMatKhauCu";
            this.pbMatKhauCu.Size = new System.Drawing.Size(40, 39);
            this.pbMatKhauCu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMatKhauCu.TabIndex = 24;
            this.pbMatKhauCu.TabStop = false;
            this.pbMatKhauCu.Click += new System.EventHandler(this.pbMatKhauCu_Click);
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauCu.Location = new System.Drawing.Point(423, 287);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(402, 45);
            this.txtMatKhauCu.TabIndex = 23;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(581, 486);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(150, 55);
            this.btnQuayLai.TabIndex = 22;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(423, 210);
            this.txtTenDN.Multiline = true;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(402, 44);
            this.txtTenDN.TabIndex = 21;
            // 
            // btnLayLaiMK
            // 
            this.btnLayLaiMK.Location = new System.Drawing.Point(407, 486);
            this.btnLayLaiMK.Name = "btnLayLaiMK";
            this.btnLayLaiMK.Size = new System.Drawing.Size(127, 55);
            this.btnLayLaiMK.TabIndex = 20;
            this.btnLayLaiMK.Text = "Gửi";
            this.btnLayLaiMK.UseVisualStyleBackColor = true;
            this.btnLayLaiMK.Click += new System.EventHandler(this.btnLayLaiMK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mật khẩu cũ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lấy Lại Mật Khẩu";
            // 
            // frmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1014, 630);
            this.Controls.Add(this.pbMatKhauMoi);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.pbMatKhauCu);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.btnLayLaiMK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmQuenMatKhau";
            this.Text = "frmQuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.pbMatKhauMoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMatKhauCu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.PictureBox pbMatKhauCu;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Button btnLayLaiMK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}