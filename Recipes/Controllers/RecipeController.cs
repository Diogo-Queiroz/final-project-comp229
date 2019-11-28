using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models;
using Recipes.Models.ViewModels;

namespace Recipes.Controllers
{
    public class RecipeController : Controller
    {
        private IRecipeRepository repository;
        public int PageSize = 10;

        public RecipeController(IRecipeRepository repo)
        {
            repository = repo;
        }

        [HttpGet]
        public ViewResult SearchList(string search, int recipePage = 1)
        {
            return View("List", new RecipesListViewModel
            {
                Recipes = repository.Recipes
                          .Where(p => p.Name.Contains(search))
                          .Skip((recipePage - 1) * PageSize)
                          .Take(PageSize),
                PagingInfo = new PagingInfo
                  {
                    CurrentPage = recipePage,
                    RecipesPerPage = PageSize,
                    TotalRecipes = repository.Recipes.Count()
                }
            });
        }

        public ViewResult List(int recipePage = 1) =>
            View(new RecipesListViewModel
            {
                Recipes = repository.Recipes
                .OrderBy(p => p.Id)
                .Skip((recipePage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
            {
                CurrentPage = recipePage,
                RecipesPerPage = PageSize,
                TotalRecipes = repository.Recipes.Count()
            }
            });



        [HttpGet]
        public ViewResult Details(int id)
        {

            Recipe recipe = repository.Recipes.Where(n => n.Id == id).FirstOrDefault();


            return View(recipe);
        }

        [HttpGet]
        public ViewResult AddReview(int id)
        {
            ViewBag.RecipeId = repository.Recipes.Where(p => p.Id == id).FirstOrDefault().Id;
            return View();
        }

        
    }
}
