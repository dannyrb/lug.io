using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using lug.io.Domain.Enumerations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace lug.io.Domain.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class Ingredient
    {
        public int Id { get; set; }

        // Value
        public string Name { get; set; }
        public double Quantity { get; set; }
        public Unit DefaultUnit { get; set; }
        public Preparation Preparation { get; set; }

        // Reference
        public int FoodItemId { get; set; }
        [ForeignKey("FoodItemId")]
        public FoodItem FoodItem { get; set; } 
        public int RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        public Recipe Recipe { get; set; }
    }
}
