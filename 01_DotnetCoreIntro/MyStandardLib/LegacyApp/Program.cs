using MyStandardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            Console.WriteLine(d1.Hello("Katharina"));
            d1.OldHello("Hello, Stephanie!");
        }
    }
}
