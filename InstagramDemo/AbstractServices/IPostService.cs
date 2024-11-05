using InstagramDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.AbstractServices
{
    public interface IPostService
    {
        void AddPost(Post post);

        List<Post> GetAllPostsByLoggedInUser(int id);
        List<Post> GetAllPosts();

        PostLike GetPostLike(int userId, int postId);

        void AddPostLike(int userId, int postId);

        void DeletePostLike(int userId, int postId);

        void AddHashTagIfNotExists(List<Hasthag> hasthags );
        void AddPostHashTags(int postId,List<int> hashTagId);
        List<int> FindHashTagIdsToAddTheMidTable();
        List<int> FindHashTagToAddThePost(List<Hasthag> hasthags);
       
    }
}
