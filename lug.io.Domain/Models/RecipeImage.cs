using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lug.io.Domain.Models
{
    public class RecipeImage
    {
        public int Id { get; set; }
        public int Name { get; set; }

        // Reference
        public int RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        public virtual Recipe Recipe { get; set; }
        // todo: flush out
    }
}
