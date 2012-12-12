using System.Data.Entity;

namespace RIABooks.Web.Models
{
    public class BookModel : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}