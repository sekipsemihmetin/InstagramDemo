namespace InstagramDemo
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lnkRegister = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            lnkForgotPassword = new LinkLabel();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Turquoise;
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(116, 393);
            txtUsername.Margin = new Padding(6);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username!!";
            txtUsername.Size = new Size(322, 39);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Turquoise;
            txtPassword.Location = new Point(116, 478);
            txtPassword.Margin = new Padding(6);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password!!";
            txtPassword.Size = new Size(322, 39);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SkyBlue;
            btnLogin.Location = new Point(116, 588);
            btnLogin.Margin = new Padding(6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(325, 68);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.Location = new Point(318, 920);
            lnkRegister.Margin = new Padding(6, 0, 6, 0);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(170, 32);
            lnkRegister.TabIndex = 5;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Register NOW!";
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.Turquoise;
            label1.Location = new Point(3, 920);
            label1.Name = "label1";
            label1.Size = new Size(306, 32);
            label1.TabIndex = 6;
            label1.Text = "Don't have an account yet?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Verdana", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Turquoise;
            label2.Location = new Point(35, 268);
            label2.Name = "label2";
            label2.Size = new Size(507, 52);
            label2.TabIndex = 7;
            label2.Text = "Simple Social Media";
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Location = new Point(155, 674);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(242, 32);
            lnkForgotPassword.TabIndex = 8;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "I Forgot My Password";
            lnkForgotPassword.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(590, 961);
            Controls.Add(lnkForgotPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lnkRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Margin = new Padding(6);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel lnkRegister;
        private Label label1;
        private Label label2;
        private LinkLabel lnkForgotPassword;
    }
}