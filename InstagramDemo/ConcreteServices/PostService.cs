using InstagramDemo.AbstractRepositories;
using InstagramDemo.AbstractServices;
using InstagramDemo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.ConcreteServices
{
    public class PostService : IPostService
    {
        private readonly IGenericRepository<Post> _repository;
        private readonly IPostRepository _postRepository;
        private readonly IGenericRepository<PostLike> _postLikeRepository;
        private readonly IGenericRepository<Hasthag> _hashTagRepository;
        private readonly IGenericRepository<PostHashTag> _postHashTagRepository;

        public PostService(IGenericRepository<Post> repository, IPostRepository postRepository, IGenericRepository<PostLike> postLikeRepository, IGenericRepository<Hasthag> hashTagRepository,IGenericRepository<PostHashTag> postHashTagRepository)
        {
            _repository = repository;
            _postRepository = postRepository;
            _postLikeRepository = postLikeRepository;
            _hashTagRepository = hashTagRepository;
            _postHashTagRepository = postHashTagRepository;
        }
        public void AddPost(Post post)
        {
            _repository.Add(post);
        }

        public List<Post> GetAllPosts()
        {
            return _postRepository.GetAllPostsWithUsers();
        }

        public List<Post> GetAllPostsByLoggedInUser(int id)
        {
            return _postRepository.GetPostsByLoggedInUser(id);
        }

        public PostLike GetPostLike(int userId, int postId)
        {
            return _postRepository.GetPostLike(userId, postId);
        }

        public void AddPostLike(int userId, int postId)
        {
            PostLike postLike = new()
            {
                PostId = postId,
                UserId = userId
            };
            _postLikeRepository.Add(postLike);
        }

        public void DeletePostLike(int userId, int postId)
        {
            PostLike postLike = _postLikeRepository.GetAll().Where(x => x.UserId == userId && x.PostId == postId).FirstOrDefault();
            _postLikeRepository.Delete(postLike.Id);
        }

        public void AddHashTagIfNotExists(List<Hasthag> hashTags)
        {
            var allHashTags = _hashTagRepository.GetAll();
         
            if (allHashTags.Count == 0)
            {
                _hashTagRepository.AddRange(hashTags);
            }
            else
            {
                foreach (var item in hashTags)
                {
                    var hashTag = allHashTags.FirstOrDefault(x => x.Name == item.Name);

                    if (hashTag == null)
                    {
                        _hashTagRepository.Add(item);
                    }
                    
                }

            }
        }

        public void AddPostHashTags(int postId, List<int> hashTagId)
        {
            foreach (var item in hashTagId)
            {
                var postHashTag = new PostHashTag();
                postHashTag.PostID = postId;
                postHashTag.HashTagID = item;
                _postHashTagRepository.Add(postHashTag);
            }
        }

        public List<int> FindHashTagIdsToAddTheMidTable()
        {
            var allHashTag=_hashTagRepository.GetAll();
            var idList=new List<int>();
            foreach (var item in idList)
            {
                idList.Add(item);
            }
            return idList;
        }

        public List<int> FindHashTagToAddThePost(List<Hasthag> hasthags)
        {
            var allHashTags = _hashTagRepository.GetAll();
            var idList=new List<int>(); 
            foreach (var item in allHashTags)
            {
                foreach (var item2 in hasthags)
                {
                    if (item.Name==item2.Name)
                    {
                        idList.Add(item.Id);
                    }
                }
            }
            return idList;
        }
    }

}
