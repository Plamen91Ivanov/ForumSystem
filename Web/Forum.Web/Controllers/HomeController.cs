namespace Forum.Web.Controllers
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using Forum.Data;
    using Forum.Data.Common.Repositories;
    using Forum.Data.Models;
    using Forum.Services.Data;
    using Forum.Web.ViewModels;
    using Forum.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Internal;

    public class HomeController : BaseController
    {
        private readonly ICategoryService categoryService;
        private readonly ApplicationDbContext db;

        public HomeController(
            ICategoryService categoryService,
            ApplicationDbContext db)
        {
            this.categoryService = categoryService;
            this.db = db;
        }

        public IActionResult Index(string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                var foundCategory = new IndexViewModel
                {
                   Categories = this.categoryService.SearchCategory<IndexCategoryViewModel>(search),
                };

                return this.View(foundCategory);

            }

            var viewModel = new IndexViewModel
             {
              Categories =
              this.categoryService.GetAll<IndexCategoryViewModel>(),
             };
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
