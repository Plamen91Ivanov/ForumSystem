using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Web.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult ByName(string name)
        {
            return this.View();
        }
    }
}
