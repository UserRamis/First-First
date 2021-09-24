using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1.1");
            double a1, a2, a3, a4;
            Console.Write("Введите количество секунд ");
            a1 = Convert.ToDouble(Console.ReadLine());
            a2 = Math.Floor(a1 / 3600);
            a3 = Math.Floor(a1 / 60);
            Console.WriteLine("Полных часов прошло " + a2 + "\nПолных минут прошло " + a3);


            Console.WriteLine("Task1.2");
            double s1, s2, s3, s4, s5, s6;
            Console.Write("Введите длину прямоугольника ");
            s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника ");
            s2 = Convert.ToDouble(Console.ReadLine());
            s3 = 130;
            s4 = s1 * s2;
            s5 = s3 * s3;
            if (s4 > s5)
            {
                s6 = s4 / s5;
                Console.WriteLine(Math.Floor(s6) + " квадрата можно вырезать с прямоугольника ");
            }
            else
                Console.WriteLine("Нет решения");



            Console.WriteLine("Task1.3");
            Console.Write("n= ");
            int d, d1;
            d = Convert.ToInt32(Console.ReadLine());
            if (d == 12)
            {
                Console.WriteLine("x=1");
            }
            else
            {
                d1 = d + 1;
                Console.WriteLine("x= " + d1);
            }


            Console.WriteLine("Task1.4");
            double f1, f2, f3, f4, f5, f6, f7;
            Console.Write("Введите первое число ");
            f1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число ");
            f2 = Convert.ToDouble(Console.ReadLine());
            f3 = double.Parse(f1.ToString() + f2.ToString());
            f4 = Math.Floor(f3 / 10);
            f5 = f3 - (f4 * 10);
            f6 = f1 + f2;
            f7 = f1 * f2;
            Console.WriteLine("Число десятков= " + f4 + "\nЧисло единиц= " + f5 + "\nСумма= " + f6 + "\nУмножение= " + f7);


            Console.WriteLine("Task1.5");
            double g1, g2, g3, g4;
            Console.Write("Введите первое число ");
            g1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число ");
            g2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число ");
            g3 = Convert.ToDouble(Console.ReadLine());
            g4 = double.Parse(g2.ToString() + g3.ToString() + g1.ToString());
            Console.WriteLine("Полученный результат будет " + g4);


            Console.WriteLine("Task1.6");
            // 2 последняя цифра числа x
            double h1, h2, h3;
            h1 = 37 * 10;
            h2 = h1 + 2;
            Console.WriteLine("Число x= " + h2);


            Console.WriteLine("Task1.7");
            string j1, j2, k1, k2;
            byte doubledigit1, doubledigit2;
            double sumofdoubledigit, dozens, unity;
            Console.Write("a2(десятки первого числа)= ");
            j2 = Console.ReadLine();
            Console.Write("a1(десятки первого числа)= ");
            j1 = Console.ReadLine();
            Console.Write("b2(десятки первого числа)= ");
            k2 = Console.ReadLine();
            Console.Write("b1(десятки первого числа)= ");
            k1 = Console.ReadLine();
            doubledigit1 = Convert.ToByte(j2 + j1);
            doubledigit2 = Convert.ToByte(k2 + k1);
            sumofdoubledigit = doubledigit2 + doubledigit1;
            dozens = Math.Floor(sumofdoubledigit / 10);
            unity = sumofdoubledigit % 10;
            Console.WriteLine("Первое число= " + doubledigit1 + "\nВторое число= " + doubledigit2 + "\nДесятков в полученном числе= " + dozens + "\nЕдиниц в полученном числе " + unity);


            Console.WriteLine("Task1.9");
            bool A, B, C, first, second, third;
            A = true;
            B = false;
            C = false;
            first = A | B;
            second = A & B;
            third = B | C;
            Console.WriteLine("а-" + first + "б" + second + "в" + third);

















            Console.ReadKey();
        }
    }
}
