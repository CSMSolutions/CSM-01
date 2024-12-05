namespace GUI.Views.Statistical
{
    partial class index
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
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            TimeBegin = new DateTimePicker();
            TimeEnd = new DateTimePicker();
            btnStaFLDay = new Button();
            btnSubmit = new Button();
            txtTotal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            mainPlot = new ScottPlot.FormsPlot();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.466404F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.5336F));
            tableLayoutPanel1.Controls.Add(sideBar1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1012, 562);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // sideBar1
            // 
            sideBar1.Dock = DockStyle.Left;
            sideBar1.Location = new Point(3, 2);
            sideBar1.Margin = new Padding(3, 2, 3, 2);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(191, 558);
            sideBar1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 558);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Controls.Add(mainPlot, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Size = new Size(809, 558);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // TimeBegin
            // 
            TimeBegin.Location = new Point(172, 18);
            TimeBegin.Margin = new Padding(3, 2, 3, 2);
            TimeBegin.Name = "TimeBegin";
            TimeBegin.Size = new Size(219, 23);
            TimeBegin.TabIndex = 0;
            // 
            // TimeEnd
            // 
            TimeEnd.Location = new Point(172, 59);
            TimeEnd.Margin = new Padding(3, 2, 3, 2);
            TimeEnd.Name = "TimeEnd";
            TimeEnd.Size = new Size(219, 23);
            TimeEnd.TabIndex = 1;
            // 
            // btnStaFLDay
            // 
            btnStaFLDay.Location = new Point(22, 110);
            btnStaFLDay.Margin = new Padding(3, 2, 3, 2);
            btnStaFLDay.Name = "btnStaFLDay";
            btnStaFLDay.Size = new Size(168, 44);
            btnStaFLDay.TabIndex = 2;
            btnStaFLDay.Text = "Thống kê theo ngày";
            btnStaFLDay.UseVisualStyleBackColor = true;
            btnStaFLDay.Click += btnStaFLDay_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(407, 23);
            btnSubmit.Margin = new Padding(3, 2, 3, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(107, 44);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Xác nhận";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(575, 130);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(203, 32);
            txtTotal.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(443, 136);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 6;
            label1.Text = "Tổng doanh thu ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 32);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 7;
            label2.Text = "Thống kê";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 18);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 8;
            label3.Text = "Từ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 59);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 9;
            label4.Text = "Đến";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtTotal);
            panel2.Controls.Add(btnSubmit);
            panel2.Controls.Add(btnStaFLDay);
            panel2.Controls.Add(TimeEnd);
            panel2.Controls.Add(TimeBegin);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 392);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 164);
            panel2.TabIndex = 1;
            // 
            // mainPlot
            // 
            mainPlot.Dock = DockStyle.Fill;
            mainPlot.Location = new Point(4, 3);
            mainPlot.Margin = new Padding(4, 3, 4, 3);
            mainPlot.Name = "mainPlot";
            mainPlot.Size = new Size(801, 384);
            mainPlot.TabIndex = 2;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 562);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "index";
            Text = "index";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private CustomControls.SideBar sideBar1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTotal;
        private Button btnSubmit;
        private Button btnStaFLDay;
        private DateTimePicker TimeEnd;
        private DateTimePicker TimeBegin;
        private ScottPlot.FormsPlot mainPlot;
    }
}