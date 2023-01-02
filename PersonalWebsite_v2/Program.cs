using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using PersonalWebsite_v2.Extentions;
using PersonalWebsite_v2.Models;
using PersonalWebsite_v2.Repository;

namespace test
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			// Add services to the container.
			builder.Services.AddControllersWithViews();
			//builder.Services.AddDefaultIdentity<User>().AddRoles<IdentityRole>().AddEntityFrameworkStores<RepositoryContext>();
			//var host = CreateHostBuilder(args).Build();
			//host.MigrateDatabase<RepositoryContext>((context, services) =>
			//{
			//	var logger = services.GetService<ILogger<RepositoryContextSeed>>();
			//	RepositoryContextSeed.SeedAsync(context, logger).Wait();

			//});
			//host.Run();

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

			app.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
				Host.CreateDefaultBuilder(args)
						.ConfigureWebHostDefaults(webBuilder =>
						{
						});
	}
}