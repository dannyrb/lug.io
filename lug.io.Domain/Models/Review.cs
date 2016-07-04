using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lug.io.Domain.Models
{
    public class Review
    {
        public int Id { get; set; }
        // user
        public string Text { get; set; }
        // rating

        // Reference
        public int RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        public Recipe Recipe { get; set; }
    }
}
