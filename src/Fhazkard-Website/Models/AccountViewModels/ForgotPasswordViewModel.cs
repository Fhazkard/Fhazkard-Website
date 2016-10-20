using System.ComponentModel.DataAnnotations;

namespace Fhazkard_Website.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
