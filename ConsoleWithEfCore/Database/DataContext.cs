using ConsoleWithEfCore.Entities;
using ConsoleWithEfCore.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleWithEfCore.Database
{
    public class DataContext : DbContext
    {
        private readonly ServiceCollection _services;

        public DataContext(ServiceCollection services)
        {
            _services = services;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var servicesProvider = _services.BuildServiceProvider();
            var settings = servicesProvider.GetService<Settings>();

            optionsBuilder.UseSqlServer($"{settings?.DefaultConnection}");
        }

        public DbSet<Student> Students { get; set; }
    }
}
