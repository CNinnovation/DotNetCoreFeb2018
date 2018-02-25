using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConfigurationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").AddCommandLine(args);
            Configuration = builder.Build();

            string val1 = Configuration.GetSection("DemoSection1")["Setting1"];
            Console.WriteLine(val1);
            string conn1 = Configuration.GetConnectionString("DBConnection1");
            Console.WriteLine(conn1);
        }

        public static IConfigurationRoot Configuration { get; private set; }
    }
}
