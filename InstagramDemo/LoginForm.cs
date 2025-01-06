using InstagramDemo.AbstractServices;
using InstagramDemo.Entities;
using InstagramDemo.StataicsMethod;
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
        private readonly IEmailService _emailService;
        private readonly Post _post;
        private readonly User _user;

        public LoginForm(IUserService userService, IPostService postService, IEmailService emailService)
        {
            InitializeComponent();
            _userService = userService;
            _postService = postService;
            _emailService = emailService;
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new Form1(_userService, _postService, _emailService);
            this.Hide();
            form.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _userService.GetUserByTryToLogin(txtUsername.Text,SHA256Hasher.ComputeSha256Hash( txtPassword.Text));
                
            if (user != null)
            {
                if (user.IsAdmin == false)
                {

                    var userThatLoggedIn = _userService.Login(user);
                    Form userProfileForm = new UserProfileForm(userThatLoggedIn, _postService, _userService);
                    this.Hide();
                    userProfileForm.ShowDialog();
                }
                else
                {
                    var userThatLoggedIn = _userService.Login(user);
                    Form userProfileForm = new AdminHomePageFom(userThatLoggedIn, _postService, _userService, _post);
                    this.Hide();
                    userProfileForm.ShowDialog();
                }
            }

            else
            {
                MessageBox.Show("Username Or Password is incorrect!!!");
            }


        }

            
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            


                var user = _userService.GetUserByUsername(txtUsername.Text);
                _emailService.SendEmail(user.Email, "Şifre hatırlatma", "Merhabalar şifrenizi unutmuşsunuz şifreniz şöyle =" + user.Password);
            
        }
            
            
    }
}   
