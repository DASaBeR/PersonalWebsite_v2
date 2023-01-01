using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalWebsite_v2.Models;
using PersonalWebsite_v2.Models.Configuration;

namespace PersonalWebsite_v2.Repository
{
	public class RepositoryContext : IdentityDbContext<User>
	{
		public RepositoryContext(DbContextOptions options):base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new RoleConfiguration());
		}

		public DbSet<PersonalInfo> PersonalInfo { get; set; }
		public DbSet<Skill> Skills { get; set; }
		public DbSet<Fact> Facts { get; set; }


	}
}
