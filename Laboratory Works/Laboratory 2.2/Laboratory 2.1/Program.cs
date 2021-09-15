using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите коэффицент а ");
            double coefficientA, coefficientB, coefficientC, disriminant, x1, x2,x3;
            coefficientA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффицент b ");
            coefficientB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффицент c ");
            coefficientC = Convert.ToDouble(Console.ReadLine());
            disriminant = (Math.Round(Math.Pow(coefficientB, 2)-4 * coefficientA* coefficientC,2));
            if (disriminant>0)
            {
                x1 = ((-coefficientB + Math.Sqrt(disriminant))/2* coefficientA);
                x2= ((-coefficientB - Math.Sqrt(disriminant)) / 2 * coefficientA);
                Console.WriteLine("Уравнение имеет два корня"+ "\nтак x1=" + Math.Round(x1, 2) + "\nx2=" + Math.Round(x2, 2));
            }
            else
            {
                if (disriminant== 0) 
                {
                    x3 = Math.Round(-coefficientB / (2 * coefficientA), 2);
                    Console.WriteLine("Уравнение имеет один корень " + x3 );
                }
                 
                else
                {
                    Console.WriteLine("Уравнение не имеет решения");
                }
                
            }
            Console.ReadKey();


        }
    }
}
