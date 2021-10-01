using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год ");
            string year = Console.ReadLine();
            Console.Write("Введите число ");
            DateTime dt = Convert.ToDateTime($"01.01.{year}");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 1 || num > 365)
                Console.WriteLine("Столько дней не бывает!");
            else
            {
                dt = dt.AddDays(num - 1);
                Console.WriteLine(dt.ToString("d MMMM"));
            }

































































































































            Console.ReadKey();

        }
    }
}
