using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //            //Console.WriteLine("Task 1.1");
            //            //string a = Console.ReadLine();
            //            //double b = double.Parse(a);
            //            //Console.WriteLine(Math.Round(b, 2));

            //            Console.WriteLine("Task 1.2");
            //            double b = Math.Exp(1);
            //            Console.WriteLine(Math.Round(b, 1));

            //            Console.WriteLine("Task 1.3");
            //            string number = Console.ReadLine();
            //            Console.WriteLine("Вы ввели число : " + number);

            //            Console.WriteLine("Task 1.4");
            //            string number = Console.ReadLine();
            //            Console.WriteLine(number + "-Вот какое число вы ввели");

            //            Console.WriteLine("Task 1.5");
            //            Console.Write("1 13 49");

            //            Console.WriteLine("Task 1.6");
            //            Console.Write("7  15  100");

            //            Console.WriteLine("Task 1.7");
            //            Random rnd = new Random();
            //            Console.WriteLine(rnd.Next() + "  " + rnd.Next() + "  " + rnd.Next());

            //            Console.WriteLine("Task 1.8");
            //            Console.Write(rnd.Next() + " " + rnd.Next() + " " + rnd.Next() + " " + rnd.Next());

            //            Console.WriteLine("Task 1.9");
            //            Console.WriteLine("50");
            //            Console.WriteLine("10");

            //            Console.WriteLine("Task 1.10");
            //            Console.WriteLine("5");
            //            Console.WriteLine("10");
            //            Console.WriteLine("21");

            //            Console.WriteLine("Task 1.11");
            //            Console.WriteLine(rnd.Next() + "\n" + rnd.Next() + "\n" + rnd.Next() + "\n" + rnd.Next() + "\n");

            //            Console.WriteLine("Task 1.12");
            //            Console.Write("5 10 \n7см ");

            //            Console.WriteLine("Task 1.13");
            //            Console.WriteLine("2 кг \n13 17");

            //            Console.WriteLine("Task 2.1");
            //            double x = Convert.ToDouble(Console.ReadLine());
            //            double y = 7 * x * x + 3 * x + 6;
            //            Console.WriteLine(y);
            //            double a = Convert.ToDouble(Console.ReadLine());
            //            double q1 = 12 * a * a + 7 * a + 12;
            //            Console.WriteLine(q1);

            //            Console.WriteLine("Task 2.2");
            //            double w = Convert.ToDouble(Console.ReadLine());
            //            double w1 = w * 4;
            //            Console.WriteLine(w1);

            //            Console.WriteLine("Task 2.3");
            //            double e = Convert.ToDouble(Console.ReadLine());
            //            double e1 = e * 2;
            //            Console.WriteLine(e1);

            //            Console.WriteLine("Task 2.4");
            //            double r = Convert.ToInt32(Console.ReadLine());
            //            double r1 = Math.Sqrt((6350 + r) * (6350 + r) - (6350 * 6350));
            //            Console.WriteLine(r1);

            //            Console.WriteLine("Task 2.5");
            //            double t = Convert.ToDouble(Console.ReadLine());
            //            double t1 = Math.Round(t * t * t, 3);
            //            double t2 = Math.Round(t * t * 4, 2);
            //            Console.WriteLine("Объем куба= " + t1 + "\nПлощадь боковой поверхности = " + t2);

            //            Console.WriteLine("Task 2.6");
            //            double y = Convert.ToDouble(Console.ReadLine());
            //            double y1 = Math.Round(y * 2 * Math.PI, 2);
            //            double y2 = Math.Round(y * y * Math.PI, 2);
            //            Console.WriteLine("Длина окружности=" + y1 + "\nПлощадь круга" + y2);

            //            Console.WriteLine("Task 2.7");
            //            int u = Convert.ToInt32(Console.ReadLine());
            //            int i = Convert.ToInt32(Console.ReadLine());
            //            double u1 = ((u + i) / 2);
            //            double i1 = Math.Sqrt(u * i);
            //            Console.WriteLine("среднее арифметическое=" + Math.Round(u1, 2) + "\nСреднее геометрическое" + Math.Round(i1, 2));

            //            Console.WriteLine("Task 2.8");
            //            Console.Write("Масса тела = ");
            //            double o = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Объем тела = ");
            //            double o1 = Convert.ToDouble(Console.ReadLine());
            //            double o2 = Math.Round(o / o1, 3);
            //            Console.WriteLine("Плотность=" + o2);

            //            Console.WriteLine("Task 2.9");
            //            Console.Write("Численность = ");
            //            double p = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Площадь территории = ");
            //            double p1 = Convert.ToDouble(Console.ReadLine());
            //            double p2 = Math.Round(p / p1, 3);
            //            Console.WriteLine("Плотность населения = " + p2);

            //            Console.WriteLine("Task 2.10");
            //            Console.Write("Введите число a ");
            //            double a1 = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Введите число b ");
            //            double a2 = Convert.ToDouble(Console.ReadLine());
            //            double a3 = Math.Round(a1 / a2, 2);
            //            Console.WriteLine("Тогда x = " + a3);


            //            Console.WriteLine("Task 2.11");
            //            Console.Write("Первый катет= ");
            //            double s = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Второй катет= ");
            //            double s1 = Convert.ToDouble(Console.ReadLine());
            //            double s2 = Math.Round(Math.Sqrt(s * s + s1 * s1), 2);
            //            Console.WriteLine("Тогда гипотенуза= " + s2);

            //            Console.WriteLine("Task 2.12");
            //            Console.Write("Радиус внешнего кольцо= ");
            //            double d = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Радиус внутреннего кольцо= ");
            //            double d1 = Convert.ToDouble(Console.ReadLine());
            //            double d2 = Math.PI * (d * d + d1 * d1);
            //            Console.WriteLine("Площадь кольца равен " + Math.Round(d2, 2));

            //            Console.WriteLine("Task 2.13");
            //            Console.Write("Введите первый катет ");
            //            double f1 = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Введите второй катет ");
            //            double f2 = Convert.ToDouble(Console.ReadLine());
            //            double f3 = 0.5 * (f1 * f2);
            //            Console.WriteLine("Площадь треугольника равна= " + Math.Round(f3), 3);

            //            Console.WriteLine("Task 2.14");
            //            Console.Write("Первое основание= ");
            //            double g = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Второе основание = ");
            //            double g1 = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Введите высоту");
            //            double g2 = Convert.ToDouble(Console.ReadLine());
            //            double g3 = (g + g1) / 2 * g2;
            //            Console.WriteLine("Периметр трапеции равен= " + Math.Round(g3), 2);

            //            Console.WriteLine("Task 2.14A");
            //            Console.Write("Введите первую сторону ");
            //            double h = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Введите вторую сторону ");
            //            double h1 = Convert.ToDouble(Console.ReadLine());
            //            double h2 = Math.Sqrt(h * h + h1 * h1);
            //            double h3 = (2 * h + 2 * h1);
            //            Console.WriteLine("Длина диагонали равна= " + Math.Round(h2, 2) + "\nПериметр прямугольника равен= " + Math.Round(h3), 2);

            //            Console.WriteLine("Task 2.15");
            //            Console.Write("Введите первое число ");
            //            double j = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Введите второе число ");
            //            double j1 = Convert.ToDouble(Console.ReadLine());
            //            double j2 = j + j1;
            //            double j3 = j - j1;
            //            double j4 = j * j1;
            //            double j5 = j / j1;
            //            Console.WriteLine("Сумма равна= " + j2 + "\nРазность равна= " + j3 + "\nПроизведение равно= " + j4 + "\nДеление равно= " + Math.Round(j5, 3));

            //            Console.WriteLine("Task2.16");
            //            Console.Write("Первая сторона равна ");
            //            double k = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Вторая сторона равна ");
            //            double k1 = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Третья сторона равна ");
            //            double k2 = Convert.ToDouble(Console.ReadLine());
            //            double k3 = k1 * k2 * k;
            //            double k4 = 2 * (k * k1 + k1 * k2 + k * k2);
            //            Console.WriteLine("Объем прямоугольного параллелепипеда равна= " + k3 + "\nПлощадь боковой поверхности равна= " + k4);

            //            Console.WriteLine("Task2.17");
            //            Console.Write("Введите кординаты x1= ");
            //            double l = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Введите координаты x2= ");
            //            double l1 = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Введите координаты y1= ");
            //            double l2 = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Введите координаты y2= ");
            //            double l3 = Convert.ToDouble(Console.ReadLine());
            //            double l4 = (Math.Sqrt(Math.Pow((l1 - l), 2) + (Math.Pow((l3 - l2), 2))));
            //            Console.WriteLine("Расстояние между двумя координатамы соответственно равны= " + Math.Round(l4, 3));

            //            Console.WriteLine("Task2.18.ДЕЛАЛИ.");

            //            Console.WriteLine("Task2.19");
            //            Console.Write("Введите длину большего основания= ");
            //            double z = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Введите длину меньшего основания = ");
            //            double z1 = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Введите угол при большем основании= ");
            //            double z2 = Convert.ToDouble(Console.ReadLine());
            //            double z9 = (z2 * Math.PI) / 180;
            //            double z3 = ((z - z1) / 2) * Math.Tan(z9);
            //            double z4 = ((z + z1) / 2) * z3;
            //            Console.WriteLine("Площадь трапеции равна= " + Math.Round(z4, 2));

            //            Console.WriteLine("Task2.20");
            //            Console.WriteLine("Введите координаты x1 и y1");
            //            double x = Convert.ToDouble(Console.ReadLine());
            //            double x1 = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("Введите координаты x2 и y2");
            //            double x2 = Convert.ToDouble(Console.ReadLine());
            //            double x3 = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("Введите координаты x3 и y3");
            //            double x4 = Convert.ToDouble(Console.ReadLine());
            //            double x5 = Convert.ToDouble(Console.ReadLine());
            //            double x6 = Math.Sqrt(Math.Pow((x2 - x), 2) + Math.Pow((x3 - x1), 2));
            //            double x7 = Math.Sqrt(Math.Pow((x4 - x2), 2) + Math.Pow((x5 - x3), 2));
            //            double x8 = Math.Sqrt(Math.Pow((x - x4), 2) + Math.Pow((x1 - x5), 2));
            //            double x9 = (x6 + x7 + x8);
            //            double x10 = (Math.Sqrt(x9 / 2 * (x9 / 2 - x6) * (x9 / 2 - x7) * (x9 / 2 - x8)));
            //            Console.WriteLine("Периметр равен= " + Math.Round(x9, 2) + "\n Площадь треугольника равна= " + Math.Round(x10, 2));

            //            Console.WriteLine("Task2.21);

            //double c, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17;
            //Console.WriteLine("Введите координаты x1 и y1");
            //c = Convert.ToDouble(Console.ReadLine());
            //c1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите координаты x2 и y2");
            //c2 = Convert.ToDouble(Console.ReadLine());
            //c3 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите координаты x3 и y3");
            //c4 = Convert.ToDouble(Console.ReadLine());
            //c5 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите координаты x4 и y4");
            //c6 = Convert.ToDouble(Console.ReadLine());
            //c7 = Convert.ToDouble(Console.ReadLine());
            //c8 = Math.Sqrt(Math.Round(c - c2, 2) + Math.Round(c1 - c3, 2));
            //c9 = Math.Sqrt(Math.Round(c2 - c4, 2) + Math.Round(c3 - c5, 2));
            //c10 = Math.Sqrt(Math.Round(c4 - c6, 2) + Math.Round(c5 - c7, 2));
            //c11 = Math.Sqrt(Math.Round(c6 - c1, 2) + Math.Round(c7 - c2, 2));
            //c12 = Math.Sqrt(Math.Round(c6 - c2, 2) + Math.Round(c7 - c3, 2));
            //c13 = (c8 + c11 + c12) / 2;
            //c14 = (c9 + c11 + c12) / 2;
            //c15 = Math.Sqrt(c13 * (c13 - c8)) * (c13 - c11) * (c13 - c12);
            //c16 = Math.Sqrt(c13 * (c13 - c9)) * (c13 - c11) * (c13 - c12);
            //c17 = c15 + c16;
            //Console.WriteLine("Площадь четырехугольника равна= " + c17);

            //            Console.WriteLine("Task 2.22");
            //            double v, v1, v2, v3, v4, v5, v6;
            //            Console.Write("Укажите стоимость конфет и их вес соответственно ");
            //            v = Convert.ToDouble(Console.ReadLine());
            //            v1 = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Укажите стоимость печеньев и их вес соответственно ");
            //            v2 = Convert.ToDouble(Console.ReadLine());
            //            v3 = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Укажите стоимость яблок и их вес соответственно ");
            //            v4 = Convert.ToDouble(Console.ReadLine());
            //            v5 = Convert.ToDouble(Console.ReadLine());
            //            v6 = (v * v1) + (v2 * v3) + (v4 * v5);
            //            Console.WriteLine("Стоимость покупки равна= " + Math.Round(v6, 2));

            //            Console.WriteLine("Task 2.23");
            //            double b, b1, b2, b3, b4, b5, b6;
            //            Console.Write("Укажите стоимость монитора и их количество ");
            //            b = Convert.ToDouble(Console.ReadLine());
            //            b1 = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Укажите стоимость системного блока и их количество ");
            //            b2 = Convert.ToDouble(Console.ReadLine());
            //            b3 = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Укажите стоимость мыши и их количество ");
            //            b4 = Convert.ToDouble(Console.ReadLine());
            //            b5 = Convert.ToDouble(Console.ReadLine());
            //            b6 = (b * b1) + (b2 * b3) + (b4 * b5);
            //            Console.WriteLine("Стоимость покупки будет равна= " + b6 + " рублей");

            //            Console.WriteLine("Task 2.24");
            //            double n, n1, n2, n3, n4;
            //            Console.Write("Введите сколько лет Тане ");
            //            n = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Введите сколько лет Мише ");
            //            n1 = Convert.ToDouble(Console.ReadLine());
            //            n2 = Math.Round((n + n1) / 2, 2);
            //            n3 = Math.Abs(n2 - n);
            //            n4 = Math.Abs(n2 - n);
            //            Console.WriteLine("Средний возраст Тани и Миши= " + n2 + "лет" + "\nОтличие от среднего возраста Тани составляет= " + n3 + "\nОтличие Среднего возраста Миши составляет " + n4);

            //            double m, m1, m2, m3, m4;
            //            Console.WriteLine("Task 2.25");
            //            Console.Write("Скорость первого автомобиля равна= ");
            //            m = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Скорость второго автомобиля равна= ");
            //            m1 = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Расстояние между автомобилями равно= ");
            //            m2 = Convert.ToDouble(Console.ReadLine());
            //            m3 = m2 / (m + m1);
            //            Console.WriteLine("Через " + m3 + " часов автомобили встретятся ");

            //            Console.WriteLine("Task 2.26");
            //            double Q, Q1, Q2, Q3, Q4, Q5, Q6, Q7;
            //            Console.Write("Введите скорость первого автомобиля ");
            //            Q = Convert.ToDouble(Console.ReadLine());
            //            Console.Write("Введите скорость второго автомобиля ");
            //            Q1 = Convert.ToDouble(Console.ReadLine());
            //            Q2 = (Q - Q1) * 0.5;
            //            Console.WriteLine("Расстояние между автомобилями после 30 минут после встерчи составит " + Q2 + "км");

            //Console.WriteLine("Task 2.27");
            //double W, W1, W2;
            //Console.Write("Введите температура по шкале Цельсия ");
            //W = Convert.ToDouble(Console.ReadLine());
            //W1 = (W * 1.8) + 32;
            //W2 = (W + 273.15);
            //Console.WriteLine("Температура по шкале Фаренгейта составляет " + W1 + "Градусов" + "\nТемпература по шкале Кельвина соствляет " + W2);

            //double E1, E2;
            //Console.WriteLine("Task 2.28");
            //Console.Write("Какова температура по шкале Фаренгейта ");
            //E1 = Convert.ToDouble(Console.ReadLine());
            //E2 = (E1 - 30) / 1.8;
            //Console.WriteLine("Температура по шкале цельсия составляет " + Math.Round(E2, 4));





























































            Console.ReadKey();


        }
    }
}

