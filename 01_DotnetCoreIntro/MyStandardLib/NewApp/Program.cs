using MyStandardLib;
using System;

namespace NewApp
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
