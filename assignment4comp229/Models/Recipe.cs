using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignment4comp229.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }
        public string UserName { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public byte[] Icon { get; set; }
        public string Time { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreationDate { get; set; }
        public DateTime? EditDate { get; set; }

        public static implicit operator int(Recipe v)
        {
            throw new NotImplementedException();
        }
    }
}
