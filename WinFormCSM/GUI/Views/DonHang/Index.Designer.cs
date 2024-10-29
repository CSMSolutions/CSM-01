namespace GUI.Views.DonHang
{
    partial class Index
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
            sideBar1 = new CustomControls.SideBar();
            SuspendLayout();
            // 
            // sideBar1
            // 
            sideBar1.Location = new Point(-2, -25);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(201, 925);
            sideBar1.TabIndex = 0;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 715);
            Controls.Add(sideBar1);
            Name = "Index";
            Text = "Index";
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.SideBar sideBar1;
    }
}