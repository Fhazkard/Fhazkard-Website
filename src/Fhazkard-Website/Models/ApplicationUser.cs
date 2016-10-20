using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Fhazkard_Website.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string author_name { get; set; }
    }
   
}
