using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 1.1");
            Console.Write("Введите число ");
            int q = Convert.ToInt32(Console.ReadLine());
            if (q < 0)
            {
                Console.WriteLine($"Абсолютное значение: {-q}");
            }
            if (q >= 0)
            {
                Console.WriteLine($"Абсолютное значение: {q}");
            }


            Console.WriteLine("task 1.2");
            Console.Write("Введите первое число ");
            int w1, w2, buffer;
            w1 = Convert.ToInt32(Console.ReadLine());
            buffer = w1;
            Console.Write("Введите второе число");
            w2 = Convert.ToInt32(Console.ReadLine());
            if (w1 > w2)
            {
                w1 = buffer / 2;
                Console.WriteLine($"Теперь число 1 будет равно {w1}");
            }
            else
            {
                Console.WriteLine("Никаких действий не производится!");
            }


            Console.WriteLine("task 1.3");
            Console.WriteLine("Введите название животного, с которым встретилась лягушка ");
            string r1;
            r1 = Console.ReadLine();
            if (r1.ToLower() == "аллигатор")
            {
                Console.WriteLine("Тогда размер рта у лягушки будет маленьким");
            }
            else
            {
                Console.WriteLine("Размер рот у лягушки будет широким ");
            }



            Console.WriteLine("\nTask 1.4");
            Console.Write("Введите строку: ");
            try
            {
                string coctail = Console.ReadLine();
                foreach (char c1 in coctail)
                {
                    if (c1 > '0' || c1 < '9')
                    {
                        throw new Exception();
                    }
                }
                coctail = coctail.ToLower();
                switch (coctail.ToLower())
                {
                    case "jabroni": Console.WriteLine("Patron Tequila"); break;
                    case "school counselor": Console.WriteLine("Patron Tequila"); break;
                    case "programmer": Console.WriteLine("Hipster Craft Beer"); break;
                    case "bike gang member": Console.WriteLine("Moonshine"); break;
                    case "politician": Console.WriteLine("Your tax dollars"); break;
                    case "rapper": Console.WriteLine("Cristal"); break;
                    default: Console.WriteLine("Beer"); break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка: введите строку.");
            }





















            Console.WriteLine("task 1.5");
            bool exists; string stroka, english;
            Console.Write("Введите строку: ");
            stroka = Console.ReadLine();
            stroka = stroka.ToLower();
            english = "english";
            int indexOfenglish = stroka.IndexOf(english);
            if (indexOfenglish != -1)
            {
                exists = true;
                Console.Write($"Строка содержит \"english\": {exists} (начинается на {indexOfenglish + 1} элемент). ");
            }
            else
            {
                exists = false;
                Console.WriteLine($"Строка содержит \"english\":{exists}");
            }




            Console.WriteLine("task 2.1");
            double n, answer = 1, delitel;
            Console.Write("Введите делитель ");
            n = Convert.ToInt32(Console.ReadLine());
            delitel = n;
            for (int p = 1; p < 8; p++)
            {
                answer += 1 / delitel;
                delitel *= n;
            }
            Console.WriteLine($"Ответ: {Math.Round(answer, 4)}");


            Console.WriteLine("task 2.2");
            double sum = 1, distance = 1;
            for (double g = 2; g < 100; g++)
            {
                if (g % 2 != 0)
                {
                    distance -= (1 / g);
                }
                else
                {
                    distance += (1 / g);
                }
                sum += 1 / g;
            }
            Console.WriteLine($"За 100 этапов \"Странный муж\" пройдет {Math.Round(sum, 4)} км. \nОн будет на расстояние {Math.Round(distance, 4)} км");




            Console.WriteLine("task 2.3");
            Console.Write("Минимальное кол-во осадков в Январе: ");
            double min = Convert.ToByte(Console.ReadLine());
            Console.Write("Максимальное кол-во осадков в Январе: ");
            double max = Convert.ToByte(Console.ReadLine());
            double a1 = (min + max) / 2;
            Console.WriteLine("среднедневное количество осадков в январе: " + a1);
            Console.Write("Минимальное кол-во осадков в Фервале: ");
            double Min = Convert.ToByte(Console.ReadLine());
            Console.Write("Максимальное кол-во осадков в Феврале: ");
            double Max = Convert.ToByte(Console.ReadLine());
            double a2 = (Min + Max) / 2;
            Console.WriteLine("среднедневное количество осадков в Феврале: " + a2);


            Console.WriteLine("task 3.1.НЕ ПОНЯЛ!!!");



            Console.WriteLine("task 3.2");
            Console.Write("Введите число n");
            int h = Convert.ToInt32(Console.ReadLine());
            for (int v = 1; v < h; v++)
            {
                if (v * v > h)
                {
                    Console.WriteLine($"Первое число больше n: {v * v}");
                    break;
                }
            }



            Console.WriteLine("task 3.3");
            int i = 100;
            Console.Write("Выберите способ 1.Предусловие.2.Постусловие: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    while (i >= 80)
                    {
                        Console.WriteLine(i);
                        i--;
                    }
                    break;
                case "2":
                    do
                    {
                        Console.WriteLine(i);
                        i--;
                    }
                    while (i >= 80);
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }


            Console.WriteLine("task 3.4");
            int natural = 5000;
            for (; natural > 0; natural--)
            {
                if (natural % 39 == 0)
                {
                    Console.WriteLine($"Максимальных чисел,которые делятся на 39 будет: {natural}");
                    break;

                }
            }

            Console.WriteLine("Task 3.5");
            Console.ReadLine();
            Console.WriteLine("5" + "\n5 5" + "\n5 5 5" + "\n5 5 5 5" + "\n5 5 5 5 5");
            Console.ReadLine();
            Console.WriteLine("1 1 1 1 1" + "\n1 1 1 1" + "\n1 1 1" + "\n1 1" + "\n1");



            int a, b, c, d;
            // a)
            Console.Write("Введите a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите c:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите d:");
            d = Convert.ToInt32(Console.ReadLine());
            if (a == c || b == d)
                Console.WriteLine("Ладья({0},{1}) угрожает полю({2},{3})", a, b, c, d);
            else
                Console.WriteLine("Ладья({0},{1}) не угрожает полю({2},{3})", a, b, c, d);
            Console.WriteLine();
            // б)
            if (Math.Abs(a - c) == Math.Abs(b - d))
                Console.WriteLine("Слон({0},{1}) угрожает полю({2},{3})", a, b, c, d);
            else
                Console.WriteLine("Слон({0},{1}) не угрожает полю({2},{3})", a, b, c, d);

            // в)
            if (a == c && Math.Abs(b - d) == 1 || b == d && Math.Abs(a - c) == 1
                   || Math.Abs(a - c) == Math.Abs(b - d) && Math.Abs(a - c) == 1)
                Console.WriteLine("Король({0},{1}) угрожает полю({2},{3})", a, b, c, d);
            else
                Console.WriteLine("Король({0},{1}) не угрожает полю({2},{3})", a, b, c, d);

            // г)
            if (a == c || b == d || Math.Abs(a - c) == Math.Abs(b - d))
                Console.WriteLine("Ферзь({0},{1}) угрожает полю({2},{3})", a, b, c, d);
            else
                Console.WriteLine("Ферзь({0},{1}) не угрожает полю({2},{3})", a, b, c, d);

            // д)
            if (a == c & b == 2 && d == 4 || a == c && d - b == 1)
                Console.WriteLine("Белая Пешка({0},{1}) может пойти на поле ({2},{3})", a, b, c, d);
            else if (Math.Abs(a - c) == 1 && d - b == 1)
                Console.WriteLine("Белая Пешка({0},{1}) может взять фигуру на поле ({2},{3})", a, b, c, d);
            else
                Console.WriteLine("Белая Пешка({0},{1}) не может попасть на поле ({2},{3})", a, b, c, d);

            // е)
            if (a == c && b == 7 && d == 5 || a == c && b - d == 1)
                Console.WriteLine("Черная Пешка({0},{1}) может пойти на поле ({2},{3})", a, b, c, d);
            else if (Math.Abs(a - c) == 1 && b - d == 1)
                Console.WriteLine("Черная Пешка({0},{1}) может взять фигуру на поле ({2},{3})", a, b, c, d);
            else
                Console.WriteLine("Черная Пешка({0},{1}) не может попасть на поле ({2},{3})", a, b, c, d);

            // ж)
            if (Math.Abs(a - c) == 2 && Math.Abs(d - b) == 1 || Math.Abs(a - c) == 1 && Math.Abs(d - b) == 2)
                Console.WriteLine("Конь({0},{1}) угрожает полю({2},{3})", a, b, c, d);
            else
                Console.WriteLine("Конь({0},{1}) не угрожает полю({2},{3})", a, b, c, d);









































































































































            Console.ReadKey();
        }
    }
}
