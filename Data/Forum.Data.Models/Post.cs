﻿using Forum.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Data.Models
{
    public class Post : BaseDeletableModel<int>
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public int UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
