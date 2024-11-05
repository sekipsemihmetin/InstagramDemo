namespace InstagramDemo
{
    partial class UserProfileForm
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
            btnAddPost = new Button();
            btnReturnToHome = new Button();
            flpPosts = new FlowLayoutPanel();
            btnProfilDuzenle = new Button();
            SuspendLayout();
            // 
            // btnAddPost
            // 
            btnAddPost.BackColor = Color.SkyBlue;
            btnAddPost.Location = new Point(22, 843);
            btnAddPost.Margin = new Padding(6, 6, 6, 6);
            btnAddPost.Name = "btnAddPost";
            btnAddPost.Size = new Size(179, 92);
            btnAddPost.TabIndex = 0;
            btnAddPost.Text = "Post";
            btnAddPost.UseVisualStyleBackColor = false;
            btnAddPost.Click += btnAddPost_Click;
            // 
            // btnReturnToHome
            // 
            btnReturnToHome.BackColor = Color.SkyBlue;
            btnReturnToHome.Location = new Point(382, 843);
            btnReturnToHome.Margin = new Padding(6, 6, 6, 6);
            btnReturnToHome.Name = "btnReturnToHome";
            btnReturnToHome.Size = new Size(179, 92);
            btnReturnToHome.TabIndex = 1;
            btnReturnToHome.Text = "HOME";
            btnReturnToHome.UseVisualStyleBackColor = false;
            btnReturnToHome.Click += btnReturnToHome_Click;
            // 
            // flpPosts
            // 
            flpPosts.AutoScroll = true;
            flpPosts.BackColor = Color.Turquoise;
            flpPosts.Location = new Point(22, 220);
            flpPosts.Margin = new Padding(6, 6, 6, 6);
            flpPosts.Name = "flpPosts";
            flpPosts.Size = new Size(539, 577);
            flpPosts.TabIndex = 2;
            // 
            // btnProfilDuzenle
            // 
            btnProfilDuzenle.BackColor = Color.SkyBlue;
            btnProfilDuzenle.Location = new Point(431, 4);
            btnProfilDuzenle.Margin = new Padding(6, 6, 6, 6);
            btnProfilDuzenle.Name = "btnProfilDuzenle";
            btnProfilDuzenle.Size = new Size(153, 92);
            btnProfilDuzenle.TabIndex = 1;
            btnProfilDuzenle.Text = "Design Profile";
            btnProfilDuzenle.UseVisualStyleBackColor = false;
            btnProfilDuzenle.Click += btnProfilDuzenle_Click;
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(590, 961);
            Controls.Add(flpPosts);
            Controls.Add(btnProfilDuzenle);
            Controls.Add(btnReturnToHome);
            Controls.Add(btnAddPost);
            Margin = new Padding(6, 6, 6, 6);
            Name = "UserProfileForm";
            Text = "UserProfileForm";
            Load += UserProfileForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddPost;
        private Button btnReturnToHome;
        private FlowLayoutPanel flpPosts;
        private Button btnProfilDuzenle;
    }
}