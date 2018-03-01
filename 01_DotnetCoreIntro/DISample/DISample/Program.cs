using Microsoft.Extensions.DependencyInjection;
using System;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterServices();
            // var controller = new HomeController(new HelloService());
            var controller = Container.GetService<HomeController>();
            string response = controller.Index("Matthias");
            Console.WriteLine(response);
        }

        static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IHelloService, HelloService>();
            services.AddTransient<HomeController>();
            Container = services.BuildServiceProvider();
        }

        public static IServiceProvider Container { get; private set; }
    }
}
