using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SalesNewApp.Models;
using SalesNewApp.Data;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SalesNewAppContext>(options =>
    options.UseMySql("server=localhost;uid=developer;initial catalog =NEW_CRUD;pwd=Zx30000zx30000!;database=salesnewappdb",
                            Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.33-mysql")));
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<SeedingService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

using (var context = new SalesNewAppContext());

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
