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
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel3 = new Panel();
            label5 = new Label();
            dtGInvoice = new DataGridView();
            panel4 = new Panel();
            button1 = new Button();
            btnExport = new Button();
            btnReject = new Button();
            btnApprove = new Button();
            tableLayoutPanel9 = new TableLayoutPanel();
            panel5 = new Panel();
            label6 = new Label();
            dtGDetaiInvoices = new DataGridView();
            panel6 = new Panel();
            txtTotal = new TextBox();
            txtPaymentStatus = new TextBox();
            txtPaymentMethod = new TextBox();
            txtAddress = new RichTextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label12 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGInvoice).BeginInit();
            panel4.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGDetaiInvoices).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar1
            // 
            sideBar1.Dock = DockStyle.Fill;
            sideBar1.Location = new Point(3, 3);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(201, 828);
            sideBar1.TabIndex = 0;
            sideBar1.Load += sideBar1_Load;
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
            tableLayoutPanel1.Size = new Size(1527, 834);
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
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 829F));
            tableLayoutPanel2.Size = new Size(1314, 828);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 29.975729F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 70.02427F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1308, 823);
            tableLayoutPanel3.TabIndex = 0;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
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
            tableLayoutPanel7.Size = new Size(1302, 240);
            tableLayoutPanel7.TabIndex = 12;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(panel1, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(654, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 22.8215771F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 77.17842F));
            tableLayoutPanel4.Size = new Size(645, 234);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 40, 45);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 47);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Unicode MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(159, 11);
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
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 56);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(639, 175);
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
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(633, 81);
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
            label4.Location = new Point(352, 11);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 4;
            label4.Text = "Trạng Thái";
            // 
            // dateOrder
            // 
            dateOrder.Location = new Point(133, 48);
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
            txtIdInvoice.Location = new Point(133, 11);
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
            toolSearchAndRefresh1.Location = new Point(244, 90);
            toolSearchAndRefresh1.Name = "toolSearchAndRefresh1";
            toolSearchAndRefresh1.Size = new Size(392, 82);
            toolSearchAndRefresh1.TabIndex = 1;
            toolSearchAndRefresh1.Load += toolSearchAndRefresh1_Load;
            // 
            // searchCustomer1
            // 
            searchCustomer1.Dock = DockStyle.Fill;
            searchCustomer1.Location = new Point(3, 3);
            searchCustomer1.Name = "searchCustomer1";
            searchCustomer1.Size = new Size(645, 234);
            searchCustomer1.TabIndex = 11;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.9359932F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.0640068F));
            tableLayoutPanel8.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel9, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 249);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(1302, 571);
            tableLayoutPanel8.TabIndex = 13;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(panel3, 0, 0);
            tableLayoutPanel6.Controls.Add(dtGInvoice, 0, 1);
            tableLayoutPanel6.Controls.Add(panel4, 0, 2);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7296133F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 89.2703857F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(761, 565);
            tableLayoutPanel6.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 40, 45);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(755, 43);
            panel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Unicode MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(239, 0);
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
            dtGInvoice.Location = new Point(3, 52);
            dtGInvoice.Name = "dtGInvoice";
            dtGInvoice.RowHeadersWidth = 51;
            dtGInvoice.Size = new Size(755, 405);
            dtGInvoice.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(btnExport);
            panel4.Controls.Add(btnReject);
            panel4.Controls.Add(btnApprove);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 463);
            panel4.Name = "panel4";
            panel4.Size = new Size(755, 99);
            panel4.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(484, 23);
            button1.Name = "button1";
            button1.Size = new Size(145, 55);
            button1.TabIndex = 3;
            button1.Text = "Xuất File";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(253, 202, 2);
            btnExport.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.Black;
            btnExport.Image = (Image)resources.GetObject("btnExport.Image");
            btnExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnExport.Location = new Point(171, 19);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(142, 61);
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
            btnReject.Location = new Point(345, 19);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(118, 61);
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
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(panel5, 0, 0);
            tableLayoutPanel9.Controls.Add(dtGDetaiInvoices, 0, 2);
            tableLayoutPanel9.Controls.Add(panel6, 0, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(770, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 3;
            tableLayoutPanel9.RowStyles.Add(new RowStyle());
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 293F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 1873F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(529, 565);
            tableLayoutPanel9.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(35, 40, 45);
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(523, 43);
            panel5.TabIndex = 3;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Unicode MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(116, 0);
            label6.Name = "label6";
            label6.Size = new Size(364, 38);
            label6.TabIndex = 0;
            label6.Text = "Thông tin chi tiết hoá đơn";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtGDetaiInvoices
            // 
            dtGDetaiInvoices.BackgroundColor = Color.White;
            dtGDetaiInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGDetaiInvoices.Dock = DockStyle.Fill;
            dtGDetaiInvoices.Location = new Point(3, 275);
            dtGDetaiInvoices.Name = "dtGDetaiInvoices";
            dtGDetaiInvoices.RowHeadersWidth = 51;
            dtGDetaiInvoices.Size = new Size(523, 287);
            dtGDetaiInvoices.TabIndex = 4;
            dtGDetaiInvoices.CellContentClick += dtGDetaiInvoices_CellContentClick;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtTotal);
            panel6.Controls.Add(txtPaymentStatus);
            panel6.Controls.Add(txtPaymentMethod);
            panel6.Controls.Add(txtAddress);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label12);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 52);
            panel6.Name = "panel6";
            panel6.Size = new Size(523, 217);
            panel6.TabIndex = 5;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(235, 169);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(239, 27);
            txtTotal.TabIndex = 13;
            // 
            // txtPaymentStatus
            // 
            txtPaymentStatus.Location = new Point(235, 120);
            txtPaymentStatus.Name = "txtPaymentStatus";
            txtPaymentStatus.Size = new Size(239, 27);
            txtPaymentStatus.TabIndex = 12;
            // 
            // txtPaymentMethod
            // 
            txtPaymentMethod.Location = new Point(235, 73);
            txtPaymentMethod.Name = "txtPaymentMethod";
            txtPaymentMethod.Size = new Size(239, 27);
            txtPaymentMethod.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(203, 3);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(271, 53);
            txtAddress.TabIndex = 10;
            txtAddress.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 73);
            label9.Name = "label9";
            label9.Size = new Size(218, 23);
            label9.TabIndex = 9;
            label9.Text = "Phương thức thanh toán";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 120);
            label8.Name = "label8";
            label8.Size = new Size(200, 23);
            label8.TabIndex = 8;
            label8.Text = "Tình trạng thanh toán";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 171);
            label7.Name = "label7";
            label7.Size = new Size(127, 23);
            label7.TabIndex = 7;
            label7.Text = "Tổng hoá đơn";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 13);
            label12.Name = "label12";
            label12.Size = new Size(161, 23);
            label12.TabIndex = 6;
            label12.Text = "Địa chỉ giao hàng";
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1527, 834);
            Controls.Add(tableLayoutPanel1);
            Name = "Index";
            Text = "Index";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGInvoice).EndInit();
            panel4.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGDetaiInvoices).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel9;
        private Panel panel5;
        private Label label6;
        private DataGridView dtGDetaiInvoices;
        private Panel panel6;
        private TextBox txtTotal;
        private TextBox txtPaymentStatus;
        private TextBox txtPaymentMethod;
        private RichTextBox txtAddress;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label12;
        private Button button1;
    }
}