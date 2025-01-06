namespace InstagramDemo
{
    partial class ProfileUpdate
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
            txtEmail = new TextBox();
            pbPicture = new PictureBox();
            btnUpdate = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.SkyBlue;
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(94, 161);
            txtUsername.Margin = new Padding(6);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter username";
            txtUsername.Size = new Size(387, 39);
            txtUsername.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.SkyBlue;
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(94, 244);
            txtEmail.Margin = new Padding(6);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter email";
            txtEmail.Size = new Size(387, 39);
            txtEmail.TabIndex = 2;
            // 
            // pbPicture
            // 
            pbPicture.BackColor = Color.Turquoise;
            pbPicture.Location = new Point(73, 347);
            pbPicture.Margin = new Padding(6);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(419, 326);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPicture.TabIndex = 3;
            pbPicture.TabStop = false;
            pbPicture.Click += pictureBox1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SkyBlue;
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(185, 713);
            btnUpdate.Margin = new Padding(6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(209, 49);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.125F, FontStyle.Bold);
            label1.ForeColor = Color.Turquoise;
            label1.Location = new Point(36, 60);
            label1.Name = "label1";
            label1.Size = new Size(507, 52);
            label1.TabIndex = 5;
            label1.Text = "Simple Social Media";
            // 
            // ProfileUpdate
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(590, 961);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(pbPicture);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Margin = new Padding(6);
            Name = "ProfileUpdate";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProfileUpdate";
            Load += ProfileUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
        private TextBox txtEmail;
        private PictureBox pbPicture;
        private Button btnUpdate;
        private Label label1;
    }
}