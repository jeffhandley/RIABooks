
namespace RIABooks.Web.Services
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;
    using RIABooks.Web.Models;


    // Implements application logic using the BookModel context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class BookService : DbDomainService<BookModel>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Authors' query.
        public IQueryable<Author> GetAuthors()
        {
            return this.DbContext.Authors;
        }

        public void InsertAuthor(Author author)
        {
            DbEntityEntry<Author> entityEntry = this.DbContext.Entry(author);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.Authors.Add(author);
            }
        }

        public void UpdateAuthor(Author currentAuthor)
        {
            this.DbContext.Authors.AttachAsModified(currentAuthor, this.ChangeSet.GetOriginal(currentAuthor), this.DbContext);
        }

        public void DeleteAuthor(Author author)
        {
            DbEntityEntry<Author> entityEntry = this.DbContext.Entry(author);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.Authors.Attach(author);
                this.DbContext.Authors.Remove(author);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Books' query.
        public IQueryable<Book> GetBooks()
        {
            return this.DbContext.Books;
        }

        public void InsertBook(Book book)
        {
            DbEntityEntry<Book> entityEntry = this.DbContext.Entry(book);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.Books.Add(book);
            }
        }

        public void UpdateBook(Book currentBook)
        {
            this.DbContext.Books.AttachAsModified(currentBook, this.ChangeSet.GetOriginal(currentBook), this.DbContext);
        }

        public void DeleteBook(Book book)
        {
            DbEntityEntry<Book> entityEntry = this.DbContext.Entry(book);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.Books.Attach(book);
                this.DbContext.Books.Remove(book);
            }
        }
    }
}


