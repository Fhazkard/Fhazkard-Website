using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Fhazkard_Website.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public string Email { get; set; }
        public string author { get; set; }
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactor { get; set; }
        public bool BrowserRemembered { get; set; }
    }
}
