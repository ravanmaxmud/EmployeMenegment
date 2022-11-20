using EmpleyeMengment.DataBase;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EmpleyeMengment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMvc();
            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute(
             name: "default",
             pattern: "{controller=employe}/{action=index}");

            app.Run();
        }


    }
}