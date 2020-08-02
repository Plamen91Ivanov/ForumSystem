namespace Forum.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Forum.Data.Common.Repositories;
    using Forum.Services.Data;

    using Forum.Data.Models;

    public class NutritionService : INutritionService
    {
        private readonly IDeletableEntityRepository<Nutrition> addRepository;

        public NutritionService(
            IDeletableEntityRepository<Nutrition> addRepository)
        {
            this.addRepository = addRepository;
        }

        public async Task<int> Create(string name, int kcal, int fat, int proteins, int carbohydrate, int vitaminA)
        {
            var addNutrition = new Nutrition
            {
                Name = name,
                Kcal = kcal,
                Proteins = proteins,
                Fat = fat,
                Carbohydrate = carbohydrate,
                VitaminA = vitaminA,
            };

            await this.addRepository.AddAsync(addNutrition);
            await this.addRepository.SaveChangesAsync();
            return addNutrition.Id;
        }

    }
}
