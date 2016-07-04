using System;
using lug.io.ViewModel.Base;
using lug.io.ViewModel.DTO;

namespace lug.io.ViewModel.ViewModels
{
    public class RecipeViewModel : ViewModelBase<RecipeDto, RecipeDetailDto, Guid>
    {
        public RecipeViewModel()
        {
            Title = "Recipe";
        }

        //public LoginViewModel LoginForm { get; set; }
        //public RegisterViewModel RegisterForm { get; set; }

        public override Guid GetDefaultIdValue()
        {
            return new Guid();
        }

        // todo
        //public RecipeViewModelMeta Meta { get; set; }
    }
}