using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.Entities
{
    public class PostLike:BaseClass
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public  User  User  { get; set; }
        public  Post  Post  { get; set; }
    }
}
