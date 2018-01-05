using System;
using Microsoft.EntityFrameworkCore;

namespace Gummi.Models
{
	public class GummiContext : DbContext
	{
		public DbSet<Product> Products { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder
				.UseMySql(@"Server=localhost;Port=8889;database=gummi;uid=root;pwd=root;");
	}
}
