using EmpleyeMengment.DataBase.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace EmpleyeMengment.DataBase
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-0A48AOT\\SQLEXPRESS; Database = Employes; Trusted_Connection = True;TrustServerCertificate=True;");
        }
        public DbSet<Employes> Employes { get; set; }
    }
}
