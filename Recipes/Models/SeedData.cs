using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Recipes.Models
{
    public class SeedData
    {


        public static void EnsurePopulated(IApplicationBuilder app)
        {

            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Recipes.Any())
            {

                context.Recipes.AddRange(
                    new Recipe
                    {
                        Name = "Meat",
                        Ingredients = "Meat",
                        Directions = "Cook it",
                        CookingTime = 10,
                        ServingNumber = 2,
                        
                    },
                    new Recipe
                    {
                        Name = "Fish",
                        Ingredients = "Fish",
                        Directions = "Cook it",
                        CookingTime = 15,
                        ServingNumber = 2,

                    },
                    new Recipe
                    {
                        Name = "Chicken",
                        Ingredients = "Chicken",
                        Directions = "Cook it",
                        CookingTime = 20,
                        ServingNumber = 1
                    },
                    new Recipe
                    {
                        Name = "Pasta",
                        Ingredients = "Pasta",
                        Directions = "Cook it",
                        CookingTime = 10,
                        ServingNumber = 2
                    },
                    new Recipe
                    {
                        Name = "Ribs",
                        Ingredients = "Ribs",
                        Directions = "Cook it",
                        CookingTime = 10,
                        ServingNumber = 2
                    }

                    );
                context.SaveChanges();

            }

        }

    }
}
