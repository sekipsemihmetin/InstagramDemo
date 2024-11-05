namespace InstagramDemo
{
    partial class EditProfile
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
            ptbUserPhoto = new PictureBox();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            btnUpdatProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbUserPhoto).BeginInit();
            SuspendLayout();
            // 
            // ptbUserPhoto
            // 
            ptbUserPhoto.Location = new Point(165, 73);
            ptbUserPhoto.Name = "ptbUserPhoto";
            ptbUserPhoto.Size = new Size(200, 172);
            ptbUserPhoto.TabIndex = 0;
            ptbUserPhoto.TabStop = false;
            ptbUserPhoto.Click += ptbUserPhoto_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(165, 324);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 39);
            txtUsername.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(165, 408);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 39);
            txtEmail.TabIndex = 2;
            // 
            // btnUpdatProfile
            // 
            btnUpdatProfile.Location = new Point(165, 485);
            btnUpdatProfile.Name = "btnUpdatProfile";
            btnUpdatProfile.Size = new Size(200, 116);
            btnUpdatProfile.TabIndex = 3;
            btnUpdatProfile.Text = "Update Profile Photo";
            btnUpdatProfile.UseVisualStyleBackColor = true;
            btnUpdatProfile.Click += btnUpdatProfile_Click;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 961);
            Controls.Add(btnUpdatProfile);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(ptbUserPhoto);
            Name = "EditProfile";
            Text = "EditProfile";
            ((System.ComponentModel.ISupportInitialize)ptbUserPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbUserPhoto;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private Button btnUpdatProfile;
    }
}