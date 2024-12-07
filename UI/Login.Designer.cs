namespace RaskhodApp.UI
{
    partial class Login
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
            tb_email = new TextBox();
            label_email = new Label();
            label_password = new Label();
            btn_login = new Button();
            tb_password = new TextBox();
            SuspendLayout();
            // 
            // tb_email
            // 
            tb_email.Location = new Point(67, 121);
            tb_email.Margin = new Padding(3, 4, 3, 4);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(156, 23);
            tb_email.TabIndex = 0;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(64, 102);
            label_email.Name = "label_email";
            label_email.Size = new Size(36, 15);
            label_email.TabIndex = 1;
            label_email.Text = "Email";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(67, 178);
            label_password.Name = "label_password";
            label_password.Size = new Size(57, 15);
            label_password.TabIndex = 3;
            label_password.Text = "Password";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.MediumBlue;
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_login.ForeColor = SystemColors.ButtonFace;
            btn_login.Location = new Point(79, 249);
            btn_login.Margin = new Padding(3, 4, 3, 4);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(129, 54);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(67, 197);
            tb_password.Margin = new Padding(3, 4, 3, 4);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(156, 23);
            tb_password.TabIndex = 2;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 381);
            Controls.Add(btn_login);
            Controls.Add(label_password);
            Controls.Add(tb_password);
            Controls.Add(label_email);
            Controls.Add(tb_email);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Eventure Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_password;
    }
}