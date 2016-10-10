using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Fhazkard_Website.Models.BlogViewModels
{
    public class Blog
    {
        public int Id { get; set; }
        [Display(Name = "Title")]
        public string title_blog { get; set; }
        [Display(Name = "Content")]
        public string content_blog { get; set; }
        [Display(Name = "Author")]
        public string author_name { get; set; }
        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime create_date { get; set; }
    }
}
