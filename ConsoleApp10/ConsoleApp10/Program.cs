using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double b = double.Parse(a);
            Console.WriteLine(Math.Round(b, 2));
            Console.ReadKey();
        }
    }
}
