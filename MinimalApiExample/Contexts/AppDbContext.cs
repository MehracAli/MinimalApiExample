using Microsoft.EntityFrameworkCore;
using MinimalApiExample.Entities;

namespace MinimalApiExample.Contexts
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{
		}

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	optionsBuilder.UseSqlServer("server=localhost,1435;database=Northwind;uid=sa;password=MehrajAli96#;trust server certificate=true");
		//	base.OnConfiguring(optionsBuilder);
		//}

		public DbSet<Category> Categories => Set<Category>();
	}
}
