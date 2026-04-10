using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokApp.Data;
using PustokApp.ViewModels;

namespace PustokApp.Controllers
{
    public class BooksController : Controller
    {
        private readonly PustokAppDbContext _context;

        public BooksController(PustokAppDbContext context)
        {
            _context = context;
        }

        public IActionResult Detail(Guid id)
        {
            var book = _context.Books
                .Include(x => x.Author)
                .Include(x => x.BookImages)
                .Include(x => x.BookTags)
                .ThenInclude(x => x.Tag)
                .FirstOrDefault(x => x.Id == id);

            if (book == null)
                return NotFound();

            var related = _context.Books
                .Include(x => x.Author)
                .Include(x => x.BookImages)
                .Where(x => x.AuthorId == book.AuthorId && x.Id != book.Id)
                .Take(4)
                .ToList();

            var bookDetailVm = new BookDetailVm
            {
                Book = book,
                RelatedBooks = related
            };

            return View(bookDetailVm);
        }

        public IActionResult BookModal(Guid id)
        {
            var book = _context.Books
                .Include(x => x.Author)
                .Include(x => x.BookImages)
                .Include(x => x.BookTags)
                .ThenInclude(x => x.Tag)
                .FirstOrDefault(x => x.Id == id);
            if (book == null)
                return NotFound();
            return PartialView("_BookModalPartial", book);

        }
    }
}
