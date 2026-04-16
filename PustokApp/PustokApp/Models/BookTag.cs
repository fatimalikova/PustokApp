using PustokApp.Models.Common;

namespace PustokApp.Models
{
    public class BookTag : BaseEntity
    {
        public Book Book { get; set; }
        public Guid BookId { get; set; }
        public Tag Tag { get; set; }
        public Guid TagId { get; set; }
    }
}
