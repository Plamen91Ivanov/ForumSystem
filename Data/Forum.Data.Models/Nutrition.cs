namespace Forum.Data.Models
{
    using Forum.Data.Common.Models;

    public class Nutrition : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public int Kcal { get; set; }

        public int Proteins { get; set; }

        public int Fat { get; set; }

        public int Carbohydrate { get; set; }

        public int VitaminA { get; set; }
    }
}
