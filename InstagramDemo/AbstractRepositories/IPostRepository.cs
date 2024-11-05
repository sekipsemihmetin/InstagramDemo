using InstagramDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.AbstractRepositories
{
    public interface IPostRepository
    {
        List<Post> GetPostsByLoggedInUser(int userId);
        List<Post> GetAllPostsWithUsers();

        PostLike GetPostLike(int userId, int postID);
       
    }
}
