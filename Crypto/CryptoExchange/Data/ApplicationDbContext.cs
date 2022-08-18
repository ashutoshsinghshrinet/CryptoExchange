using Microsoft.EntityFrameworkCore;
using CryptoExchange.Models;

namespace CryptoExchange.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Item> Currencies { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
