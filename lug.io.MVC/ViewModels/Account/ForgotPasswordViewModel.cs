using System.ComponentModel.DataAnnotations;

namespace lug.io.MVC.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
