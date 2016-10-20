using System.ComponentModel.DataAnnotations;

namespace Fhazkard_Website.Models.ManageViewModels
{
    public class SetAuthorViewModel
    {

        [Required]
        [RegularExpression(@"^(\S)[^<>]+$", ErrorMessage ="Character Name Invalid")]
        [StringLength(15, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Author Name")]
        public string SetAuthor { get; set; }
    }
}
