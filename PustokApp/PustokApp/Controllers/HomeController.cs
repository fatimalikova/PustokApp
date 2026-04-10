using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
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
                NewBooks = _context.Books.ToList()

            };
            return View(homeVm);
        }

    }
}
