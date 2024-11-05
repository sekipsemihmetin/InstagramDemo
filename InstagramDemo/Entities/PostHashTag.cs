using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.Entities
{
    public class PostHashTag:BaseClass
    {
        public int PostID { get; set; }
        public int HashTagID { get; set; }

        public Post Post { get; set; }
        public Hasthag Hasthag { get; set; }

    }
}
