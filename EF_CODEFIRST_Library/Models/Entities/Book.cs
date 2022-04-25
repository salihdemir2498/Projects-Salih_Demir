using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_CODEFIRST.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int BookYearOfPublication { get; set; }
        public int BookEditionNumber { get; set; }
        public int BookNumberOfPages { get; set; }
        public int BookQuantity { get; set; }
        public bool IsDeleted { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}