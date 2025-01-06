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
    public partial class AddPostForm : Form
    {
        private string _imagePath;
        private readonly IPostService _postService;
        private readonly User _user;
        private readonly IUserService _userService;
        private readonly Category _category;

        public AddPostForm(IPostService postService,User user, IUserService userService)
        {
            InitializeComponent();
            _postService = postService;
            _user = user;
            _userService = userService;
            cmbCategory.Items.AddRange(_postService.GetAllCategories().Select(x=>x.Name).ToArray());
          
        }
        private void pbPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _imagePath = openFileDialog.FileName;
                    pbPicture.ImageLocation = _imagePath;
                }
            }
        }
        
        private void btnAddPost_Click(object sender, EventArgs e)
        {
            
            var post = new Post()
            {
                Title=txtTitle.Text,
                
                Content=txtContent.Text,
                UserId=_user.Id,
                ImagePath = SaveImage(_imagePath),
                
            };
          var category=_postService.GetAllCategories().FirstOrDefault(X=>X.Name==cmbCategory.SelectedItem) ;
            post.CategoryId = category.Id;

           

            _postService.AddPost(post);

            _postService.AddHashTagIfNotExists(FindHashTags(txtContent.Text));
           

            _postService.AddPostHashTags(post.Id, _postService.FindHashTagToAddThePost(FindHashTags(txtContent.Text)));

            MessageBox.Show("Post Added Succesfully!!");
            Form userProfileForm = new UserProfileForm(_user,_postService,_userService);
            this.Hide();
            userProfileForm.ShowDialog();
        }

        private string SaveImage(string sourcePath)
        {
            string projectPath = Directory.GetParent((AppDomain.CurrentDomain.BaseDirectory)).Parent.Parent.Parent.FullName;
            string imagePath = Path.Combine(projectPath, "Images");
                Directory.CreateDirectory(imagePath);
            string fileName = Path.GetFileName(sourcePath);
            string destinationPath =Path.Combine(imagePath, fileName);
            File.Copy(sourcePath, destinationPath, true);
            return destinationPath;
        }

        //Kullanıcı giriş yaptığında halihazırda oluşturduğumuz profil formunda kendi oluşturduğu postları görsün
        private List<Hasthag> FindHashTags(string sentence)
        {
           
            string[] words = sentence.Split(new char[] { ' ', '\n', '\r', '\t',',' },
            StringSplitOptions.RemoveEmptyEntries);

            List<Hasthag> hashTags = new ();
            
            foreach (var word in words) 
            {
                if (word.StartsWith("#")&&word.Length>1)
                {
                    var hashTagToAdd=new Hasthag();
                    hashTagToAdd.Name = word;
                    hashTags.Add(hashTagToAdd);
                    
                    
                }
            }
                return hashTags;
        }
        

    }
}

