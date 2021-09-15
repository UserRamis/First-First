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
            Console.WriteLine("\nTask 1.1");
            string M = Console.ReadLine();
            double M1 = double.Parse(M);
            Console.WriteLine(Math.Round(M1, 2));

            Console.WriteLine("\nTask 1.2");
            double N = Math.Exp(1);
            Console.WriteLine(Math.Round(N, 1));

            Console.WriteLine("\nTask 1.3");
            string Z = Console.ReadLine();
            Console.WriteLine("Вы ввели число : " + Z);

            Console.WriteLine("\nTask 1.4");
            string Z1 = Console.ReadLine();
            Console.WriteLine(Z1 + "-Вот какое число вы ввели");

            Console.WriteLine("\nTask 1.5");
            Console.Write("1 13 49");

            Console.WriteLine("\nTask 1.6");
            Console.Write("7  15  100");

            Console.WriteLine("\nTask 1.7");
            Random rnd = new Random();
            Console.WriteLine(rnd.Next() + "  " + rnd.Next() + "  " + rnd.Next());

            Console.WriteLine("\nTask 1.8");
            Console.Write(rnd.Next() + " " + rnd.Next() + " " + rnd.Next() + " " + rnd.Next());

            Console.WriteLine("\nTask 1.9");
            Console.WriteLine("50");
            Console.WriteLine("10");

            Console.WriteLine("\nTask 1.10");
            Console.WriteLine("5");
            Console.WriteLine("10");
            Console.WriteLine("21");

            Console.WriteLine("\nTask 1.11");
            Console.WriteLine(rnd.Next() + "\n" + rnd.Next() + "\n" + rnd.Next() + "\n" + rnd.Next() + "\n");

            Console.WriteLine("\nTask 1.12");
            Console.Write("5 10 \n7см ");

            Console.WriteLine("\nTask 1.13");
            Console.WriteLine("2 кг \n13 17");

            double B, B1, B2, B3;
            Console.WriteLine("\nTask 2.1");
            B = Convert.ToDouble(Console.ReadLine());
            B1 = 7 * B * B + 3 * B + 6;
            Console.WriteLine(B1);
            B2 = Convert.ToDouble(Console.ReadLine());
            B3 = 12 * B2 * B2 + 7 * B2 + 12;
            Console.WriteLine(B3);

            Console.WriteLine("\nTask 2.2");
            double V = Convert.ToDouble(Console.ReadLine());
            double V1 = V * 4;
            Console.WriteLine(V1);

            Console.WriteLine("\nTask 2.3");
            double C = Convert.ToDouble(Console.ReadLine());
            double C1 = C * 2;
            Console.WriteLine(C1);

            Console.WriteLine("\nTask 2.4");
            double r = Convert.ToInt32(Console.ReadLine());
            double r1 = Math.Sqrt((6350 + r) * (6350 + r) - (6350 * 6350));
            Console.WriteLine(r1);

            Console.WriteLine("\nTask 2.5");
            double t = Convert.ToDouble(Console.ReadLine());
            double t1 = Math.Round(t * t * t, 3);
            double t2 = Math.Round(t * t * 4, 2);
            Console.WriteLine("Объем куба= " + t1 + "\nПлощадь боковой поверхности = " + t2);

            Console.WriteLine("\nTask 2.6");
            double y = Convert.ToDouble(Console.ReadLine());
            double y1 = Math.Round(y * 2 * Math.PI, 2);
            double y2 = Math.Round(y * y * Math.PI, 2);
            Console.WriteLine("Длина окружности=" + y1 + "\nПлощадь круга" + y2);

            Console.WriteLine("\nTask 2.7");
            int u = Convert.ToInt32(Console.ReadLine());
            int i = Convert.ToInt32(Console.ReadLine());
            double u1 = ((u + i) / 2);
            double i1 = Math.Sqrt(u * i);
            Console.WriteLine("среднее арифметическое=" + Math.Round(u1, 2) + "\nСреднее геометрическое" + Math.Round(i1, 2));

            Console.WriteLine("\nTask 2.8");
            Console.Write("Масса тела = ");
            double o = Convert.ToDouble(Console.ReadLine());
            Console.Write("Объем тела = ");
            double o1 = Convert.ToDouble(Console.ReadLine());
            double o2 = Math.Round(o / o1, 3);
            Console.WriteLine("Плотность=" + o2);

            Console.WriteLine("\nTask 2.9");
            Console.Write("Численность = ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Площадь территории = ");
            double p1 = Convert.ToDouble(Console.ReadLine());
            double p2 = Math.Round(p / p1, 3);
            Console.WriteLine("Плотность населения = " + p2);

            Console.WriteLine("\nTask 2.10");
            double a1, a2, a3;
            Console.Write("Введите число a ");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число b ");
            a2 = Convert.ToDouble(Console.ReadLine());
            if (Math.Abs(a1) > 0)
            {
                a3 = -a1 / a2;
                Console.WriteLine("x= " + a3);
            }
            else
            {
                if (Math.Abs(a2) > 0)
                    Console.WriteLine("Уравнение не имеет решения");

                else

                    Console.WriteLine("Уравнение не имеет решения");
            }




            Console.WriteLine("\nTask 2.11");
            Console.Write("Первый катет= ");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.Write("Второй катет= ");
            double s1 = Convert.ToDouble(Console.ReadLine());
            double s2 = Math.Round(Math.Sqrt(s * s + s1 * s1), 2);
            Console.WriteLine("Тогда гипотенуза= " + s2);

            Console.WriteLine("\nTask 2.12");
            Console.Write("Радиус внешнего кольцо= ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Радиус внутреннего кольцо= ");
            double d1 = Convert.ToDouble(Console.ReadLine());
            double d2 = Math.PI * (d * d + d1 * d1);
            Console.WriteLine("Площадь кольца равен " + Math.Round(d2, 2));

            Console.WriteLine("\nTask 2.13");
            Console.Write("Введите первый катет ");
            double f1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второй катет ");
            double f2 = Convert.ToDouble(Console.ReadLine());
            double f3 = 0.5 * (f1 * f2);
            Console.WriteLine("Площадь треугольника равна= " + Math.Round(f3), 3);

            Console.WriteLine("\nTask 2.14");
            Console.Write("Первое основание= ");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.Write("Второе основание = ");
            double g1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту");
            double g2 = Convert.ToDouble(Console.ReadLine());
            double g3 = (g + g1) / 2 * g2;
            Console.WriteLine("Периметр трапеции равен= " + Math.Round(g3), 2);

            Console.WriteLine("\nTask 2.14A");
            Console.Write("Введите первую сторону ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вторую сторону ");
            double h1 = Convert.ToDouble(Console.ReadLine());
            double h2 = Math.Sqrt(h * h + h1 * h1);
            double h3 = (2 * h + 2 * h1);
            Console.WriteLine("Длина диагонали равна= " + Math.Round(h2, 2) + "\nПериметр прямугольника равен= " + Math.Round(h3), 2);

            Console.WriteLine("\nTask 2.15");
            Console.Write("Введите первое число ");
            double j = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число ");
            double j1 = Convert.ToDouble(Console.ReadLine());
            double j2 = j + j1;
            double j3 = j - j1;
            double j4 = j * j1;
            double j5 = j / j1;
            Console.WriteLine("Сумма равна= " + j2 + "\nРазность равна= " + j3 + "\nПроизведение равно= " + j4 + "\nДеление равно= " + Math.Round(j5, 3));

            Console.WriteLine("\nTask2.16");
            Console.Write("Первая сторона равна ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Вторая сторона равна ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Третья сторона равна ");
            double k2 = Convert.ToDouble(Console.ReadLine());
            double k3 = k1 * k2 * k;
            double k4 = 2 * (k * k1 + k1 * k2 + k * k2);
            Console.WriteLine("Объем прямоугольного параллелепипеда равна= " + k3 + "\nПлощадь боковой поверхности равна= " + k4);

            Console.WriteLine("\nTask2.17");
            Console.Write("Введите кординаты x1= ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты x2= ");
            double l1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты y1= ");
            double l2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты y2= ");
            double l3 = Convert.ToDouble(Console.ReadLine());
            double l4 = (Math.Sqrt(Math.Pow((l1 - l), 2) + (Math.Pow((l3 - l2), 2))));
            Console.WriteLine("Расстояние между двумя координатамы соответственно равны= " + Math.Round(l4, 3));

            Console.WriteLine("\nTask2.18.ДЕЛАЛИ.");

            Console.WriteLine("\nTask2.19");
            Console.Write("Введите длину большего основания= ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину меньшего основания = ");
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите угол при большем основании= ");
            double z2 = Convert.ToDouble(Console.ReadLine());
            double z9 = (z2 * Math.PI) / 180;
            double z3 = ((z - z1) / 2) * Math.Tan(z9);
            double z4 = ((z + z1) / 2) * z3;
            Console.WriteLine("Площадь трапеции равна= " + Math.Round(z4, 2));

            Console.WriteLine("\nTask2.20");
            Console.WriteLine("Введите координаты x1 и y1");
            double x = Convert.ToDouble(Console.ReadLine());
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты x2 и y2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты x3 и y3");
            double x4 = Convert.ToDouble(Console.ReadLine());
            double x5 = Convert.ToDouble(Console.ReadLine());
            double x6 = Math.Sqrt(Math.Pow((x2 - x), 2) + Math.Pow((x3 - x1), 2));
            double x7 = Math.Sqrt(Math.Pow((x4 - x2), 2) + Math.Pow((x5 - x3), 2));
            double x8 = Math.Sqrt(Math.Pow((x - x4), 2) + Math.Pow((x1 - x5), 2));
            double x9 = (x6 + x7 + x8);
            double x10 = (Math.Sqrt(x9 / 2 * (x9 / 2 - x6) * (x9 / 2 - x7) * (x9 / 2 - x8)));
            Console.WriteLine("Периметр равен= " + Math.Round(x9, 2) + "\n Площадь треугольника равна= " + Math.Round(x10, 2));

            Console.WriteLine("\nTask2.21");
            double c, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17;
            Console.WriteLine("Введите координаты x1 и y1");
            c = Convert.ToDouble(Console.ReadLine());
            c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты x2 и y2");
            c2 = Convert.ToDouble(Console.ReadLine());
            c3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты x3 и y3");
            c4 = Convert.ToDouble(Console.ReadLine());
            c5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты x4 и y4");
            c6 = Convert.ToDouble(Console.ReadLine());
            c7 = Convert.ToDouble(Console.ReadLine());
            c8 = Math.Sqrt(Math.Round(c - c2, 2) + Math.Round(c1 - c3, 2));
            c9 = Math.Sqrt(Math.Round(c2 - c4, 2) + Math.Round(c3 - c5, 2));
            c10 = Math.Sqrt(Math.Round(c4 - c6, 2) + Math.Round(c5 - c7, 2));
            c11 = Math.Sqrt(Math.Round(c6 - c1, 2) + Math.Round(c7 - c2, 2));
            c12 = Math.Sqrt(Math.Round(c6 - c2, 2) + Math.Round(c7 - c3, 2));
            c13 = (c8 + c11 + c12) / 2;
            c14 = (c9 + c11 + c12) / 2;
            c15 = Math.Sqrt(c13 * (c13 - c8)) * (c13 - c11) * (c13 - c12);
            c16 = Math.Sqrt(c13 * (c13 - c9)) * (c13 - c11) * (c13 - c12);
            c17 = c15 + c16;
            Console.WriteLine("Площадь четырехугольника равна= " + c17);

            Console.WriteLine("\nTask 2.22");
            double v, v1, v2, v3, v4, v5, v6;
            Console.Write("Укажите стоимость конфет и их вес соответственно ");
            v = Convert.ToDouble(Console.ReadLine());
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите стоимость печеньев и их вес соответственно ");
            v2 = Convert.ToDouble(Console.ReadLine());
            v3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите стоимость яблок и их вес соответственно ");
            v4 = Convert.ToDouble(Console.ReadLine());
            v5 = Convert.ToDouble(Console.ReadLine());
            v6 = (v * v1) + (v2 * v3) + (v4 * v5);
            Console.WriteLine("Стоимость покупки равна= " + Math.Round(v6, 2));

            Console.WriteLine("\nTask 2.23");
            double b, b1, b2, b3, b4, b5, b6;
            Console.Write("Укажите стоимость монитора и их количество ");
            b = Convert.ToDouble(Console.ReadLine());
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите стоимость системного блока и их количество ");
            b2 = Convert.ToDouble(Console.ReadLine());
            b3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите стоимость мыши и их количество ");
            b4 = Convert.ToDouble(Console.ReadLine());
            b5 = Convert.ToDouble(Console.ReadLine());
            b6 = (b * b1) + (b2 * b3) + (b4 * b5);
            Console.WriteLine("Стоимость покупки будет равна= " + b6 + " рублей");

            Console.WriteLine("\nTask 2.24");
            double n, n1, n2, n3, n4;
            Console.Write("Введите сколько лет Тане ");
            n = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сколько лет Мише ");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Math.Round((n + n1) / 2, 2);
            n3 = Math.Abs(n2 - n);
            n4 = Math.Abs(n2 - n);
            Console.WriteLine("Средний возраст Тани и Миши= " + n2 + "лет" + "\nОтличие от среднего возраста Тани составляет= " + n3 + "\nОтличие Среднего возраста Миши составляет " + n4);

            double m, m1, m2, m3;
            Console.WriteLine("\nTask 2.25");
            Console.Write("Скорость первого автомобиля равна= ");
            m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Скорость второго автомобиля равна= ");
            m1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Расстояние между автомобилями равно= ");
            m2 = Convert.ToDouble(Console.ReadLine());
            m3 = m2 / (m + m1);
            Console.WriteLine("Через " + m3 + " часов автомобили встретятся ");

            Console.WriteLine("\nTask 2.26");
            double Q, Q1, Q2;
            Console.Write("Введите скорость первого автомобиля ");
            Q = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите скорость второго автомобиля ");
            Q1 = Convert.ToDouble(Console.ReadLine());
            Q2 = (Q - Q1) * 0.5;
            Console.WriteLine("Расстояние между автомобилями после 30 минут после встерчи составит " + Q2 + "км");

            Console.WriteLine("\nTask 2.27");
            double W, W1, W2;
            Console.Write("Введите температура по шкале Цельсия ");
            W = Convert.ToDouble(Console.ReadLine());
            W1 = (W * 1.8) + 32;
            W2 = (W + 273.15);
            Console.WriteLine("Температура по шкале Фаренгейта составляет " + W1 + "Градусов" + "\nТемпература по шкале Кельвина соствляет " + W2);

            double E1, E2;
            Console.WriteLine("\nTask 2.28");
            Console.Write("Какова температура по шкале Фаренгейта ");
            E1 = Convert.ToDouble(Console.ReadLine());
            E2 = (E1 - 30) / 1.8;
            Console.WriteLine("Температура по шкале цельсия составляет " + Math.Round(E2, 4));

            Console.WriteLine("\nTask 3.1");
            double R1, R2, R3;
            Console.Write("Введите первую перемену ");
            R1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вторую перемену ");
            R2 = Convert.ToDouble(Console.ReadLine());
            R3 = R1;
            R1 = R2;
            R2 = R3;
            Console.WriteLine("Переменные поменялись местами" + "\n Так, первая переменная равна " + R1 + "\n А вторая переменная равна " + R2);


            Console.WriteLine("\nTask 3.2А");
            Console.Write("Введите первую переменную ");
            double Y1, Y2, Y3, Y4;
            Y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вторую переменную ");
            Y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третью переменную ");
            Y3 = Convert.ToDouble(Console.ReadLine());
            Y4 = Y1;
            Y1 = Y2;
            Y2 = Y3;
            Y3 = Y4;
            Console.WriteLine("Так переменная B равна  " + Y2 + "\nПеременная А равна " + Y1 + "\nТогда переменная C равна  " + Y3);


            Console.WriteLine("\nTask 3.2А");
            Console.Write("Введите первую переменную ");
            double T1, T2, T3, T4, T5;
            T1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вторую переменную ");
            T2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третью переменную ");
            T3 = Convert.ToDouble(Console.ReadLine());
            T4 = T2;
            T5 = T1;
            T1 = T3;
            T2 = T5;
            T3 = T4;
            Console.WriteLine("Так переменная B равна  " + T2 + "\nПеременная C равна " + T3 + "\nТогда переменная A равна  " + T1);

            Console.WriteLine("\nTask 3.3a");
            double L1, L2, L3;
            Console.Write("Введите число а ");
            L1 = Convert.ToDouble(Console.ReadLine());
            L2 = L1 * L1;
            L3 = L2 * L2;
            Console.WriteLine("Тогда а^4 будет= " + Math.Round(Y3, 2));

            Console.WriteLine("\nTask 3.3b");
            double U1, U2, U3, U4;
            Console.Write("Введите число а ");
            U1 = Convert.ToDouble(Console.ReadLine());
            U2 = U1 * U1;
            U3 = U2 * U2;
            U4 = U3 * U2;
            Console.WriteLine("Тогда a^6 будет " + Math.Round(U4, 2));

            Console.WriteLine("\nTask 3.3c");
            double I1, I2, I3, I4, I5;
            Console.Write("Введите число а ");
            I1 = Convert.ToDouble(Console.ReadLine());
            I2 = I1 * I1;
            I3 = I2 * I2;
            I4 = I3 * I2;
            I5 = I4 * I1;
            Console.WriteLine("Тогда а^7 будет " + Math.Round(I5, 2));

            Console.WriteLine("\nTask 3.3d");
            double O1, O2, O3, O4;
            Console.Write("Введите число а ");
            O1 = Convert.ToDouble(Console.ReadLine());
            O2 = O1 * O1;
            O3 = O2 * O2;
            O4 = O3 * O3;
            Console.WriteLine("Тогда а^8 будет= " + Math.Round(O4, 2));

            Console.WriteLine("\nTask 3.3f");
            double P1, P2, P3, P4, P5;
            Console.Write("Введите число а ");
            P1 = Convert.ToDouble(Console.ReadLine());
            P2 = P1 * P1;
            P3 = P2 * P2;
            P4 = P3 * P3;
            P5 = P4 * P1;
            Console.WriteLine("Тогда а^9 будет= " + Math.Round(P5, 2));

            Console.WriteLine("\nTask 3.3G");
            double A1, A2, A3, A4, A5;
            Console.Write("Введите число а ");
            A1 = Convert.ToDouble(Console.ReadLine());
            A2 = A1 * A1;
            A3 = A2 * A2;
            A4 = A3 * A3;
            A5 = A4 * A2;
            Console.WriteLine("Тогда a^10 будет= " + Math.Round(A5, 2));

            Console.WriteLine("\nTask 3.4a");
            double S1, S2, S3, S4, S5;
            Console.Write("Введите число а ");
            S1 = Convert.ToDouble(Console.ReadLine());
            S2 = S1 * S1;
            S3 = S2 * S1;
            S4 = S3 * S2;
            S5 = S4 * S4;
            Console.WriteLine("Тогда a^3 будет " + Math.Round(S3, 2) + "\na^10 будет " + Math.Round(S5, 2));

            Console.WriteLine("\nTask 3.4b");
            double D1, D2, D3, D4, D5, D6;
            Console.Write("Введите число а");
            D1 = Convert.ToDouble(Console.ReadLine());
            D2 = D1 * D1;
            D3 = D2 * D2;
            D4 = D3 * D3;
            D5 = D4 * D4;
            D6 = D5 * D3;
            Console.WriteLine("Тогда a^4 будет " + Math.Round(D3, 2) + "\na^20 будет " + Math.Round(D6, 2));

            Console.WriteLine("\nTask 3.4c");
            double F1, F2, F3, F4, F5, F6;
            Console.Write("Введите число а ");
            F1 = Convert.ToDouble(Console.ReadLine());
            F2 = F1 * F1;
            F3 = F2 * F2;
            F4 = F3 * F1;
            F5 = F3 * F3;
            F6 = F5 * F4;
            Console.WriteLine("Тогда a^5 будет " + Math.Round(F4, 2) + "\nа^13 будет " + Math.Round(F6, 2));

            Console.WriteLine("\nTask 3.4d");
            double G1, G2, G3, G4, G5, G6, G7;
            Console.Write("Введите число а ");
            G1 = Convert.ToDouble(Console.ReadLine());
            G2 = G1 * G1;
            G3 = G2 * G2;
            G4 = G3 * G1;
            G5 = G4 * G3;
            G6 = G5 * G5;
            G7 = G6 * G1;
            Console.WriteLine("Тогда a^5 будет " + Math.Round(G4, 2) + "\n a^19 будет " + Math.Round(G7, 2));

            Console.WriteLine("\nTask 3.4F");
            double H1, H2, H3, H4, H5, H6, H7;
            Console.Write("Введите число а ");
            H1 = Convert.ToDouble(Console.ReadLine());
            H2 = H1 * H1;
            H3 = H2 * H2;
            H4 = H3 * H1;
            H5 = H3 * H3;
            H6 = H5 * H5;
            H7 = H6 * H1;
            Console.WriteLine("Тогда a^2 будет " + Math.Round(H2, 2) + "\na^5 будет " + Math.Round(H4, 2) + "\na^17 будет " + Math.Round(H7, 2));

            Console.WriteLine("\nTask 3.4G");
            double J1, J2, J3, J4, J5, J6, J7;
            Console.Write("Введите число а ");
            J1 = Convert.ToDouble(Console.ReadLine());
            J2 = J1 * J1;
            J3 = J2 * J2;
            J4 = J3 * J2;
            J5 = J4 * J4;
            J6 = J5 * J5;
            J7 = J6 * J3;
            Console.WriteLine("Тогда a^4 будет " + Math.Round(J3, 2) + "\na^12= " + Math.Round(J5, 2) + "\na^27= " + Math.Round(J7, 2));

            Console.WriteLine("\nTask 4");
            Console.Write("Не получилось......");







            Console.ReadKey();


        }
    }
}

