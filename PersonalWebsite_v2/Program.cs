using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using PersonalWebsite_v2.Extentions;
using PersonalWebsite_v2.Models;
using PersonalWebsite_v2.Repository;

namespace PersonalWebsite_v2
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			builder.Services.ConfigureSqlContext(builder.Configuration);
			builder.Services.ConfigureRepositoryManager();
			builder.Services.AddDefaultIdentity<User>().AddRoles<IdentityRole>().AddEntityFrameworkStores<RepositoryContext>();

			builder.Services.ConfigureApplicationCookie(options =>
			{
				options.Events.OnRedirectToLogin = context =>
				{
					context.Response.StatusCode = StatusCodes.Status403Forbidden;
					return Task.CompletedTask;
				};
				options.Events.OnRedirectToAccessDenied = context =>
				{
					context.Response.StatusCode = StatusCodes.Status403Forbidden;
					return Task.CompletedTask;
				};
			});
			builder.Services.ConfigureIdentity();


			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MigrateDatabase<RepositoryContext>((context, services) =>
			{
				var logger = services.GetService<ILogger<RepositoryContextSeed>>();
				RepositoryContextSeed.SeedAsync(context, logger).Wait();

			});

			app.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}

	}
}