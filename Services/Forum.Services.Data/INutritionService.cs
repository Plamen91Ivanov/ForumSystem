namespace Forum.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface INutritionService
    {
        Task<int> Create(
           string name,
           int kcal,
           int proteins,
           int fat,
           int carbohydrate,
           int vitaminA
           );
    }
}
