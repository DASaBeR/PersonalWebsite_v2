using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PersonalWebsite_v2.Contracts;
using PersonalWebsite_v2.Models;
using PersonalWebsite_v2.Repository;

namespace PersonalWebsite_v2.Extentions
{
	public static class ServiceExtentions
	{
		public static void ConfigureSqlContext(this IServiceCollection services,IConfiguration configuration) =>
			services.AddDbContext<RepositoryContext>(opts =>
			opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"),
				sqlServerOptionsAction: sqlOptions =>
				{
					sqlOptions.EnableRetryOnFailure();
				}
				));


		public static void ConfigureRepositoryManager(this IServiceCollection services) =>
				services.AddScoped<IRepositoryManager, RepositoryManager>();


		public static void ConfigureIdentity(this IServiceCollection services)
		{
			var builder = services.AddIdentityCore<User>(o =>
			{
				o.Password.RequireDigit = true;
				o.Password.RequireLowercase = false;
				o.Password.RequireUppercase = false;
				o.Password.RequireNonAlphanumeric = false;
				o.Password.RequiredLength = 10;
				o.User.RequireUniqueEmail = true;
			});
			builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole),
		 builder.Services);
			builder.AddEntityFrameworkStores<RepositoryContext>()
			.AddDefaultTokenProviders();
		}

	}
}
