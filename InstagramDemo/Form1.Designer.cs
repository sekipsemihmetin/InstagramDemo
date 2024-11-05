namespace InstagramDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblErrorMessage = new Label();
            btnRegister = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Turquoise;
            txtUsername.Location = new Point(54, 244);
            txtUsername.Margin = new Padding(6, 6, 6, 6);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Please enter username!!!";
            txtUsername.Size = new Size(474, 39);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Turquoise;
            txtPassword.Location = new Point(54, 365);
            txtPassword.Margin = new Padding(6, 6, 6, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Please enter password!!!";
            txtPassword.Size = new Size(474, 39);
            txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Turquoise;
            txtEmail.Location = new Point(54, 481);
            txtEmail.Margin = new Padding(6, 6, 6, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Please enter email!!";
            txtEmail.Size = new Size(474, 39);
            txtEmail.TabIndex = 5;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Location = new Point(89, 553);
            lblErrorMessage.Margin = new Padding(6, 0, 6, 0);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 32);
            lblErrorMessage.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SkyBlue;
            btnRegister.Location = new Point(136, 617);
            btnRegister.Margin = new Padding(6, 6, 6, 6);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(314, 96);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Verdana", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Turquoise;
            label2.Location = new Point(39, 108);
            label2.Name = "label2";
            label2.Size = new Size(507, 52);
            label2.TabIndex = 8;
            label2.Text = "Simple Social Media";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(590, 961);
            Controls.Add(label2);
            Controls.Add(btnRegister);
            Controls.Add(lblErrorMessage);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblErrorMessage;
        private Button btnRegister;
        private Label label2;
    }
}
