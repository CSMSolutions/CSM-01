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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 119);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 164);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // username_Txtbox
            // 
            username_Txtbox.Location = new Point(213, 111);
            username_Txtbox.Name = "username_Txtbox";
            username_Txtbox.Size = new Size(100, 23);
            username_Txtbox.TabIndex = 2;
            // 
            // password_Txtbox
            // 
            password_Txtbox.Location = new Point(213, 164);
            password_Txtbox.Name = "password_Txtbox";
            password_Txtbox.Size = new Size(100, 23);
            password_Txtbox.TabIndex = 3;
            // 
            // login_Btn
            // 
            login_Btn.Location = new Point(223, 232);
            login_Btn.Name = "login_Btn";
            login_Btn.Size = new Size(75, 23);
            login_Btn.TabIndex = 4;
            login_Btn.Text = "Đăng nhập";
            login_Btn.UseVisualStyleBackColor = true;
            login_Btn.Click += login_Btn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(login_Btn);
            Controls.Add(password_Txtbox);
            Controls.Add(username_Txtbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
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
    }
}