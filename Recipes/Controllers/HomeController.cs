using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models;

namespace Recipes.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult DisplayPage(int id)
        {

            Recipe recipe = Repository.Recipes.Where(n => n.Id == id).FirstOrDefault();
            
            return View(recipe);
        }


        public ViewResult DataPage()
        {
            return View(Repository.Recipes);
        }

        public ViewResult UserPage()
        {
            return View();
        }
    }
}
