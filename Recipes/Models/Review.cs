using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Recipes.Models
{
    public class Review
    {
        public int RecipeIndex { get; set; }
        public int Id { get; set; }


        [Required(ErrorMessage = "Please enter a review title")]
        public string ReviewTitle { get; set; }

        [Required(ErrorMessage = "Please enter a review")]
        public string ReviewText { get; set; }

    }
}
