using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models;
using Recipes.Models.ViewModels;

namespace Recipes.Controllers
{
    public class CRUDController : Controller
    {

        private IRecipeRepository repository;

        public CRUDController(IRecipeRepository repo)
        {
            repository = repo;
        }

        [HttpPost]
        public ViewResult InsertPage(Recipe recipe)
        {
            if (ModelState.IsValid)
            {

                repository.SaveRecipe(recipe);
                return View("/Views/Home/RecipeAdded.cshtml", recipe);
            }
            else
            {
                return View();
            }

        }


        [HttpGet]
        public ViewResult InsertPage()
        {
            return View();
        }


        [HttpGet]
        public ViewResult UpdatePage(int id)
        {
            Recipe recipe = repository.Recipes.Where(n => n.Id == id).FirstOrDefault();

            return View("InsertPage", recipe);
        }

        [HttpPost]
        public ViewResult Delete(int id)
        {
            Recipe deletedProduct = repository.DeleteRecipe(id);
            if (deletedProduct != null)
            {
                TempData["message"] = $"{deletedProduct.Name} was deleted";
            }
            return View();
        }


    }
}