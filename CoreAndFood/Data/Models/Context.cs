using Microsoft.EntityFrameworkCore;

namespace CoreAndFood.Data.Models
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
		optionsBuilder.UseSqlServer("server=DESKTOP-H6BPHOP\\SQLEXPRESS; database=CoreAndFood;integrated security=true")
		}
		public DbSet<Food> Foods { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}
