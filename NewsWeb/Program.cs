using Application;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using NewsWeb.Areas.Admin.Data;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services
    .AddApplication()
    .AddInfrastructure();

builder.Services.AddRazorPages();

builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

Log.Logger = new LoggerConfiguration()
	.WriteTo.Console()
	.CreateLogger();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
	options.UseSqlServer(@"Server=DESKTOP-KOMMVAR\SQLEXPRESS01;Database=NewsWeb;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=false"); 
});

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();


app.MapAreaControllerRoute(
	name: "Area",
	areaName: "Admin",
	pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


