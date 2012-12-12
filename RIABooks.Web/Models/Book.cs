using System.ComponentModel.DataAnnotations;

namespace RIABooks.Web.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public Author Author { get; set; }
        public int AuthorId { get; set; }

        public BookType BookType { get; set; }
    }
}
