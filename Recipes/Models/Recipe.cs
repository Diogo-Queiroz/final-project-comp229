using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Recipes.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the recipe name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the recipe ingredients")]
        public string Ingredients { get; set; }

        [Required(ErrorMessage = "Please enter the directions")]
        public string Directions { get; set; }

        [Required(ErrorMessage = "Please enter how many people the recipe serves")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]

        public int ServingNumber { get; set; }

        [Required(ErrorMessage = "Please enter how many minutes takes to prepare the recipe")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]

        public int CookingTime { get; set; }
        //public List<Review> Reviews { get; set; }
    }
}
