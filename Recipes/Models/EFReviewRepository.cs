using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public class EFReviewRepository : IReviewRepository
    {
        private ApplicationDbContext context;

        public EFReviewRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Review> Reviews => context.Reviews;

        public void SaveReview(Review review)
        {
            Review newReview = new Review();
            newReview.ReviewText = review.ReviewText;
            newReview.ReviewTitle = review.ReviewTitle;
            newReview.RecipeIndex = review.RecipeIndex;
            context.Reviews.Add(newReview);
            context.SaveChanges();
        }


        public Review DeleteReview(int id)
        {
            Review dbEntry = context.Reviews
            .FirstOrDefault(p => p.RecipeIndex == id);
            if (dbEntry != null)
            {
                context.Reviews.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
