using InstagramDemo.AbstractServices;
using InstagramDemo.Entities;

namespace InstagramDemo
{
    public partial class Form1 : Form
    {
        private readonly IUserService _userService;
        private readonly IPostService _postService;

        public Form1(IUserService userService,IPostService postService)
        {
            InitializeComponent();
            _userService = userService;
           _postService = postService;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User user = new User();


            if (_userService.GetUserByUsername(txtUsername.Text) == null)
            {
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.Email = txtEmail.Text;
                _userService.AddUser(user);
                MessageBox.Show("Register Successfull!!!!");

                Form loginForm = new LoginForm(_userService, _postService);
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
