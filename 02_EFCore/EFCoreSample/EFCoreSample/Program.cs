using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EFCoreSample
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterServices();
            CreateDatabase();
        }

        private static void RegisterServices()
        {
            string connectionString = @"server=(localdb)\mssqllocaldb;database=BooksSample42;trusted_connection=true";
            var services = new ServiceCollection();
            services.AddDbContext<BooksContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            Container = services.BuildServiceProvider();
        }
        public static IServiceProvider Container { get; private set; }

        private static void CreateDatabase()
        {
            var context = Container.GetService<BooksContext>();
            bool created = context.Database.EnsureCreated();
            Console.WriteLine($"db created {created}");
        }
    }
}
