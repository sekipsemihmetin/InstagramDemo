using InstagramDemo.AbstractServices;
using InstagramDemo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstagramDemo
{
    public partial class HomePageForm : Form
    {
        private readonly IPostService _postService;
        private readonly User _user;
        private readonly IUserService _userService;

        public HomePageForm(IPostService postService, User user)
        {
            InitializeComponent();
            _postService = postService;
            _user = user;
            LoadPosts();
        }
        private void LoadPosts()
        {
            flpAllPosts.Controls.Clear();
            var posts = _postService.GetAllPosts();

            foreach (var post in posts)
            {
                AddPostToPanel(post);
            }
        }

        private void AddPostToPanel(Post post)
        {
            var panel = new Panel() { Width = 450, Height = 250, BorderStyle = BorderStyle.FixedSingle };
            int topOffset = 10;
            foreach (var item in FindWords(post.Content))
            {
              

                foreach (var item2 in FindHashTags(item))
                {
                    if (post.Content.Contains(item2.Name))
                    {
                       var linLabelControl  = new LinkLabel
                        {
                            Text = item2.Name,
                            AutoSize = true,
                            Top = topOffset,
                            Font = new Font("Arial", 10, FontStyle.Underline),
                            ForeColor = Color.Blue
                        };
                        panel.Controls.Add(linLabelControl);
                        linLabelControl.Click += new EventHandler(hashTag_Click);
                    }
                }
              
               var labelControl = new Label
                {
                    Text = item,
                    AutoSize = true,
                    Top = topOffset,
                    Font = new Font("Arial", 10)
                };

                // Top konumunu güncelle
                topOffset += labelControl.Height + 5;

                panel.Controls.Add(labelControl);

                PostLike postLike = _postService.GetPostLike(_user.Id, post.Id);
                var pictureLikeBox = new PictureBox()
                {
                    ImageLocation = postLike == null
                        ? "C:\\Users\\pc\\source\\repos\\InstagramDemo\\InstagramDemo\\Images\\boskalp.jpg"
                        : "C:\\Users\\pc\\source\\repos\\InstagramDemo\\InstagramDemo\\Images\\dolukal.jpg",
                    Width = 40, // Boyutu büyüttük
                    Height = 40, // Boyutu büyüttük
                    Top = 200,
                    Left = 10,
                    Tag = post,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                pictureLikeBox.Click += new EventHandler(pictureLikeBox_Click);
                // panel.Controls.Add(lblAuthor);
                // panel.Controls.Add(lblTitle);
                //panel.Controls.Add(pictureBox);
                //panel.Controls.Add(pbBox);
                // panel.Controls.Add(label);
                // panel.Controls.Add(linkLabel);
                flpAllPosts.Controls.Add(panel);


            }
        }
        private void pictureLikeBox_Click(object? sender, EventArgs e)
        {
            PictureBox pictureLikeBox = (PictureBox)sender;
            var post = (Post)pictureLikeBox.Tag;
            PostLike postLike = _postService.GetPostLike(_user.Id, post.Id);
            if (postLike == null)
            {
                _postService.AddPostLike(_user.Id, post.Id);
                pictureLikeBox.ImageLocation = "C:\\Users\\pc\\source\\repos\\InstagramDemo\\InstagramDemo\\Images\\dolukal.jpg";
            }
            else
            {
                _postService.DeletePostLike(_user.Id, post.Id);
                pictureLikeBox.ImageLocation = "C:\\Users\\pc\\source\\repos\\InstagramDemo\\InstagramDemo\\Images\\boskalp.jpg";
            }


        }
        private void hashTag_Click(object? sender, EventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;
            string clickedHashtag = linkLabel.Text;

           
            var filteredPosts = _postService.GetAllPosts()
                .Where(post => post.Content.Contains(clickedHashtag))
                .ToList();

           
            flpAllPosts.Controls.Clear();
            foreach (var post in filteredPosts)
            {
                AddPostToPanel(post);
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new UserProfileForm(_user, _postService, _userService);
            this.Close();
            form.ShowDialog();
        }
        private List<Hasthag> FindHashTags(string sentence)
        {

            string[] words = sentence.Split(new char[] { ' ', '\n', '\r', '\t', ',' },
            StringSplitOptions.RemoveEmptyEntries);

            List<Hasthag> hashTags = new();

            foreach (var word in words)
            {
                if (word.StartsWith("#") && word.Length > 1)
                {
                    var hashTagToAdd = new Hasthag();
                    hashTagToAdd.Name = word;
                    hashTags.Add(hashTagToAdd);


                }
            }
            return hashTags;
        }
        private List<string> FindWords(string sentence)
        {

            string[] words = sentence.Split(new char[] { ' ', '\n', '\r', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);



            return words.ToList();
        }

    }
}
