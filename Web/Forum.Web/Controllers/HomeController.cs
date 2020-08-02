namespace Forum.Web.Controllers
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    using Forum.Data;
    using Forum.Data.Common.Repositories;
    using Forum.Data.Models;
    using Forum.Services.Data;
    using Forum.Web.ViewModels;
    using Forum.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore.Internal;

    public class HomeController : BaseController
    {
        private readonly ICategoryService categoryService;

        public HomeController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                Categories =
                    this.categoryService.GetAll<IndexCategoryViewModel>()
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
