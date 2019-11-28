using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private ApplicationDbContext context;

        public EFRecipeRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Recipe> Recipes => context.Recipes;

        public void SaveRecipe(Recipe recipe)
        {
            if (recipe.Id == 0)
            {
                context.Recipes.Add(recipe);
            }
            else
            {
                Recipe dbEntry = context.Recipes
                .FirstOrDefault(p => p.Id == recipe.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = recipe.Name;
                    dbEntry.Ingredients = recipe.Ingredients;
                    dbEntry.Directions = recipe.Directions;
                    dbEntry.CookingTime = recipe.CookingTime;
                    dbEntry.ServingNumber = recipe.ServingNumber;
                }
            }
            context.SaveChanges();
        }

        public Recipe DeleteRecipe(int id)
        {
            EFReviewRepository eFReviewRepository = new EFReviewRepository(context);
            eFReviewRepository.DeleteReview(id);
            Recipe dbEntry = context.Recipes
            .FirstOrDefault(p => p.Id == id);
            if (dbEntry != null)
            {
                context.Recipes.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }




    }
}
