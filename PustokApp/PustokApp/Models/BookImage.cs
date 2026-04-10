using PustokApp.Models.Common;

namespace PustokApp.Models
{
    public class BookImage : BaseEntity
    {
        public string Image { get; set; }
        public Book Book { get; set; }
        public Guid BookId { get; set; }
    }
}
