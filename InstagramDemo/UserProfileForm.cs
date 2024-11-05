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
    public partial class UserProfileForm : Form
    {
        private readonly User _user;
        private readonly IPostService _postService;
        private readonly IUserService _userService;

        public UserProfileForm(User user, IPostService postService, IUserService userService)
        {
            InitializeComponent();
            _user = user;
            _postService = postService;
            _userService = userService;
            LoadPosts();
        }

        private void btnReturnToHome_Click(object sender, EventArgs e)
        {
            Form homePage = new HomePageForm(_postService, _user);
            this.Hide();
            homePage.ShowDialog();
        }

        private void btnAddPost_Click(object sender, EventArgs e)
        {
            Form addPostForm = new AddPostForm(_postService, _user, _userService);
            this.Hide();
            addPostForm.ShowDialog();
        }

        private void LoadPosts()
        {
            flpPosts.Controls.Clear();
            var posts = _postService.GetAllPostsByLoggedInUser(_user.Id);

            foreach (var post in posts)
            {
                AddPostToPanel(post);
            }
        }

        private void AddPostToPanel(Post post)
        {
            var panel = new Panel()
            {
                Width = 200,
                Height = 250,
                BorderStyle = BorderStyle.FixedSingle
            };

            var lblContent = new Label()
            {
                Text = post.Content,
                AutoSize = true,
                MaximumSize = new Size(480, 0), // Yatayda taşmayı önlemek için maksimum genişlik
                Top = 10
            };

            var lblTitle = new Label()
            {
                Text = post.Title,
                AutoSize = true,
                MaximumSize = new Size(480, 0),
                Top = 40 // Önceki label'a göre pozisyon ayarı
            };

            var lblAuthor = new Label()
            {
                Text = post.User.Username,
                AutoSize = true,
                Top = 70 // Önceki label'a göre pozisyon ayarı
            };

            panel.Controls.Add(lblContent);
            panel.Controls.Add(lblTitle);
            panel.Controls.Add(lblAuthor);


            var pictureBox = new PictureBox()
            {
                ImageLocation = post.ImagePath,
                Width = 100,
                Height = 100,
                Top = 80,
                Left = 10,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            panel.Controls.Add(lblContent);
            panel.Controls.Add(lblAuthor);
            panel.Controls.Add(lblTitle);
            panel.Controls.Add(pictureBox);
            flpPosts.Controls.Add(panel);
        }

        private void btnProfilDuzenle_Click(object sender, EventArgs e)
        {
            Form updateProfile = new ProfileUpdate(_user, _userService);
            this.Hide();
            updateProfile.ShowDialog();
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {

        }

        //Tüm postlar home pagede postu atan user'ın username'i ile listelensşn
    }
}
