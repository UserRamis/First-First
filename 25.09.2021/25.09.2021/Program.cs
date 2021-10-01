using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._09._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1.1");
            Console.Write("Введите трехзначное число ");
            int q = Convert.ToInt32(Console.ReadLine());
            if (q / 100 == q % 10)
            {
                Console.WriteLine("палиндром");
            }
            else
            {
                Console.WriteLine("не палиндром");
            }


            Console.WriteLine("Task 1.2");
            Console.Write("Введите длину форточки ");
            double w1, w2, d, w4;
            w1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину форточки ");
            w2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите диаметр головы ");
            d = Convert.ToDouble(Console.ReadLine());
            w4 = d / 2;
            if (w1 - 1 >= w4 || w2 - 1 >= w4)
            {
                Console.WriteLine("Вася сможет достичь своей цели!");
            }

            else
            {
                Console.WriteLine("Вася не сможет достичь своей цели");
            }


            Console.WriteLine("Task 1.3");
            Console.Write("Введите число от 1 до 7 ");
            int e;
            e = Convert.ToInt32(Console.ReadLine());
            switch (e)
            {
                case 1: Console.WriteLine("Понедельник"); break;
                case 2: Console.WriteLine("Вторник"); break;
                case 3: Console.WriteLine("Среда"); break;
                case 4: Console.WriteLine("Четверг"); break;
                case 5: Console.WriteLine("Пятница"); break;
                case 6: Console.WriteLine("Суббота"); break;
                case 7: Console.WriteLine("Воскресенье"); break;
            }



            Console.WriteLine("Task 1.4");
            Console.Write("Введите число от 6 до 14 ");
            try
            {
                int r;
                r = Convert.ToInt32(Console.ReadLine());
                switch (r)
                {
                    case 6: Console.WriteLine("щестерка"); break;
                    case 7: Console.WriteLine("семерка"); break;
                    case 8: Console.WriteLine("восьмерка"); break;
                    case 9: Console.WriteLine("девятка"); break;
                    case 10: Console.WriteLine("десятка"); break;
                    case 11: Console.WriteLine("валлет"); break;
                    case 12: Console.WriteLine("дама"); break;
                    case 13: Console.WriteLine("король"); break;
                    case 14: Console.WriteLine("туз"); break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
            finally
            {
                Console.WriteLine("Finnaly");
            }



            Console.WriteLine("Task 1.5");
            Console.Write("Введите высоту над поверхностю(км) ");
            double t1, t2;
            string t3;
            t3 = "Тогда расстояние до линии горизонта будет ";
            t1 = Convert.ToInt32(Console.ReadLine());
            t2 = Math.Sqrt(Math.Pow(6370 + t1, 2) - 6370 * 6370);
            switch (t1)
            {
                case 1:
                    t1 = 1;
                    Console.WriteLine(t3 + t2);
                    break;
                case 2:
                    t1 = 2;
                    Console.WriteLine(t3 + t2);
                    break;
                case 3:
                    t1 = 3;
                    Console.WriteLine(t3 + t2);
                    break;
                case 4:
                    t1 = 4;
                    Console.WriteLine(t3 + t2);
                    break;
                case 5:
                    t1 = 5;
                    Console.WriteLine(t3 + t2);
                    break;
                case 6:
                    t1 = 6;
                    Console.WriteLine(t3 + t2);
                    break;
                case 7:
                    t1 = 7;
                    Console.WriteLine(t3 + t2);
                    break;
                case 8:
                    t1 = 8;
                    Console.WriteLine(t3 + t2);
                    break;
                case 9:
                    t1 = 9;
                    Console.WriteLine(t3 + t2);
                    break;
                case 10:
                    t1 = 10;
                    Console.WriteLine(t3 + t2);
                    break;
            }



            Console.WriteLine("Task 1.6");
            Console.Write("Введите число n ");
            double Y = Convert.ToDouble(Console.ReadLine());
            if (Y >= 1 || Y <= 9)
            {
                Console.WriteLine("1*n=" + Y + "\n2*n=" + Y * 2 + "\n3*n=" + Y * 3 + "\n4*n=" + Y * 4 + "\n5*n=" + Y * 5 + "\n6*n=" + Y * 6 + "\n7*n=" + Y * 7 + "\n8*n=" + Y * 8 + "\n9*n=" + Y * 9 + "\n10*n=" + Y * 10);
            }
            else
                Console.WriteLine("Ошибка");


            Console.WriteLine("Task 1.7");
            int u1, u2;
            Console.Write("Введите количество чисел в массиве ");
            u1 = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[u1];
            int sum = 0;
            try
            {
                for (int x = 0; x < u1; x++)
                {
                    Console.Write($"Введите число {x + 1}:");
                    nums[x] = Convert.ToInt32(Console.ReadLine());
                    if ((x + 1) < u1 & nums[x] < 0)
                    {
                        throw new FormatException();
                    }
                    if (nums[x] > 0)
                    {
                        sum += nums[x];
                    }
                }
                u2 = sum / (u1 - 1);
                Console.WriteLine($"Среднее арифметическое: {u2}");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка");
            }




            Console.WriteLine("Task 1.8");
            Console.Write("Введите последовательность чисел ");
            int[] vs = new int[10];
            for (int z = 1; z < 10; z++)
            {
                Console.WriteLine($"Введите число {z + 1}: ");
                vs[z] = (Convert.ToInt32(Console.ReadLine()));
            }
            try
            {
                for (int z = 1; z < 10; z++)
                {
                    if (z == 9)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    Console.WriteLine($"{z + 2} элемент прерывает последовательность");
                    break;
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Последовательность возратсает");
            }


            Console.WriteLine("Task 1.9");
            int num;
            int i;

            Console.WriteLine("Введите число: ");
            sum = 0;
            i = 0;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                i++;
                if (i % 3 != 0)
                {
                    continue;
                }
                sum = sum + num;
            } while (num != 0);

            Console.WriteLine("sum = {0}", sum);



            Console.WriteLine("Task 1.10");
            double sim = 0;
            double number;
            Console.WriteLine("Введите число:");
            number = 1;
        begLoop:
            number = Double.Parse(Console.ReadLine());
            if (number != 0)
            {
                sim += number;
                goto begLoop;
            }
            Console.WriteLine("sum = {0}", sum);


































































            Console.ReadKey();
        }
    }
}
