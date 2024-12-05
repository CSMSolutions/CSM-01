namespace GUI.Views.Products
{
    partial class AddProductDetailView
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBoxImage = new PictureBox();
            button1 = new Button();
            txtImagePath = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 54);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 108);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 170);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Màu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 221);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 3;
            label4.Text = "Giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 272);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 4;
            label5.Text = "Số lượng tồn kho";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 329);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 5;
            label6.Text = "Hình ảnh";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 51);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(278, 23);
            textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(206, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(206, 167);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(206, 218);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(206, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 10;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(377, 272);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(155, 102);
            pictureBoxImage.TabIndex = 11;
            pictureBoxImage.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(206, 351);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Chọn ảnh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(206, 321);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.ReadOnly = true;
            txtImagePath.Size = new Size(100, 23);
            txtImagePath.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(206, 403);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Thêm mới";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddProductDetailView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 450);
            Controls.Add(button2);
            Controls.Add(txtImagePath);
            Controls.Add(button1);
            Controls.Add(pictureBoxImage);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddProductDetailView";
            Text = "AddProductDetailView";
            Load += AddProductDetailView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox pictureBoxImage;
        private Button button1;
        private TextBox txtImagePath;
        private Button button2;
    }
}