using lug.io.Domain.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace lug.io.Domain
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Recipe> Recipes { get; set; } 
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; } 
        public DbSet<RecipeImage> RecipeImages { get; set; } 
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Review> Reviews { get; set; } 
    }
}
