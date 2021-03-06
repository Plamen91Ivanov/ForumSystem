﻿namespace Forum.Data.Models
{
    using Forum.Data.Common.Models;

    public class Comment : BaseDeletableModel<int>
    {
         public int PostId { get; set; }

         public virtual Post Post { get; set; }
    }
}
