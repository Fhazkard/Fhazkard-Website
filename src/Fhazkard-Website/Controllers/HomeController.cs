using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fhazkard_Website.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Blog");

        }

        public IActionResult About()
        {
            ViewData["Message"] = "My profile description page";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "My contact page";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
