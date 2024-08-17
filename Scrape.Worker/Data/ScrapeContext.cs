using Microsoft.EntityFrameworkCore;
using ScrapeAPI.Model;

namespace ScrapeAPI.Data
{
    public class ScrapeContext: DbContext 
    {
        public ScrapeContext(DbContextOptions<ScrapeContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
