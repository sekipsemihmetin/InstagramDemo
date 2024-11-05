using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.Entities
{
    public class Hasthag:BaseClass
    {
        public  string  Name {get; set; }
        public List<PostHashTag> PostHashTags { get; set; }
    }
}
