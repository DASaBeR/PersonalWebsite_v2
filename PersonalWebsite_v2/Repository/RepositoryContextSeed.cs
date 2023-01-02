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
								Name = "Mohsen Saberi"
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
	}
}
