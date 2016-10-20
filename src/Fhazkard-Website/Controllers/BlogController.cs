using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Fhazkard_Website.Data;
using Fhazkard_Website.Models.BlogViewModels;
using Microsoft.AspNetCore.Authorization;
using System;
using Fhazkard_Website.Models;
using Microsoft.AspNetCore.Identity;
using Fhazkard_Website.Models.ManageViewModels;

namespace Fhazkard_Website.Controllers
{
    [Authorize]
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BlogController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        //[Authorize(Roles = "Administrator")]
        [AllowAnonymous]
        // GET: Blog
        public async Task<IActionResult> Index()
        {
            
            //HttpContext.Authentication.ChallengeAsync();
            ViewData["display"] = "Hidden";
            return View(await _context.Blog.ToListAsync());
        }      
        // GET: Blog/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blog.SingleOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }
        //Post
        [AllowAnonymous]
        public async Task<IActionResult> Post(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blog.SingleOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }
       
        // GET: Blog/Create
        public IActionResult Create()
        {
            DateTime tgl = DateTime.Now;

            ViewData["author"] = ManageController.data_author;
            ViewData["tgl"] = tgl.ToString("yyyy-MM-dd");
            ViewData["display"] = "Hidden";
            //ViewData["box-comment"] = "Hidden";
            return View();
        }

        // POST: Blog/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,author_name,content_blog,create_date,title_blog")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(blog);
        }

        // GET: Blog/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["display"] = "Hidden";
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blog.SingleOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }

        // POST: Blog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,author_name,content_blog,create_date,title_blog")] Blog blog)
        {
            if (id != blog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogExists(blog.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(blog);
        }

        // GET: Blog/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ViewData["display"] = "Hidden";
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blog.SingleOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // POST: Blog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blog = await _context.Blog.SingleOrDefaultAsync(m => m.Id == id);
            _context.Blog.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool BlogExists(int id)
        {
            return _context.Blog.Any(e => e.Id == id);
        }
    }
}
