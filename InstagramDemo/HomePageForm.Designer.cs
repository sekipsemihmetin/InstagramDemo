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
            SuspendLayout();
            // 
            // flpAllPosts
            // 
            flpAllPosts.AutoScroll = true;
            flpAllPosts.BackColor = Color.Turquoise;
            flpAllPosts.Location = new Point(22, 79);
            flpAllPosts.Margin = new Padding(6);
            flpAllPosts.Name = "flpAllPosts";
            flpAllPosts.Size = new Size(541, 856);
            flpAllPosts.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Location = new Point(413, 12);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 1;
            button1.Text = "<--";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(590, 961);
            Controls.Add(button1);
            Controls.Add(flpAllPosts);
            Margin = new Padding(6);
            Name = "HomePageForm";
            Text = "HomePageForm";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpAllPosts;
        private Button button1;
    }
}