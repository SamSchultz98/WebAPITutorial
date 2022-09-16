using Microsoft.EntityFrameworkCore;

namespace WebAPITutorial.Models
{
    public class AppDbContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
