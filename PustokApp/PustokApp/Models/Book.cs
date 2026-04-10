using PustokApp.Models.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PustokApp.Models
{
    public class Book : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int DiscountPercentage { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public Author? Author { get; set; }
        public Guid AuthorId { get; set; }
        public string MainImageUrl { get; set; } = string.Empty;
        public string HoverImageUrl { get; set; } = string.Empty;
        public bool IsNew { get; set; }
        public bool IsFeatured { get; set; }
        public bool InStock { get; set; }
        public int Code { get; set; }
        public List<BookImage> BookImages { get; set; } 
        public List<BookTag> BookTags { get; set; }
    }
}
