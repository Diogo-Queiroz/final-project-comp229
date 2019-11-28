using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models;
using Recipes.Models.ViewModels;

namespace Recipes.Controllers
{
    public class ReviewController : Controller
    {

        private IReviewRepository reviewRepository;

        public ReviewController(IReviewRepository reviewRepo)
        {
            reviewRepository = reviewRepo;
        }

        [HttpGet]
        public ViewResult ReviewPage()
        {
            return View();
        }

        [HttpPost]
        public ViewResult ReviewPage(Review review)
        {

            if (ModelState.IsValid)
            {

                reviewRepository.SaveReview(review);
                return View("/Views/Review/ReviewAdded.cshtml");
            }
            else
            {
                ViewBag.RecipeId = review.RecipeIndex;
                return View("/Views/Recipe/AddReview.cshtml");
            }
        }


        public ViewResult ViewReview(int id)
        {
            IQueryable<Review> reviews = reviewRepository.Reviews.Where(r => r.RecipeIndex == id);
            return View(reviews);
        }

    }
}