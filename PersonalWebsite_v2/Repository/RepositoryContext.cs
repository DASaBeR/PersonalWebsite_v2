using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalWebsite_v2.Models;
using PersonalWebsite_v2.Models.Configuration;

namespace PersonalWebsite_v2.Repository
{
	public class RepositoryContext : IdentityDbContext<User>
	{
		public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new RoleConfiguration());
		}

		public DbSet<Fact> Facts { get; set; }
		public DbSet<Music> Musics { get; set; }
		public DbSet<PersonalInfo> PersonalInfos { get; set; }
		public DbSet<Skill> Skills { get; set; }
		public DbSet<Speciality> Specialities { get; set; }

	}
}
