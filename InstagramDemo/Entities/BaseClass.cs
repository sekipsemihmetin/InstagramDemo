﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.Entities
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
