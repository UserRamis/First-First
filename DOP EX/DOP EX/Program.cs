using System;


namespace DOP_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            // a)
            Console.WriteLine("###############Введите a:############### ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("###############Введите b:############### ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("###############Введите c:############### ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("###############Введите d:###############");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("##############################   Итоги   ##############################");

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
