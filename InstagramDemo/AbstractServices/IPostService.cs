using InstagramDemo.Entities;
using Microsoft.Identity.Client;
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
        void DeletePostIfHasMoreThanThreeComplain(int id );
        void DeletePostComplainWithUser(int id);
        void DeletePost(int id);

        List<Post> GetAllPostsByLoggedInUser(int id);
        List<Post> GetAllPosts();

        PostLike GetPostLike(int userId, int postId);

        void AddPostLike(int userId, int postId);

        void DeletePostLike(int userId, int postId);

        void AddHashTagIfNotExists(List<Hasthag> hasthags );
        void AddPostHashTags(int postId,List<int> hashTagId);
        List<int> FindHashTagIdsToAddTheMidTable();
        List<int> FindHashTagToAddThePost(List<Hasthag> hasthags);
       List<Category> GetAllCategories();
        void PostComain(PostComplain postComplain);
        bool IsComplained(int userId, int postId);
        List<PostComplain> GetAllPostComplain();
        List<Post> GetAllPostAllPostComplain();
        int GetPostComplainCount(Post post);
    }
}
