using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
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
