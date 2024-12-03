namespace GUI.Views.Attribute
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
            tableLayoutPanel1 = new TableLayoutPanel();
            sideBar1 = new CustomControls.SideBar();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            panel = new Panel();
            btnUpdateColor = new Button();
            btnAddColor = new Button();
            label4 = new Label();
            txtColor = new TextBox();
            dtGViewColor = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnUpdateSize = new Button();
            btnAddSize = new Button();
            label5 = new Label();
            dtGViewSize = new DataGridView();
            txtSize = new TextBox();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGViewColor).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGViewSize).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(sideBar1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1080, 698);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // sideBar1
            // 
            sideBar1.Dock = DockStyle.Fill;
            sideBar1.Location = new Point(3, 3);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(210, 692);
            sideBar1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(219, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(858, 692);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 340);
            panel1.TabIndex = 0;
            // 
            // panel
            // 
            panel.Controls.Add(btnUpdateColor);
            panel.Controls.Add(btnAddColor);
            panel.Controls.Add(label4);
            panel.Controls.Add(txtColor);
            panel.Controls.Add(dtGViewColor);
            panel.Controls.Add(label2);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(852, 340);
            panel.TabIndex = 1;
            // 
            // btnUpdateColor
            // 
            btnUpdateColor.Location = new Point(663, 128);
            btnUpdateColor.Name = "btnUpdateColor";
            btnUpdateColor.Size = new Size(135, 62);
            btnUpdateColor.TabIndex = 5;
            btnUpdateColor.Text = "Cập nhật";
            btnUpdateColor.UseVisualStyleBackColor = true;
            btnUpdateColor.Click += btnUpdateColor_Click;
            // 
            // btnAddColor
            // 
            btnAddColor.Location = new Point(663, 46);
            btnAddColor.Name = "btnAddColor";
            btnAddColor.Size = new Size(135, 62);
            btnAddColor.TabIndex = 4;
            btnAddColor.Text = "Thêm";
            btnAddColor.UseVisualStyleBackColor = true;
            btnAddColor.Click += btnAddColor_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(371, 36);
            label4.Name = "label4";
            label4.Size = new Size(133, 38);
            label4.TabIndex = 3;
            label4.Text = "Tên màu ";
            // 
            // txtColor
            // 
            txtColor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtColor.Location = new Point(371, 88);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(208, 38);
            txtColor.TabIndex = 2;
            // 
            // dtGViewColor
            // 
            dtGViewColor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGViewColor.Location = new Point(15, 54);
            dtGViewColor.Name = "dtGViewColor";
            dtGViewColor.RowHeadersWidth = 51;
            dtGViewColor.Size = new Size(242, 260);
            dtGViewColor.TabIndex = 1;
            dtGViewColor.CellClick += dtGViewColor_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(221, 34);
            label2.TabIndex = 0;
            label2.Text = "Quản lí màu sắc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 54);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnUpdateSize);
            panel3.Controls.Add(btnAddSize);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(dtGViewSize);
            panel3.Controls.Add(txtSize);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 349);
            panel3.Name = "panel3";
            panel3.Size = new Size(852, 340);
            panel3.TabIndex = 1;
            // 
            // btnUpdateSize
            // 
            btnUpdateSize.Location = new Point(663, 132);
            btnUpdateSize.Name = "btnUpdateSize";
            btnUpdateSize.Size = new Size(135, 62);
            btnUpdateSize.TabIndex = 7;
            btnUpdateSize.Text = "Cập nhật";
            btnUpdateSize.UseVisualStyleBackColor = true;
            btnUpdateSize.Click += btnUpdateSize_Click;
            // 
            // btnAddSize
            // 
            btnAddSize.Location = new Point(663, 50);
            btnAddSize.Name = "btnAddSize";
            btnAddSize.Size = new Size(135, 62);
            btnAddSize.TabIndex = 6;
            btnAddSize.Text = "Thêm";
            btnAddSize.UseVisualStyleBackColor = true;
            btnAddSize.Click += btnAddSize_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(371, 56);
            label5.Name = "label5";
            label5.Size = new Size(133, 38);
            label5.TabIndex = 5;
            label5.Text = "Tên màu ";
            // 
            // dtGViewSize
            // 
            dtGViewSize.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGViewSize.Location = new Point(15, 60);
            dtGViewSize.Name = "dtGViewSize";
            dtGViewSize.RowHeadersWidth = 51;
            dtGViewSize.Size = new Size(242, 260);
            dtGViewSize.TabIndex = 2;
            dtGViewSize.CellClick += dtGViewSize_CellClick;
            // 
            // txtSize
            // 
            txtSize.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSize.Location = new Point(371, 108);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(208, 38);
            txtSize.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(203, 34);
            label3.TabIndex = 2;
            label3.Text = "Quản lí kích cỡ";
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 698);
            Controls.Add(tableLayoutPanel1);
            Name = "Index";
            Text = "Index";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGViewColor).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGViewSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private CustomControls.SideBar sideBar1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Label label1;
        private Panel panel;
        private Label label2;
        private Panel panel3;
        private DataGridView dtGViewColor;
        private TextBox txtColor;
        private DataGridView dtGViewSize;
        private Label label3;
        private Button btnUpdateColor;
        private Button btnAddColor;
        private Label label4;
        private Button btnUpdateSize;
        private Button btnAddSize;
        private Label label5;
        private TextBox txtSize;
    }
}