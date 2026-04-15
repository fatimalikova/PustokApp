using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokApp.Data;
using PustokApp.ViewModels;

namespace PustokApp.Controllers
{
    public class BooksController(
        PustokAppDbContext _context) : Controller
    {
        

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

            BookVm bookVm = new()
            {
                Book = book,
                RelatedBooks = _context.Books
                .Include(x => x.Author)
                .Include(x => x.BookImages)
                .Where(x => x.AuthorId == book.AuthorId && x.Id != book.Id)
                .Take(4)
                .ToList()
            };
            return View(bookVm);

        }

        public IActionResult BookModal(Guid id)
        {
            var book = _context.Books
                //.Where(x => x.Id == id)
                .Include(x => x.Author)
                .Include(x => x.BookImages)
                .Include(x => x.BookTags)
                .ThenInclude(x => x.Tag)
                //.Select(x => new BookModalVm
                //{
                //    Name = x.Name,
                //    AuthorName = x.Author.FullName,
                //    Url = x.BookImages.Select(x => x.Image).ToList()
                //})
                .FirstOrDefault(x => x.Id == id);
            if (book == null)
                return NotFound();
            //BookModalVm bookModalVm = new()
            //{
            //    Name = book.Name,
            //    AuthorName = book.Author.FullName,
            //    Url = book.BookImages.Select(x => x.Image).ToList()
            //};
            //return PartialView("_BookModalPartialView", book);
            return Json(book);

        }
    }
    //class BookModalVm
    //{
    //    public string Name { get; set; }
    //    public List<string> Url { get; set; }
    //    public string AuthorName { get; set; }
    //}
}
