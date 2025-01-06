using InstagramDemo.AbstractServices;
using InstagramDemo.ConcreteServices;
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
    public partial class ProfileUpdate : Form
    {
        private readonly User _user;
        private readonly IPostService _postService;
        private readonly IUserService _userService;
        private string _imagePath;

        public ProfileUpdate(User user,IPostService postService, IUserService userService)
        {
            InitializeComponent();
            _user = user;
            _postService = postService;
            _userService = userService;
        }

        private void ProfileUpdate_Load(object sender, EventArgs e)
        {
            txtUsername.Text = _user.Username;
            txtEmail.Text = _user.Email;
            pbPicture.ImageLocation = _user.ImagePath;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _imagePath = openFileDialog.FileName;
                    pbPicture.ImageLocation = SaveImage(_imagePath);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _user.ImagePath= _imagePath;
            _userService.UpdateUser(_user.Id,_user);
            MessageBox.Show("Updated Succesfully");
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
            string destinationPath = Path.Combine(imagePath, fileName);
            File.Copy(sourcePath, destinationPath, true);
            return destinationPath;
        }
    }
}
