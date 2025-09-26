using Microsoft.EntityFrameworkCore;
namespace BookStore.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Models.Book> Books { get; set; }
    }
}
