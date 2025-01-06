namespace InstagramDemo
{
    partial class AddPostForm
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
            pbPicture = new PictureBox();
            btnAddPost = new Button();
            txtTitle = new TextBox();
            txtContent = new TextBox();
            cmbCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            SuspendLayout();
            // 
            // pbPicture
            // 
            pbPicture.BackColor = Color.MediumTurquoise;
            pbPicture.Location = new Point(43, 56);
            pbPicture.Margin = new Padding(6);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(511, 269);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPicture.TabIndex = 0;
            pbPicture.TabStop = false;
            pbPicture.Click += pbPicture_Click;
            // 
            // btnAddPost
            // 
            btnAddPost.BackColor = Color.SkyBlue;
            btnAddPost.Location = new Point(162, 828);
            btnAddPost.Margin = new Padding(6);
            btnAddPost.Name = "btnAddPost";
            btnAddPost.Size = new Size(269, 70);
            btnAddPost.TabIndex = 1;
            btnAddPost.Text = "Add Post";
            btnAddPost.UseVisualStyleBackColor = false;
            btnAddPost.Click += btnAddPost_Click;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.Turquoise;
            txtTitle.Location = new Point(141, 394);
            txtTitle.Margin = new Padding(6);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title should be here..";
            txtTitle.Size = new Size(318, 39);
            txtTitle.TabIndex = 2;
            // 
            // txtContent
            // 
            txtContent.BackColor = Color.Turquoise;
            txtContent.Location = new Point(43, 510);
            txtContent.Margin = new Padding(6);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.PlaceholderText = "Content Should Be Here..";
            txtContent.Size = new Size(511, 241);
            txtContent.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(141, 442);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(318, 40);
            cmbCategory.TabIndex = 4;
            // 
            // AddPostForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(590, 961);
            Controls.Add(cmbCategory);
            Controls.Add(txtContent);
            Controls.Add(txtTitle);
            Controls.Add(btnAddPost);
            Controls.Add(pbPicture);
            Margin = new Padding(6);
            Name = "AddPostForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddPostForm";
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPicture;
        private Button btnAddPost;
        private TextBox txtTitle;
        private TextBox txtContent;
        private ComboBox cmbCategory;
    }
}