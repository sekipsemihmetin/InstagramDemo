using InstagramDemo.AbstractServices;
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
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        private readonly IPostService _postService;

        public LoginForm(IUserService userService,IPostService postService)
        {
            InitializeComponent();
            _userService = userService;
            _postService = postService;
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new Form1(_userService, _postService);
            this.Hide();
            form.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _userService.GetUserByTryToLogin(txtUsername.Text, txtPassword.Text);

            if (user != null)
            {

                var userThatLoggedIn = _userService.Login(user);
                Form userProfileForm = new UserProfileForm(userThatLoggedIn,_postService, _userService);
                this.Hide();
                userProfileForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username Or Password is incorrect!!!");
            }


        }
    }
}
