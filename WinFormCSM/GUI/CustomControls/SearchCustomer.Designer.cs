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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            toolSearchAndRefresh1 = new ToolSearchAndRefresh();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Unicode MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(178, 0);
            label1.Name = "label1";
            label1.Size = new Size(433, 38);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm thông tin khách hàng";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 40, 45);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 50);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 87);
            label2.Name = "label2";
            label2.Size = new Size(172, 31);
            label2.TabIndex = 2;
            label2.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(62, 153);
            label3.Name = "label3";
            label3.Size = new Size(194, 31);
            label3.TabIndex = 3;
            label3.Text = "Tên Khách Hàng";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(287, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 38);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(287, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(324, 38);
            textBox2.TabIndex = 5;
            // 
            // toolSearchAndRefresh1
            // 
            toolSearchAndRefresh1.Location = new Point(219, 212);
            toolSearchAndRefresh1.Name = "toolSearchAndRefresh1";
            toolSearchAndRefresh1.Size = new Size(392, 86);
            toolSearchAndRefresh1.TabIndex = 6;
            // 
            // SearchCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolSearchAndRefresh1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "SearchCustomer";
            Size = new Size(743, 311);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ToolSearchAndRefresh toolSearchAndRefresh1;
    }
}
