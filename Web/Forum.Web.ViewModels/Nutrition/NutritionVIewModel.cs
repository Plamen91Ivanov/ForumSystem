namespace Forum.Web.ViewModels.Nutrition
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Forum.Data.Models;
    using Forum.Services.Mapping;

    public class NutritionVIewModel : IMapFrom<Forum.Data.Models.Nutrition>
    {
        public DateTime CreatedOn { get; set; }

        public string Name { get; set; }

        public int Kcal { get; set; }

        public int Proteins { get; set; }

        public int Fat { get; set; }

        public int Carbohydrate { get; set; }

        public int VitaminA { get; set; }
    }
}
