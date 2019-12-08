using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Claims;

namespace assignment4comp229.Models
{
    public class SeedData:DbContext
    {
        public SeedData()
        {
            CheckIfDbEmpty();
        }

        public SeedData(DbContextOptions<SeedData> options) : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public void CheckIfDbEmpty()
        {
            if (!Recipes.Any())
            {
                OnModelCreating(null);
            }
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Recipe>().HasData(
                 new Recipe
                 {
                     RecipeId = 0001,
                     UserName = "Default User",
                     Name = "Apple Pie",
                     Description = "Simple apple pie",
                     Ingredients = "6 cups sliced apples, 3/4 cup white sugar, 1tbsp butter, 1tsp cinnamon, 1 pastry",
                     Icon = null,
                     Time = "1 hour",
                     CreationDate = DateTime.Parse("2019-07-02")
                 },
                 new Recipe
                 {
                     RecipeId = 0002,
                     UserName = "Default User",
                     Name = "Simple Chicken Dish",
                     Description = "Quick and simple, but delicious!",
                     Ingredients = "2tbsp olive oil, 1 chopped onion, chicken breast, 3tbsp ketchup, 2tbsp soy sauce, 2tbsp lemon juice, 1tsp black pepper",
                     Icon = null,
                     Time = "35 minutes",
                     CreationDate = DateTime.Parse("2019-07-01")
                 });

                 mb.Entity <Review> ().HasData(
                 new Review {
                 ReviewId = 1058,
                 RecipeId = 0001,
                 Rating = 4,
                 RecipeReview = "It was alright."
                 },
                 new Review {
                 ReviewId = 1059,
                 RecipeId = 0001,
                 Rating = 4.5,
                 RecipeReview = "Delicious, but basic."
                 },
                 new Review {
                 ReviewId = 0060,
                 RecipeId = 0002,
                 Rating = 5,
                 RecipeReview = "Amazing!"
                 });
        }
    }
}
