using InstagramDemo.AbstractRepositories;
using InstagramDemo.AbstractServices;
using InstagramDemo.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = InstagramDemo.Entities.User;

namespace InstagramDemo
{
    public partial class EditProfile : Form
    {

        private readonly Entities.User user;
        private readonly IUserService _userService;
        private readonly IPostService _postService;
        private string _imagePath;

        public EditProfile(User user, IUserService userService,IPostService postService)
        {
            InitializeComponent();

            this.user = user;
            _userService = userService;
            _postService = postService;
        }

        private void ptbUserPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _imagePath = openFileDialog.FileName;
                    ptbUserPhoto.ImageLocation = _imagePath;
                }
            }
        }
        
        private void btnUpdatProfile_Click(object sender, EventArgs e)
        {
            user.ImagePath = SaveImage(_imagePath);
            _userService.UpdateUser(user.Id,user);
            MessageBox.Show("Updated Successfully...");
            Form userProfilForm = new UserProfileForm(user,_postService,_userService);
            this.Hide();
            userProfilForm.ShowDialog();

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
