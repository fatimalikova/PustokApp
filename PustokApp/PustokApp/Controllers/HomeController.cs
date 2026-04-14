using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokApp.Data;
using PustokApp.Models;
using PustokApp.ViewModels;

namespace PustokApp.Controllers
{
    public class HomeController(PustokAppDbContext _context) : Controller
    {
        
        public IActionResult Index()
        {
            HomeVm homeVm = new HomeVm
            {
                Sliders = _context.Sliders.ToList(),
                FeaturedBooks = _context.Books
                .Include(x => x.Author)
                .Include(x => x.BookImages)
                .Where(x => x.IsFeatured).ToList(),

                NewBooks = _context.Books
                .Include(x => x.Author)
                .Include(x => x.BookImages)
                .Where(x => x.IsNew).ToList(),

                DiscountedBooks = _context.Books
                .Include(x => x.Author)
                .Include(x => x.BookImages)
                .Where(x => x.DiscountPercentage > 0).ToList()

            };
            return View(homeVm);
        }

    }
}
