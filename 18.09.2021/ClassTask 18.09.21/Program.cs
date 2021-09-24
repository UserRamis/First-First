using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask_18._09._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            Console.WriteLine("Типы переменных. Минимальное и максимальное значение ");
            Console.WriteLine("bool. True or false");
            Console.WriteLine("byte." + byte.MaxValue + byte.MinValue);
            Console.WriteLine("char." + char.MaxValue + char.MinValue);
            Console.WriteLine("decimal." + decimal.MaxValue + decimal.MinValue);
            Console.WriteLine("float." + float.MaxValue + float.MinValue);
            Console.WriteLine("int." + int.MaxValue + int.MinValue);
            Console.WriteLine("long." + long.MaxValue + long.MinValue);
            Console.WriteLine("sbyte." + sbyte.MaxValue + sbyte.MinValue);
            Console.WriteLine("short." + short.MaxValue + short.MinValue);
            Console.WriteLine("unit." + uint.MaxValue + uint.MinValue);
            Console.WriteLine("ulong." + ulong.MaxValue + ulong.MinValue);
            Console.WriteLine("ushort." + ushort.MaxValue + ushort.MinValue);
            Console.ReadKey();


            Console.WriteLine("\nTask2");
            Console.Write("Введите ваше имя ");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("Введите ваш город проживания ");
            string city = Convert.ToString(Console.ReadLine());
            Console.Write("Введите ваш возраст ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите ваш PIN ");
            int pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Добрый день " + name + "\nВаш город- " + city + "\nВаш возраст " + "\nВаш пин " + pin);

            Console.WriteLine("\nTask3");
            Console.Write("Введите текст строчными ");
            string proposal = Convert.ToString(Console.ReadLine());
            string upperString = proposal.ToUpper();
            Console.WriteLine("Тогда предложение в заглавных будет " + upperString);
            Console.Write("Введите текст заглавными буквами ");
            string proposal1 = Convert.ToString(Console.ReadLine());
            string LowerString = proposal1.ToLower();
            Console.WriteLine("Тогда предложение в заглавных будет " + LowerString);

            Console.WriteLine("\nTask4");
            Console.Write("Введите строку ");
            string stroka = Convert.ToString(Console.ReadLine());
            Console.Write("Введите подстроку ");
            string podstroka = Convert.ToString(Console.ReadLine());
            if (stroka.Length < podstroka.Length)
                Console.WriteLine("строка не может быть меньше подстроки");
            else
            {
                if (stroka.Contains(podstroka))
                    Console.WriteLine("Строка " + stroka + " содержит подстроку " + podstroka);
                else
                    Console.WriteLine("Строка" + stroka + " не содержит подстроку " + podstroka);
            }

            Console.WriteLine("\nTask5");
            Console.Write("Введите скорость таракана в км/ч ");
            double speed, speed1;
            speed = Convert.ToDouble(Console.ReadLine());
            speed1 = (27.77 * speed);
            Console.WriteLine("Тогда скорость в см/c равна " + Math.Round(speed1, 2));

            Console.WriteLine("\nTask6");
            Console.Write("Введите возраст отца ");
            double a1, a2, a3, a4, a5, a6;
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите возраст сын ");
            a2 = Convert.ToDouble(Console.ReadLine());
            a6 = a1 / a2;
            if (a6 == 2)
            {

                Console.WriteLine("Отношение возрастов уже равно двум");
            }
            else
            {

                a3 = a1 - a2;
                a4 = (a3 * 2);
                a5 = a4 - a1;
                Console.WriteLine("Через " + Math.Abs(a5) + " лет отношение возрастов между отцом и сыном будет 2");

            }


            Console.WriteLine("\nTask6");
            Console.Write("Введите цену сока ");
            float normPrice, salePrice, holidayPrice, w1;
            normPrice = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите скидку в DutyFree ");
            salePrice = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите стоимость отпуска ");
            holidayPrice = Convert.ToSingle(Console.ReadLine());
            w1 = holidayPrice / ((salePrice / 100) * normPrice);
            Console.WriteLine(Math.Floor(Math.Round(w1, 3)) + " бутылок нужно будет купить");









            Console.ReadKey();
        }
    }
}
