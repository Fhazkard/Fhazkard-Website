using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fhazkard_Website.Data;
using Microsoft.EntityFrameworkCore;

namespace Fhazkard_Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Blog.ToListAsync());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Description page";
            ViewData["display"] = "Hidden";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "My contact page";
            ViewData["display"] = "Hidden";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
