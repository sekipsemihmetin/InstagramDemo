namespace InstagramDemo
{
    partial class AdminHomePageFom
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
            dgcUserList = new DataGridView();
            btnGetAllPost = new Button();
            btnGetAllUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dgcUserList).BeginInit();
            SuspendLayout();
            // 
            // dgcUserList
            // 
            dgcUserList.BackgroundColor = Color.Turquoise;
            dgcUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgcUserList.Location = new Point(12, 70);
            dgcUserList.Name = "dgcUserList";
            dgcUserList.RowHeadersWidth = 82;
            dgcUserList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgcUserList.Size = new Size(570, 598);
            dgcUserList.TabIndex = 0;
            // 
            // btnGetAllPost
            // 
            btnGetAllPost.BackColor = Color.SkyBlue;
            btnGetAllPost.Location = new Point(351, 674);
            btnGetAllPost.Name = "btnGetAllPost";
            btnGetAllPost.Size = new Size(231, 46);
            btnGetAllPost.TabIndex = 3;
            btnGetAllPost.Text = "Get All Post";
            btnGetAllPost.UseVisualStyleBackColor = false;
            btnGetAllPost.Click += btnGetAllPost_Click;
            // 
            // btnGetAllUser
            // 
            btnGetAllUser.BackColor = Color.SkyBlue;
            btnGetAllUser.Location = new Point(12, 674);
            btnGetAllUser.Name = "btnGetAllUser";
            btnGetAllUser.Size = new Size(231, 46);
            btnGetAllUser.TabIndex = 4;
            btnGetAllUser.Text = "Get All User";
            btnGetAllUser.UseVisualStyleBackColor = false;
            btnGetAllUser.Click += btnGetAllUser_Click;
            // 
            // AdminHomePageFom
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(590, 961);
            Controls.Add(btnGetAllUser);
            Controls.Add(btnGetAllPost);
            Controls.Add(dgcUserList);
            Name = "AdminHomePageFom";
            StartPosition = FormStartPosition.CenterParent;
            Text = ",";
            ((System.ComponentModel.ISupportInitialize)dgcUserList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgcUserList;
        private Button btnGetAllPost;
        private Button btnGetAllUser;
    }
}