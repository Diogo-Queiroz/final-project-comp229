using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public interface IReviewRepository
    {

        IQueryable<Review> Reviews { get; }

        void SaveReview(Review review);

        Review DeleteReview(int id);

    }
}
