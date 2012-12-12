using System.ComponentModel.DataAnnotations;

namespace RIABooks.Web.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [StringLength(25)]
        public string FirstName { get; set; }

        [StringLength(25)]
        public string LastName { get; set; }
    }
}
