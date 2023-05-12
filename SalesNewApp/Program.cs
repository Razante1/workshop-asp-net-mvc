using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesNewApp.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SalesNewAppContext>(options =>
    options.UseMySql("server=localhost;uid=developer;initial catalog =NEW_CRUD;pwd=Zx30000zx30000!;database=salesnewappdb",
                            Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.33-mysql")));
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
