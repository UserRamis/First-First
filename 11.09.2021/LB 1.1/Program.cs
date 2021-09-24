using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Приветствуем вас, " + name + "!");
            Console.ReadKey();
        }
    }
}
