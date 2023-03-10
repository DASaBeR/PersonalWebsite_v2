using Microsoft.AspNetCore.Identity;
using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Repository
{
	public class RepositoryContextSeed
	{

		public static async Task SeedAsync(RepositoryContext context, ILogger<RepositoryContextSeed> logger)
		{
			try
			{
				if (!context.PersonalInfos.Any())
				{
					context.PersonalInfos.Add(GetPreconfiguredPersonalInfo());
					await context.SaveChangesAsync();
					logger.LogInformation("Seed database associated with context {DbContextName}", typeof(RepositoryContext).Name);
				}
				if (!context.Skills.Any())
				{
					context.Skills.AddRange(GetPreconfiguredSkills());
					await context.SaveChangesAsync();
					logger.LogInformation("Seed database associated with context {DbContextName}", typeof(RepositoryContext).Name);
				}
				if (!context.Facts.Any())
				{
					context.Facts.Add(GetPreconfiguredFact());
					await context.SaveChangesAsync();
					logger.LogInformation("Seed database associated with context {DbContextName}", typeof(RepositoryContext).Name);
				}
				if (!context.Musics.Any())
				{
					context.Musics.AddRange(GetPreconfiguredMusic());
					await context.SaveChangesAsync();
					logger.LogInformation("Seed database associated with context {DbContextName}", typeof(RepositoryContext).Name);
				}
				if (!context.Specialities.Any())
				{
					context.Specialities.AddRange(GetPreconfiguredSpecialties());
					await context.SaveChangesAsync();
					logger.LogInformation("Seed database associated with context {DbContextName}", typeof(RepositoryContext).Name);
				}
				if (!context.Users.Any())
				{
					context.Users.Add(GetUser());
					await context.SaveChangesAsync();
					logger.LogInformation("Seed database associated with context {DbContextName}", typeof(RepositoryContext).Name);
				}
				if (!context.UserRoles.Any())
				{

					context.UserRoles.Add(new IdentityUserRole<string>
					{
						UserId = context.Users.First().Id,
						RoleId = context.Roles.First().Id
					});
					await context.SaveChangesAsync();
					logger.LogInformation("Seed database associated with context {DbContextName}", typeof(RepositoryContext).Name);

				}
			}
			catch (Exception ex)
			{

				throw ex;
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
								Github = "asdasd",
								Instagram ="asdasdads",
								IsFreeLance = true,
								Linkdin = "asdadsasd",
								Phone = "+98 930 407 2620",
								Telegram = "asdasdasd" ,
								WhatsApp = "asdasdasd"
			};
		}

		private static IEnumerable<Skill> GetPreconfiguredSkills()
		{
			return new List<Skill>
			{
				new Skill() {Id = Guid.NewGuid() , Name = "Asp.NET" , Percent = 90},
				new Skill() {Id = Guid.NewGuid(), Name = "Csharp", Percent = 85},
				new Skill() {Id = Guid.NewGuid(), Name = "Python", Percent = 75}
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

		private static IEnumerable<Speciality> GetPreconfiguredSpecialties()
		{
			return new List<Speciality>
			{
				new Speciality() {Id = Guid.NewGuid(), Name = "Cross-Platform Developer"},
				new Speciality() {Id = Guid.NewGuid(), Name = "Mechanic Engeenier"},
				new Speciality() {Id = Guid.NewGuid(), Name = "Web Developer"},
				new Speciality() {Id = Guid.NewGuid(), Name = "Artificial Intelligence Engineer"},
				new Speciality() {Id = Guid.NewGuid(), Name = "Thinker"}

			};
		}

		private static User GetUser()
		{
			return new User
			{
				Id = Guid.NewGuid().ToString(),
				FirstName = "Mohsen",
				LastName = "Saberi",
				UserName = "<You_UserName>",
				NormalizedUserName = "DA_SABER",
				Email = "m.saberi1999@gmail.com",
				NormalizedEmail = "M.SABERI1999@GMAIL.COM",
				EmailConfirmed = true,
				PasswordHash = "<You_PaswwordHash>",
				SecurityStamp = "I7RKTNIG7Z4MFJTE25PRHNDYPTTQATTT",
				ConcurrencyStamp = "98cec0e0-0bf7-4aa2-91a5-7339a44bbef4",
				PhoneNumber = "989304072620",
				PhoneNumberConfirmed = true,
				AccessFailedCount = 0,
				LockoutEnabled = true,
				LockoutEnd = null,
				TwoFactorEnabled = false
			};
		}

	}
}
