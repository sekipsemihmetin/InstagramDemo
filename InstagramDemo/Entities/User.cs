using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.Entities
{

    public class User:BaseClass
    {
        
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public string? ImagePath { get; set; }
        public List<Post> Posts { get; set; }
        public List<PostLike> PostLikes { get; set; }
        public List<PostComplain> PostComplains { get; set; }

    }
}
