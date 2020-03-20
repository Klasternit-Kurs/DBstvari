using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBstvari.Server.EF
{
	public class DB : DbContext
	{
		public DbSet<Shared.Osoba> Osobas { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=tcp:aspserverklasternit.database.windows.net,1433;Initial Catalog=ASPnetEF;Persist Security Info=False;User ID=ASPadmin;Password=#12!admin!21#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Shared.Osoba>().HasKey(o => o.ID);
		}
	}
}
