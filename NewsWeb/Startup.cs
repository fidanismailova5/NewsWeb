using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace NewsWeb
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			// Add other services as needed

			// Register NewsContext as a scoped service
			services.AddDbContext<ApplicationContext>(options =>
			{
				options.UseSqlServer(@"Server=DESKTOP-KOMMVAR\SQLEXPRESS01;Database=NewsWeb;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=false"); // Replace with your connection string
			});
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			// Configure middleware and routing
		}
	}
}
