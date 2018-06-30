using System.Collections.Generic;

namespace EFCore.ManyToMany.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}