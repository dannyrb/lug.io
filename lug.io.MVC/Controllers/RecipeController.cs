﻿using Microsoft.AspNet.Mvc;

namespace lug.io.MVC.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult New()
        {
            ViewData["Message"] = "Your application description page.";
            //var vm = new NewRecipeViewModel();

            return View();
        }
    }
}