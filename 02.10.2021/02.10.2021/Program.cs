using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _02._10._2021
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Введите коэф-ент а ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите коэф-ент b ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите коэф-ент c ");
            int c = Convert.ToInt32(Console.ReadLine());
            SquareEquastion(a, b, c);



            Console.WriteLine("\nTask 2");
            int element1, element2, index1, index2, temp;
            Random rnd = new Random();
            int[] randomarray = new int[20];
            for (int u = 0; u < 20; u++)
                randomarray[u] = rnd.Next(0, 100);
            Console.WriteLine(string.Join(", ", randomarray));
            Console.Write("Введите первый элемент массива: ");
            element1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второй элемент массива: ");
            element2 = Convert.ToInt32(Console.ReadLine());
            index1 = Array.IndexOf(randomarray, element1);
            index2 = Array.IndexOf(randomarray, element2);
            temp = randomarray[index1];
            randomarray[index1] = randomarray[index2];
            randomarray[index2] = temp;
            Console.WriteLine(string.Join(", ", randomarray));



            Console.WriteLine("\nTask 3");
            Console.Write("Введите длину массива: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int[] array2 = new int[n2];
            for (int i = 0; i < n2; i++)
                array2[i] = rnd.Next(0, 100);
            Console.WriteLine("массив: " + string.Join(", ", array2));
            for (int k = 0; k < n2; k++)
            {
                for (int j = 0; j < n2; j++)
                {
                    if (array2[k] < array2[j])
                    {
                        int buffer = array2[k];
                        array2[k] = array2[j];
                        array2[j] = buffer;
                    }
                }
            }
            Console.WriteLine("отсортированный массив: " + string.Join(", ", array2));



            Console.WriteLine("\nTask 4");
            Console.Write("Введите длину массива ");
            int r = Convert.ToInt32(Console.ReadLine());
            int[] vs = new int[r];
            for (int l = 0; l < r; l++)
            {
                Console.Write("Введите элемент " + (l + 1) + " ");
                vs[l] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Join(", ", vs));
            int product = 0;
            double SredArifm = 0;
            Console.WriteLine(Vss(ref product, out SredArifm, vs));



            Console.WriteLine("\nTask 5");
            try
            {
                Console.Write("Введите число ");
                string n = Console.ReadLine();
                if (n == "exit" || n == "выход")
                { Environment.Exit(0); }
                int n1 = Convert.ToInt32(n);
                if (n1 < 9 && n1 > 0)
                {

                    switch (n1)
                    {
                        case 1: Console.WriteLine("\n##\n #\n #\n #\n###"); break;
                        case 2: Console.WriteLine("\n###\n #\n #\n #\n#\n###"); break;
                        case 3: Console.WriteLine("\n ##\n# #\n #\n #\n #\n# #\n ##"); break;
                        case 4: Console.WriteLine("\n# #\n# #\n# #\n####\n #\n #\n #"); break;
                        case 5: Console.WriteLine("\n####\n#\n#\n ##\n #\n #\n###"); break;
                        case 6: Console.WriteLine("\n ##\n# #\n#\n###\n# #\n# #\n ##"); break;
                        case 7: Console.WriteLine("\n####\n #\n #\n #\n #\n #\n #"); break;
                        case 8: Console.WriteLine("\n ##\n# #\n# #\n ##\n# #\n# #\n ##"); break;
                        case 9: Console.WriteLine("\n ##\n# #\n# #\n ###\n #\n #\n ##"); break;
                    }
                }
                else
                {

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Thread.Sleep(3000);

                }

                Console.WriteLine("Ошибка! Вы не ввели число от 0 до 9!");
            }
            catch (FormatException)
            { Console.WriteLine("Ошибка!"); }
            Console.ReadKey();
           
            Console.ReadKey();


        }
            static void SquareEquastion(int a, int b, int c)
            {
                double dis = b * b - 4 * a * c;
                if (dis < 0)
                { Console.WriteLine("Уравнение не имеет решения!"); }
                else if (dis == 0)
                {
                    double x = -b / 2 * a;
                    Console.WriteLine($"x= {x}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(dis)) / 2 * a;
                    double x2 = (-b - Math.Sqrt(dis)) / 2 * a;
                    Console.WriteLine("x1= " + x1 + "\nx2= " + x2);

                }
                Console.ReadKey();
            }


        static int Vss (ref int product, out double SredArifm, params int[] integers)
        {
            int sum = 0;
            for (int i = 0; i < integers.Length; i++)  
            sum += integers[i];

            product = integers[0];
            for (int i = 0; i < integers.Length; i++)
                product *= integers[i];

            SredArifm = sum / integers.Length;
            Console.Write("Произведение элементов массива: " + product + "\nСреднее арифметическое элементов" +
                    "массива: " + SredArifm + "\nСумма элементов массива: ");
            return sum;



        }










































































        }
}
