using System.Collections.Generic;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace lug.io.Domain.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class Recipe
    {
        public int Id { get; set; }

        // Value
        public string Name { get; set; }
        public string Description { get; set; }
        public int DefaultServings { get; set; }
        public int PrepTimeMinutes { get; set; }
        public int CookTimeMinutes { get; set; }

        // Reference
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }

        // List
        public virtual ICollection<Tag> Tags { get; set; } 
        public virtual ICollection<RecipeImage> Images { get; set; } 
        public virtual ICollection<Ingredient> Ingredients { get; set; } 
        public virtual ICollection<Direction> Directions { get; set; } 
        public virtual ICollection<Review> Reviews { get; set; } 
    }
}
