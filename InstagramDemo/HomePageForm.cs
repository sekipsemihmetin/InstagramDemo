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
            LoadCategories();
        }
        private void LoadPosts(string searchedTerm = null, Category category = null)
        {
            flpAllPosts.Controls.Clear();
            var posts = _postService.GetAllPosts();
            if (searchedTerm != null)
            {
                foreach (var post in posts)
                {
                    if (post.Title.Contains(searchedTerm))
                    {

                        AddPostToPanel(post);
                    }
                }

            }
            else if (category != null)
            {
                foreach (var item in posts)
                {
                    if (item.CategoryId == category.Id)
                    {
                        AddPostToPanel(item);
                    }
                }
            }
            else
            {
                foreach (var post in posts)
                {
                    AddPostToPanel(post);
                }
            }
        }

        private void AddPostToPanel(Post post)
        {
            // Panel ayarları
            var panel = new Panel
            {
                Width = 500,
                Height = 350,  // Yüksekliği arttırdım çünkü içerikler fazla
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10)
            };

            int topOffset = 10;  // İlk öğe için başlangıç yüksekliği
            int leftOffset = 10; // İlk öğe için başlangıç genişliği

            // Şikayet kontrolü yapılıyor
            _postService.DeletePostIfHasMoreThanThreeComplain(post.Id);
            if (!_postService.IsComplained(_user.Id, post.Id))
            {
                  

              
                var profilePhoto = new PictureBox()
                {
                    ImageLocation = _user.ImagePath != null ? _user.ImagePath : "C:\\Users\\pc\\source\\repos\\InstagramDemo\\InstagramDemo\\Images\\Default.jpeg",
                    Width = 50,
                    Height = 50,
                    Top = 10,
                    Left = 10,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

               
                profilePhoto.Paint += (sender, e) =>
                {
                    System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                    gp.AddEllipse(0, 0, profilePhoto.Width - 1, profilePhoto.Height - 1);
                    profilePhoto.Region = new Region(gp);
                };

                
                var usernameLabel = new Label
                {
                    Text = post.User.Username,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    AutoSize = true,
                    Top = 10, 
                    Left =  70,
                };

               
                panel.Controls.Add(profilePhoto);
                panel.Controls.Add(usernameLabel);

              
                var titleLabel = new Label
                {
                    Text = post.Title,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    AutoSize = true,
                    Top = 60,
                    Left = 10,
                };
                panel.Controls.Add(titleLabel);

                topOffset += 30; 

               

         
                int hashtagLeftOffset = leftOffset;

                foreach (var item in FindWords(post.Content))
                {
                    bool isHashtagAdded = false;

                    foreach (var hashtag in FindHashTags(item))
                    {
                    
                        if (post.Content.Contains(hashtag.Name))
                        {
                            var linkLabel = new LinkLabel
                            {
                                Text = hashtag.Name,
                                AutoSize = true,
                                Top = 90,
                                Left = hashtagLeftOffset,
                                Font = new Font("Arial", 10, FontStyle.Underline),
                                ForeColor = Color.Blue
                            };

                            panel.Controls.Add(linkLabel);
                            linkLabel.Click += new EventHandler(HashTag_Click);
                            hashtagLeftOffset += linkLabel.Width + 10;
                            isHashtagAdded = true;

                          
                         
                        }
                    }

                   
                    if (!isHashtagAdded)
                    {
                        var contentLabel = new Label
                        {
                            Text = item,
                            Font = new Font("Arial", 10),
                            AutoSize = true,
                            Top =90,
                            Left = hashtagLeftOffset
                        };

                        panel.Controls.Add(contentLabel);
                        hashtagLeftOffset += contentLabel.Width + 10;
                    }
                }



                var pictureBox = new PictureBox()
                {
                    ImageLocation = post.ImagePath,
                    Width = 250,
                    Height = 150,
                    Top = 150, 
                    Left = 115,  
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                panel.Controls.Add(pictureBox);

                topOffset += 120;
             

                PostLike postLike = _postService.GetPostLike(_user.Id, post.Id);
                var likeButton = new PictureBox
                {
                    ImageLocation = postLike == null
                        ? "C:\\Users\\pc\\source\\repos\\InstagramDemo\\InstagramDemo\\Images\\boskalp.jpg"
                        : "C:\\Users\\pc\\source\\repos\\InstagramDemo\\InstagramDemo\\Images\\dolukal.jpg",
                    Width = 50,
                    Height = 50,
                    Top = 295,
                    Left = 5,
                    Tag = post,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                likeButton.Click += pictureLikeBox_Click;
                panel.Controls.Add(likeButton);

               
                var complainButton = new Button
                {
                    Text = "Report",
                    Width = 100,
                    Height = 50,
                    Top = 297,
                    Left = 400, 
                    Tag = post.Id
                };
                complainButton.Click += ComplainButton_Click;
                panel.Controls.Add(complainButton);

              
                flpAllPosts.Controls.Add(panel);
            }
        }



        private void ComplainButton_Click(object? sender, EventArgs e)
        {
            var clickedButton = sender as Button;
            var complain = new PostComplain()
            {
                PostId = (int)clickedButton.Tag,
                UserId = _user.Id,
            };

            if (_postService.IsComplained(_user.Id, (int)complain.PostId))
            {
                MessageBox.Show("Daha önce Şikayet Ettiniz");
            }
            else
            {
                _postService.PostComain(complain);
                MessageBox.Show("Post Şikayet Edildi!!! AnaSayfanızdan Kaldırıldı");
                LoadPosts();

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
        private void HashTag_Click(object? sender, EventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;
            string clickedHashtag = linkLabel.Text;
            var filteredPosts = _postService.GetAllPosts()
                .Where(post => post.Content.Contains(clickedHashtag)).ToList();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {


            string clickedSearch = txtSaerch.Text;
            var filteredPosts = _postService.GetAllPosts()
                .Where(post => post.Title.Contains(clickedSearch)).ToList();
            flpAllPosts.Controls.Clear();
            foreach (var post in filteredPosts)
            {
                AddPostToPanel(post);
            }
        }
        private void AddCategoryToPanel(Category category)
        {
            int top = 10;
            int left = 10;
            var radioButton = new RadioButton()
            {
                Text = category.Name,
                Tag = category,
                Top = top += 200,
                Height = 50,
                Width = 150,
            };
            radioButton.Click += new EventHandler(RadioButton_Click);
            flpCategories.Controls.Add(radioButton);

        }

        private void RadioButton_Click(object? sender, EventArgs e)
        {
            RadioButton clickedRadioButton = sender as RadioButton;
            LoadPosts(category: (Category)clickedRadioButton.Tag);
        }
        private void LoadCategories()
        {
            flpCategories.Controls.Clear();
            foreach (var item in _postService.GetAllCategories())
            {
                AddCategoryToPanel(item);
            }
        }

    }
}