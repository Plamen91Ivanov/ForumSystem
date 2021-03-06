﻿namespace Forum.Web.ViewModels.Home
{
    public class IndexCategoryViewModel : Forum.Services.Mapping.IMapFrom<Forum.Data.Models.Category>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public int PostsCount { get; set; }

        public string Url => $"/f/{this.Name.Replace(' ', '-')}";
    }
}