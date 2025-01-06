using InstagramDemo.AbstractServices;
using InstagramDemo.ConcreteRepositories;
using InstagramDemo.ConcreteServices;
using InstagramDemo.Data;
using InstagramDemo.Entities;

namespace InstagramDemo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var context = new AppDbContext();
            Application.Run(new LoginForm(new UserService(new GenericRepository<User>(context), new UserRepository(context)), new PostService(new GenericRepository<Post>(context), new PostRepository(context), new GenericRepository<PostLike>(context), new GenericRepository<Hasthag>(context),new GenericRepository<PostHashTag>(context),new GenericRepository<Category>(context),new GenericRepository<PostComplain>(context)),new Email("sekipmetin.darussifa@gmail.com", "aklz foih eqkt frdt") ));
        }
    }
}