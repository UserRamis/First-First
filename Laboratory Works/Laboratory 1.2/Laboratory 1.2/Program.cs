using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_1._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите первое число ");
            double chislo1, chislo2, chislo3;
            chislo1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число ");
            chislo2 = Convert.ToDouble(Console.ReadLine());
            
            if (chislo2 > 0)
            {
                chislo3 = chislo1 / chislo2;
                Console.WriteLine("Ответ будет " + Math.Round(chislo3, 2));

            }
            
            else
            {
                if (chislo2 < 0)
                {
                    chislo3 = chislo1 / chislo2;
                    Console.WriteLine("Ответ будет " + Math.Round(chislo3, 2));
                }
                else
                {
                    Console.WriteLine("Нет решения");

                }
                    
            }
            Console.ReadKey();
        }
    }
}
