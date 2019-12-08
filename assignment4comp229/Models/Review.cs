using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignment4comp229.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public double Rating { get; set; }
        [ForeignKey("RecipeId")]
        public int RecipeId { get; set; }
        public string RecipeReview { get; set; }
        public string UserPosted { get; set; }
        public virtual ICollection<Recipe> Recipes { get; }
    }
}
