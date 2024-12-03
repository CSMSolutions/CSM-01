namespace GUI.Views
{
    partial class LoginForm
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
            username_Txtbox = new TextBox();
            password_Txtbox = new TextBox();
            login_Btn = new Button();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 89);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 132);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // username_Txtbox
            // 
            username_Txtbox.Location = new Point(198, 86);
            username_Txtbox.Name = "username_Txtbox";
            username_Txtbox.Size = new Size(195, 23);
            username_Txtbox.TabIndex = 2;
            // 
            // password_Txtbox
            // 
            password_Txtbox.Location = new Point(198, 129);
            password_Txtbox.Name = "password_Txtbox";
            password_Txtbox.PasswordChar = '*';
            password_Txtbox.Size = new Size(195, 23);
            password_Txtbox.TabIndex = 3;
            // 
            // login_Btn
            // 
            login_Btn.BackColor = Color.Orange;
            login_Btn.FlatAppearance.BorderSize = 0;
            login_Btn.FlatStyle = FlatStyle.Flat;
            login_Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            login_Btn.ForeColor = Color.Black;
            login_Btn.Location = new Point(257, 186);
            login_Btn.Name = "login_Btn";
            login_Btn.Size = new Size(91, 28);
            login_Btn.TabIndex = 4;
            login_Btn.Text = "Đăng nhập";
            login_Btn.UseVisualStyleBackColor = false;
            login_Btn.Click += login_Btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(257, 25);
            label3.Name = "label3";
            label3.Size = new Size(75, 37);
            label3.TabIndex = 5;
            label3.Text = "CSM";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(497, 12);
            button1.Name = "button1";
            button1.Size = new Size(32, 29);
            button1.TabIndex = 6;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(541, 267);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(login_Btn);
            Controls.Add(password_Txtbox);
            Controls.Add(username_Txtbox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username_Txtbox;
        private TextBox password_Txtbox;
        private Button login_Btn;
        private Label label3;
        private Button button1;
    }
}