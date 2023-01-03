using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Repository
{
	public class RepositoryContextSeed
	{
		public static async Task SeedAsync(RepositoryContext context, ILogger<RepositoryContextSeed> logger)
		{
			if (!context.PersonalInfo.Any())
			{
				context.PersonalInfo.Add(GetPreconfiguredPersonalInfo());
				await context.SaveChangesAsync();
				logger.LogInformation("Seed database associated with context {DbContextName}", typeof(RepositoryContext).Name);
			}
			if (!context.Skills.Any())
			{
				context.Skills.AddRange(GetPreconfiguredSkills());
				await context.SaveChangesAsync();
				logger.LogInformation("Seed database associated with context {DbContextName}", typeof(RepositoryContext).Name);
			}
			if (!context.Fact.Any())
			{
				context.Fact.Add(GetPreconfiguredFact());
				await context.SaveChangesAsync();
				logger.LogInformation("Seed database associated with context {DbContextName}", typeof(RepositoryContext).Name);
			}
		}

		private static PersonalInfo GetPreconfiguredPersonalInfo()
		{
			return new PersonalInfo
						{
								Id = Guid.NewGuid(),
								AboutMe = "My name is Mohsen Saberi",
								Age = "24",
								BirthDay = "12 November 1998",
								CityOfResidence = "Iran, Mashhad",
								Degree = "Bachelors in Mechanical Engineering",
								Email = "M.saberi1999@gmail.com",
								Name = "Mohsen Saberi",
								Github = "",
								Instagram ="",
								IsFreeLance = true,
								Linkdin = "",
								Phone = "+98 930 407 2620",
								Telegram = "" ,
								WhatsApp = ""
			};
		}

		private static IEnumerable<Skill> GetPreconfiguredSkills()
		{
			return new List<Skill>
			{
				new Skill() {Id = Guid.NewGuid() , Name = "Asp.NET" , Percent = 90},
				new Skill() {Id = Guid.NewGuid(), Name = "Csharp", Percent = 90}
			};
		}

		private static Fact GetPreconfiguredFact()
		{
			return new Fact
			{
				Id = Guid.NewGuid(),
				Awards = 5,
				HappyClient = 10,
				HoursOfSupport = 1800,
				Projects = 19
			};
		}

		private static IEnumerable<Music> GetPreconfiguredMusic()
		{
			return new List<Music>
			{
				new Music() {Id = Guid.NewGuid(), Name = "Yadame", Link = "https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1075851064&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true" },
				new Music() {Id = Guid.NewGuid(), Name = "dovom", Link = "https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1075851064&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true" },
				new Music() {Id = Guid.NewGuid(), Name = "sevom", Link = "https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1075851064&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true" }
			};
		}

		private static IEnumerable<Specialty> GetPreconfiguredSpecialties()
		{
			return new List<Specialty>
			{
				new Specialty() {Id = Guid.NewGuid(), Name = "Cross-Platform Developer"},
				new Specialty() {Id = Guid.NewGuid(), Name = "Mechanic Engeenier"},
				new Specialty() {Id = Guid.NewGuid(), Name = "Web Developer"},
				new Specialty() {Id = Guid.NewGuid(), Name = "Artificial Intelligence Engineer"},
				new Specialty() {Id = Guid.NewGuid(), Name = "Thinker"}

			};
		}
	}
}
