using System;
using lug.io.ViewModel.Interfaces;

namespace lug.io.ViewModel.DTO
{
    public class RecipeDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public string ClientId { get; set; }
    }
}