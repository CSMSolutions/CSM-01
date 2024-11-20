namespace GUI.CustomControls
{
    partial class SearchCustomer
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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            txtNumberPhone = new TextBox();
            txtNameCustomer = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            toolSearchAndRefresh1 = new ToolSearchAndRefresh();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Unicode MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 10);
            label1.Name = "label1";
            label1.Size = new Size(433, 38);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm thông tin khách hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 40, 45);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 50);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 49);
            label2.TabIndex = 2;
            label2.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 49);
            label3.Name = "label3";
            label3.Size = new Size(160, 49);
            label3.TabIndex = 3;
            label3.Text = "Tên Khách Hàng";
            // 
            // txtNumberPhone
            // 
            txtNumberPhone.Dock = DockStyle.Fill;
            txtNumberPhone.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumberPhone.Location = new Point(169, 3);
            txtNumberPhone.Name = "txtNumberPhone";
            txtNumberPhone.Size = new Size(431, 43);
            txtNumberPhone.TabIndex = 4;
            // 
            // txtNameCustomer
            // 
            txtNameCustomer.Dock = DockStyle.Fill;
            txtNameCustomer.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameCustomer.Location = new Point(169, 52);
            txtNameCustomer.Name = "txtNameCustomer";
            txtNameCustomer.Size = new Size(431, 43);
            txtNameCustomer.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.57764F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.42236F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtNumberPhone, 1, 0);
            tableLayoutPanel1.Controls.Add(txtNameCustomer, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(toolSearchAndRefresh1, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 70);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(603, 166);
            tableLayoutPanel1.TabIndex = 7;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // toolSearchAndRefresh1
            // 
            toolSearchAndRefresh1.Dock = DockStyle.Right;
            toolSearchAndRefresh1.Location = new Point(208, 101);
            toolSearchAndRefresh1.Name = "toolSearchAndRefresh1";
            toolSearchAndRefresh1.Size = new Size(392, 62);
            toolSearchAndRefresh1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.3553715F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 82.64463F));
            tableLayoutPanel2.Size = new Size(609, 391);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // SearchCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "SearchCustomer";
            Size = new Size(778, 391);
            Load += SearchCustomer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox txtNumberPhone;
        private TextBox txtNameCustomer;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolSearchAndRefresh toolSearchAndRefresh2;
        private TableLayoutPanel tableLayoutPanel2;
        private ToolSearchAndRefresh toolSearchAndRefresh1;
    }
}
