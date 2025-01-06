using InstagramDemo.AbstractServices;
using InstagramDemo.Entities;
using InstagramDemo.StataicsMethod;

namespace InstagramDemo
{
    public partial class Form1 : Form
    {
        private readonly IUserService _userService;
        private readonly IPostService _postService;
        private readonly IEmailService _emailService;

        public Form1(IUserService userService,IPostService postService,IEmailService emailService)
        {
            InitializeComponent();
            _userService = userService;
           _postService = postService;
            _emailService = emailService;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User user = new User();


            if (_userService.GetUserByUsername(txtUsername.Text) == null)
            {
                user.Username = txtUsername.Text;
                user.Password = SHA256Hasher.ComputeSha256Hash( txtPassword.Text);
                user.Email = txtEmail.Text;
                _userService.AddUser(user);
                MessageBox.Show("Register Successfull!!!!");

                //string toEmail=user.Email;
                //string subject = "Kay?t Ba?ar?l?";
                //string body="Merhabalar uygulamam?za ho?geldiniz Kullan?c? ad?n?z ="+user.Username+" Parolan?z ="+user.Password;
                //_emailService.SendEmail(toEmail, subject, body);

                Form loginForm = new LoginForm(_userService, _postService, _emailService    );
                this.Hide();
                loginForm.ShowDialog();
            }
            else
            {
                lblErrorMessage.Text = "This username is already in use";
                lblErrorMessage.ForeColor = Color.Red;
            }
          
        }
    }
}
