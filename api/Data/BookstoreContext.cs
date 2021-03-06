using Microsoft.EntityFrameworkCore;
using Fisher.Bookstore.Api.Models;
using Fisher.Bookstore.Api;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Fisher.Bookstore.Api.Data
{
    public class BookstoreContext : IdentityDbContext<ApplicationUser>
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder) => base.OnModelCreating(builder);
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
