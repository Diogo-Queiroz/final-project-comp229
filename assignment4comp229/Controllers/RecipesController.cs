using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using assignment4comp229.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using assignment4comp229.Data;

namespace assignment3comp229.Controllers
{
    public class RecipesController : Controller
    {
        private string loggedUser;
        private readonly SeedData _context;
        public RecipesController(SeedData context)
        {
            _context = context;
        }
       
        // GET: Recipes
            public async Task<IActionResult> DataPage()
            {
              var v1 = await _context.Recipes.ToListAsync();
              var v2 = await _context.Reviews.ToListAsync();
              Tuple<IEnumerable<Recipe>, IEnumerable<Review>> tuple = 
              new Tuple<IEnumerable<Recipe>, IEnumerable<Review>>(v1,v2);
              return View(tuple);
            }

            [HttpGet]
            public async Task<IActionResult> SearchRecipe(string search)
            {
              var v1 = await _context.Recipes.Where(p => p.Name.Contains(search)).ToListAsync();
              var v2 = await _context.Reviews.ToListAsync();
              if (v1.Count() == 0)
              {
                ViewBag.Message = "No recipes found!";
              }
              Tuple<IEnumerable<Recipe>, IEnumerable<Review>> tuple =
              new Tuple<IEnumerable<Recipe>, IEnumerable<Review>>(v1, v2);
              return View("DataPage", tuple);
            }

        public void RecipesAsync()
        {
        }

        [HttpGet]
        public async Task<IActionResult> DisplayPage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var recipe = await _context.Recipes.FirstOrDefaultAsync(m => m.RecipeId == id);
            recipe.UserName = loggedUser;
            var reviewList = await _context.Reviews.ToListAsync();
            if (recipe == null)
            {
                return NotFound();
            }
            Tuple<Recipe, IEnumerable<Review>> tuple =
            new Tuple<Recipe, IEnumerable<Review>>(recipe, reviewList);
            return View(tuple);
        }

        [HttpPost]
        public IActionResult DisplayPage(Recipe recipe)
        {
            bool isAuthenticated = User.Identity.IsAuthenticated;

            if (isAuthenticated == true)
            {
                recipe.UserName = User.Identity.Name.ToString();
            }

            return View(recipe);
        }

        [Authorize]
        // GET: Recipes/Create
        public IActionResult InsertPage(int? id)
        {
            return View();
        }

        // POST: Recipes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> InsertPage([Bind("RecipeId,Name,Description,Ingredients,Icon,Time,CreationDate")] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                recipe.UserName = User.Identity.Name.ToString();
                _context.Add(recipe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(DataPage));
            }
            return View(recipe);
        }

        //GET: Recipes/ReviewPage
        [Authorize]
        public IActionResult ReviewPage(int? id)
        {
            return View();
        }
        //POST: Recipes/ReviewPage
        [HttpPost, AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ReviewPage(int id, [Bind("ReviewId,Rating,RecipeId,RecipeReview,Recipes")] Review review)
        {
            if (ModelState.IsValid)
            {
                await _context.Recipes.FirstOrDefaultAsync(m => m.RecipeId == id);
                review.RecipeId = id;
                _context.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(DataPage)); 
            }
            return View(review);
        }

        // GET: Recipes/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }

            if (recipe.UserName != User.Identity.Name.ToString())
            {
                return NotFound();
            }
            return View(recipe);
        }

        // POST: Recipes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("RecipeId,Name,Description,Ingredients,Icon,Time,CreationDate")] Recipe recipe)
        {
            if (id != recipe.RecipeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    recipe.UserName = User.Identity.Name.ToString();
                    recipe.EditDate = DateTime.Now;
                    _context.Update(recipe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipeExists(recipe.RecipeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(DataPage));
            }
            return View(recipe);
        }

        // GET: Recipes/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes
                .FirstOrDefaultAsync(m => m.RecipeId == id);
            if (recipe == null)
            {
                return NotFound();
            }

            if (recipe.UserName != User.Identity.Name.ToString())
            {
                return NotFound();
            }

            return View(recipe);
        }

        // POST: Recipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recipe = await _context.Recipes.FindAsync(id);
            _context.Recipes.Remove(recipe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(DataPage));
        }

        private bool RecipeExists(int id)
        {
            return _context.Recipes.Any(e => e.RecipeId == id);
        }
    }
}
