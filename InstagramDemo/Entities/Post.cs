using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.Entities
{
    public class Post : BaseClass
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string? ImagePath { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<PostLike> PostLikes { get; set; }
        public List<PostHashTag> PostHashTags { get; set; }
        
    }
}
