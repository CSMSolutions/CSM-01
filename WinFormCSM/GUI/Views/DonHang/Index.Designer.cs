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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            sideBar1 = new CustomControls.SideBar();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel3 = new Panel();
            label5 = new Label();
            dtGInvoice = new DataGridView();
            panel4 = new Panel();
            btnExport = new Button();
            btnReject = new Button();
            btnApprove = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel2 = new Panel();
            cbStatusInvoice = new ComboBox();
            label4 = new Label();
            dateOrder = new DateTimePicker();
            label3 = new Label();
            txtIdInvoice = new TextBox();
            label2 = new Label();
            toolSearchAndRefresh1 = new CustomControls.ToolSearchAndRefresh();
            searchCustomer1 = new CustomControls.SearchCustomer();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGInvoice).BeginInit();
            panel4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar1
            // 
            sideBar1.Dock = DockStyle.Fill;
            sideBar1.Location = new Point(3, 3);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(201, 999);
            sideBar1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(sideBar1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1419, 1005);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(210, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 830F));
            tableLayoutPanel2.Size = new Size(1215, 999);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 172);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 29.975729F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 70.02427F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1209, 824);
            tableLayoutPanel3.TabIndex = 0;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(panel3, 0, 0);
            tableLayoutPanel6.Controls.Add(dtGInvoice, 0, 1);
            tableLayoutPanel6.Controls.Add(panel4, 0, 2);
            tableLayoutPanel6.Location = new Point(3, 250);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7296133F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 89.2703857F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(1203, 571);
            tableLayoutPanel6.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 40, 45);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1197, 44);
            panel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Unicode MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(461, 0);
            label5.Name = "label5";
            label5.Size = new Size(269, 38);
            label5.TabIndex = 0;
            label5.Text = "Thông tin Hoá đơn";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtGInvoice
            // 
            dtGInvoice.BackgroundColor = Color.White;
            dtGInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGInvoice.Dock = DockStyle.Fill;
            dtGInvoice.Location = new Point(3, 53);
            dtGInvoice.Name = "dtGInvoice";
            dtGInvoice.RowHeadersWidth = 51;
            dtGInvoice.Size = new Size(1197, 410);
            dtGInvoice.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnExport);
            panel4.Controls.Add(btnReject);
            panel4.Controls.Add(btnApprove);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 469);
            panel4.Name = "panel4";
            panel4.Size = new Size(1197, 99);
            panel4.TabIndex = 4;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(253, 202, 2);
            btnExport.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.Black;
            btnExport.Image = (Image)resources.GetObject("btnExport.Image");
            btnExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnExport.Location = new Point(171, 18);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(142, 62);
            btnExport.TabIndex = 2;
            btnExport.Text = "Giao hàng";
            btnExport.TextAlign = ContentAlignment.MiddleRight;
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.FromArgb(192, 16, 18);
            btnReject.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReject.ForeColor = Color.White;
            btnReject.Image = (Image)resources.GetObject("btnReject.Image");
            btnReject.ImageAlign = ContentAlignment.MiddleLeft;
            btnReject.Location = new Point(362, 18);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(135, 67);
            btnReject.TabIndex = 1;
            btnReject.Text = "Từ Chối";
            btnReject.TextAlign = ContentAlignment.MiddleRight;
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.FromArgb(86, 213, 101);
            btnApprove.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApprove.ForeColor = Color.White;
            btnApprove.Image = (Image)resources.GetObject("btnApprove.Image");
            btnApprove.ImageAlign = ContentAlignment.MiddleLeft;
            btnApprove.Location = new Point(13, 16);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(133, 68);
            btnApprove.TabIndex = 0;
            btnApprove.Text = "Xác nhận";
            btnApprove.TextAlign = ContentAlignment.MiddleRight;
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel7.Controls.Add(searchCustomer1, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(1203, 241);
            tableLayoutPanel7.TabIndex = 12;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(panel1, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Location = new Point(604, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 22.8215771F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 77.17842F));
            tableLayoutPanel4.Size = new Size(596, 235);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 40, 45);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 47);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Unicode MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(134, 11);
            label1.Name = "label1";
            label1.Size = new Size(403, 38);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm thông tin đơn hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(panel2, 0, 0);
            tableLayoutPanel5.Controls.Add(toolSearchAndRefresh1, 0, 1);
            tableLayoutPanel5.Location = new Point(3, 56);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(590, 176);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbStatusInvoice);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateOrder);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtIdInvoice);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 82);
            panel2.TabIndex = 0;
            // 
            // cbStatusInvoice
            // 
            cbStatusInvoice.FormattingEnabled = true;
            cbStatusInvoice.Location = new Point(352, 45);
            cbStatusInvoice.Name = "cbStatusInvoice";
            cbStatusInvoice.Size = new Size(213, 28);
            cbStatusInvoice.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(352, 10);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 4;
            label4.Text = "Trạng Thái";
            // 
            // dateOrder
            // 
            dateOrder.Location = new Point(132, 48);
            dateOrder.Name = "dateOrder";
            dateOrder.Size = new Size(203, 27);
            dateOrder.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 48);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 2;
            label3.Text = "Ngày Đặt";
            label3.Click += label3_Click;
            // 
            // txtIdInvoice
            // 
            txtIdInvoice.Location = new Point(132, 10);
            txtIdInvoice.Name = "txtIdInvoice";
            txtIdInvoice.Size = new Size(203, 27);
            txtIdInvoice.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 13);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã Hoá Đơn";
            // 
            // toolSearchAndRefresh1
            // 
            toolSearchAndRefresh1.Dock = DockStyle.Right;
            toolSearchAndRefresh1.Location = new Point(195, 91);
            toolSearchAndRefresh1.Name = "toolSearchAndRefresh1";
            toolSearchAndRefresh1.Size = new Size(392, 82);
            toolSearchAndRefresh1.TabIndex = 1;
            toolSearchAndRefresh1.Load += toolSearchAndRefresh1_Load;
            // 
            // searchCustomer1
            // 
            searchCustomer1.Location = new Point(3, 3);
            searchCustomer1.Name = "searchCustomer1";
            searchCustomer1.Size = new Size(595, 235);
            searchCustomer1.TabIndex = 11;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 1005);
            Controls.Add(tableLayoutPanel1);
            Name = "Index";
            Text = "Index";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGInvoice).EndInit();
            panel4.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.SideBar sideBar1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel2;
        private DateTimePicker dateOrder;
        private Label label3;
        private TextBox txtIdInvoice;
        private Label label2;
        private ComboBox cbStatusInvoice;
        private Label label4;
        private CustomControls.ToolSearchAndRefresh toolSearchAndRefresh1;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel3;
        private Label label5;
        private DataGridView dtGInvoice;
        private Panel panel4;
        private Button btnExport;
        private Button btnReject;
        private Button btnApprove;
        private TableLayoutPanel tableLayoutPanel7;
        private CustomControls.SearchCustomer searchCustomer1;
    }
}