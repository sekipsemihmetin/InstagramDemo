namespace InstagramDemo
{
    partial class HomePageForm
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
            flpAllPosts = new FlowLayoutPanel();
            button1 = new Button();
            txtSaerch = new TextBox();
            btnSearch = new Button();
            flpCategories = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpAllPosts
            // 
            flpAllPosts.AutoScroll = true;
            flpAllPosts.BackColor = Color.Turquoise;
            flpAllPosts.Location = new Point(22, 409);
            flpAllPosts.Margin = new Padding(6);
            flpAllPosts.Name = "flpAllPosts";
            flpAllPosts.Size = new Size(553, 537);
            flpAllPosts.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Location = new Point(425, 15);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 1;
            button1.Text = "<--";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtSaerch
            // 
            txtSaerch.Location = new Point(22, 19);
            txtSaerch.Name = "txtSaerch";
            txtSaerch.Size = new Size(200, 39);
            txtSaerch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(47, 76);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 46);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // flpCategories
            // 
            flpCategories.BackColor = Color.Turquoise;
            flpCategories.Location = new Point(22, 137);
            flpCategories.Name = "flpCategories";
            flpCategories.Size = new Size(553, 250);
            flpCategories.TabIndex = 4;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(590, 961);
            Controls.Add(flpCategories);
            Controls.Add(btnSearch);
            Controls.Add(txtSaerch);
            Controls.Add(button1);
            Controls.Add(flpAllPosts);
            Margin = new Padding(6);
            Name = "HomePageForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HomePageForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpAllPosts;
        private Button button1;
        private TextBox txtSaerch;
        private Button btnSearch;
        private FlowLayoutPanel flpCategories;
    }
}