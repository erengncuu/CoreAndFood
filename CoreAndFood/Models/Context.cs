using Microsoft.EntityFrameworkCore;

namespace CoreAndFood.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-H6BPHOP\\SQLEXPRESS; database=CoreAndFood;integrated security=true;TrustServerCertificate=True");
        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
