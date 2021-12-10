using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._12._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 12.2");
            Rational r1 = new Rational(4, 8);
            Console.WriteLine(r1.Equals(0.5));
            Console.WriteLine(++r1);
            Console.WriteLine($"({17.0 / 21} < {15.0 / 19})? {new Rational(17, 21) < new Rational(15, 19)}");
            Console.WriteLine((Rational)0.125);
            Console.WriteLine(r1 % new Rational(5, 4));
        }
    }
}
