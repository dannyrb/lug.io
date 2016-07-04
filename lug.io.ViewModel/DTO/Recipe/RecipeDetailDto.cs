using System;
using lug.io.ViewModel.Interfaces;

namespace lug.io.ViewModel.DTO
{
    public class RecipeDetailDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public string ClientId { get; set; }

        //
        public string Name { get; set; }
        public string Description { get; set; }
        public string Servings { get; set; }
        public string PrepTime { get; set; }
        public string CookTime { get; set; }
    }
}