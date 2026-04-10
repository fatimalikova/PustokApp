using PustokApp.Models;
using System.Collections.Generic;

namespace PustokApp.ViewModels
{
    public class BookDetailVm
    {
        public Book? Book { get; set; }
        public List<Book> RelatedBooks { get; set; } = new();
    }
}
