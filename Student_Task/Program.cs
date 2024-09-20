using Microsoft.EntityFrameworkCore;
using Student_Task.Models;
using Student_Task.Repository;

namespace Student_Task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<studentDb>(option =>
            {
                option.UseSqlServer("Server=DESKTOP-84KCKJI\\SQLEXPRESS;Database=StudTask;Trusted_Connection=True;TrustServerCertificate=True");
            });
            builder.Services.AddScoped<Istudentservice, studentservice>();
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
                pattern: "{controller=Student}/{action=form}/{id?}");

            app.Run();
        }
    }
}
