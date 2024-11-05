using InstagramDemo.AbstractRepositories;
using InstagramDemo.Data;
using InstagramDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.ConcreteRepositories
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _context;

        public PostRepository(AppDbContext context)
        {
           _context = context;
        }

    

        public List<Post> GetAllPostsWithUsers()
        {
            return _context.Posts.ToList();
        }

        public PostLike GetPostLike(int userId, int postID)
        {
            return _context.PostLikes.Where(x=>x.PostId==postID&&x.UserId==userId).FirstOrDefault();
        }

        public List<Post> GetPostsByLoggedInUser(int userId)
        {
            var postsByUser = _context.Posts.Where(x=>x.UserId==userId).ToList();

            return postsByUser;
        }
    }
}
