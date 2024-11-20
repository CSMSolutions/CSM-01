namespace GUI.CustomControls
{
    partial class ToolSearchAndRefresh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolSearchAndRefresh));
            btnRefresh = new Button();
            btnFind = new Button();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(35, 40, 45);
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(158, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 58);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Làm mới";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnFind
            // 
            btnFind.Anchor = AnchorStyles.Right;
            btnFind.BackColor = Color.FromArgb(35, 40, 45);
            btnFind.FlatStyle = FlatStyle.Popup;
            btnFind.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.ForeColor = Color.White;
            btnFind.Image = (Image)resources.GetObject("btnFind.Image");
            btnFind.ImageAlign = ContentAlignment.MiddleLeft;
            btnFind.Location = new Point(12, 4);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(140, 58);
            btnFind.TabIndex = 8;
            btnFind.Text = "TÌm kiếm";
            btnFind.TextAlign = ContentAlignment.MiddleRight;
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFInd_Click;
            // 
            // ToolSearchAndRefresh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefresh);
            Controls.Add(btnFind);
            Name = "ToolSearchAndRefresh";
            Size = new Size(314, 67);
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private Button btnFind;
    }
}
