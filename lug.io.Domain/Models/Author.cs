using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lug.io.Domain.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Reference
        public virtual ICollection<Recipe> Recipes { get; set; }

        // todo: flush this out
    }
}
