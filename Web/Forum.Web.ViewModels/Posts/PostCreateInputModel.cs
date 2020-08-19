using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Web.ViewModels.Posts
{
    public class PostCreateInputModel
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int CategoryId { get; set; }
    }
}
