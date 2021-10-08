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
            Console.WriteLine("Task 5.1");
            Console.Write("Введите первое число ");
            int q1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            int q2 = Convert.ToInt32(Console.ReadLine());
            Avo(q1, q2);


            Console.WriteLine("Task 5.2");
            Console.WriteLine("Task 5.1");
            Console.Write("a= ");
            int w1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("b= ");
            int w2 = Convert.ToInt32(Console.ReadLine());
            Abo(w1, w2);


            Console.WriteLine("Task 5.3");
            Console.Write("Введите число ! ");
            int e1 = Convert.ToInt32(Console.ReadLine());
            Aco(e1);


            Console.WriteLine("Task 5.4");
            Console.Write("Введите число ! ");
            int r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Факториал будет= " + Factorial(r1));


            Console.WriteLine("Task 5.5.1");
            Console.Write("Введите первое натуральное число ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе натуральное число ");
            int n = Convert.ToInt32(Console.ReadLine());
            Azo(m, n);

            Console.WriteLine("Task 5.5.2");
            Console.Write("Введите первое натуральное число ");
            int t1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе натуральное число ");
            int t2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье натуральное число ");
            int t3 = Convert.ToInt32(Console.ReadLine());
            Azos(t1, t2, t3);


            Console.WriteLine("Task 5.6");
            Console.Write("Введите число n ");
            int h = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=h;i++)
            { Console.WriteLine(i+" Ряд Фибоначчи будет " + Fiban(i)); }

            
            
            Console.ReadKey();
        }
        static void Avo(int q1, int q2)
        {
            if (q1 > q2)
            { Console.WriteLine($"{q1} > {q2}"); }
            else
            { Console.WriteLine($"{q2} > {q1}"); }
        }

        static void Abo(int w1, int w2)
        {
            int best = w1;
            w1 = w2;
            w2 = best;
            Console.WriteLine($"a={w1} b={w2}");
        }

        static void Aco(int e1)
        {
            try
            {
                int proizved = 1;
                for (int i = 1; i < (e1 + 1); i++)
                {
                    checked
                    {
                        proizved *= i;
                    }
                }
                Console.WriteLine("Факториал числа будет " + proizved);
            }

            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: переполнение стека.");
            }

        }

        static int Factorial(int a)
        {
            if (a == 0) return 1;
            return a * Factorial(a - 1);
        }

        static int Azo(int m, int n)
        {
            int Nod = Math.Min(m, n);
            for (; Nod > 1; Nod--)
            {
                if ( m% Nod == 0 && n % Nod == 0)
                    break;
            }
            Console.WriteLine("Нод будет " + Nod);
            return Nod;



        }

        static int Azos(int t1, int t2,int t3)
        {
            int Nod = Math.Min(t1, Math.Min(t2, t3));
            for (; Nod > 1; Nod--)
            {
                if (t1 % Nod == 0 && t2 % Nod == 0 && t3 % Nod == 0)
                    break;
            }
            Console.WriteLine("Нод будет "+Nod);
            return Nod;

        }

        static long Fiban(int h)
        {
            if (h == 1 || h == 2) return 1;
            else return Fiban(h - 1) + Fiban(h - 2);
        }
    }
}
