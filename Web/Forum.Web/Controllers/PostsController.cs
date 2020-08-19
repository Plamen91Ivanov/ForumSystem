using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Web.Controllers
{
    public class PostsController : Controller
    {
        public PostsController()
        {

        }

        public IActionResult Create()
        {
            return this.View();
        }
    }
}
