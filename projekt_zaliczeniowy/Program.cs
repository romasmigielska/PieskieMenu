using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using projekt_zaliczeniowy.Data;
using projekt_zaliczeniowy.Models;
using System.Data;

namespace projekt_zaliczeniowy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("projekt_zaliczeniowyContextConnection") ?? throw new InvalidOperationException("Connection string 'projekt_zaliczeniowyContextConnection' not found.");

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer("Data Source=DESKTOP-FS538Q2\\SQLEXPRESS;Initial Catalog=PieskieMenu;Integrated Security=True;Encrypt=False;"));

            //builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //   .AddEntityFrameworkStores<DataContext>();
            //builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<DataContext>()
            //    .AddDefaultTokenProviders();

            builder.Services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<DataContext>()
    .AddDefaultTokenProviders();

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
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapRazorPages();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}