﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.Entities
{
    public class Category:BaseClass
    {
        public string Name { get; set; }
      
        public List<Post> Posts { get; set; }

    }
}
