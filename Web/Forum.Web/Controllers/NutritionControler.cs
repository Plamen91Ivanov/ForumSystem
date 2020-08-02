namespace Forum.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Forum.Data.Common.Repositories;
    using Forum.Services.Data;
    using Forum.Web.ViewModels.Nutrition;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class NutritionController : Controller
    {
        private readonly INutritionService nutritionService;

        public NutritionController(
            INutritionService nutritionService)
        {
            this.nutritionService = nutritionService;
        }

        public IActionResult AddNutrition()
        {
            var addNutrition = new NutritionVIewModel();

            return this.View(addNutrition);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddNutrition(NutritionVIewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var nutritions = await this.nutritionService.Create(
               input.Name,
               input.Kcal,
               input.Proteins,
               input.Fat,
               input.Carbohydrate,
               input.VitaminA
                   );
            return this.RedirectToAction("AddNutrition");
        }
    }
}
