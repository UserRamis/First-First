using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Lab_7
{
    class BankAccounts
    {

        ///8.1
        private int balance1 = 0;
        private int balance2 = 0;
        public void Balance1(int Balance1)
        {
            balance1 = Balance1;
        }

        public void Balance2(int Balance2)
        {
            balance2 = Balance2;
        }

        public void Perevod()
        {
            BankAccounts p = new BankAccounts();
            Console.Write("Введите сумму которую хотите перевести с первого счета на другой ");
            int sum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Тогда баланс второго счета будет: " + (sum + balance1));
        }

        public class Temperature : IFormattable
        {
            private decimal temp;

            public Temperature(decimal temperature)
            {
                if (temperature < -273.15m)
                    throw new ArgumentOutOfRangeException(String.Format("{0} is less than absolute zero.",
                                                          temperature));
                this.temp = temperature;
            }

            public decimal Celsius
            {
                get { return temp; }
            }

            public decimal Fahrenheit
            {
                get { return temp * 9 / 5 + 32; }
            }

            public decimal Kelvin
            {
                get { return temp + 273.15m; }
            }

            public override string ToString()
            {
                return this.ToString("G", CultureInfo.CurrentCulture);
            }

            public string ToString(string format)
            {
                return this.ToString(format, CultureInfo.CurrentCulture);
            }

            public string ToString(string format, IFormatProvider provider)
            {
                if (String.IsNullOrEmpty(format)) format = "G";
                if (provider == null) provider = CultureInfo.CurrentCulture;


                switch (format.ToUpperInvariant())
                {
                    case "G":
                    case "C":
                        return temp.ToString("F2", provider) + " °C";
                    case "F":
                        return Fahrenheit.ToString("F2", provider) + " °F";
                    case "K":
                        return Kelvin.ToString("F2", provider) + " K";
                    default:
                        throw new FormatException(String.Format("The {0} format string is not supported.", format));
                }
            }
        }


            static void Main(string[] args)
            { 
            Console.WriteLine("8.2");
            Console.Write("Введите строку-->\t");
            string str = Console.ReadLine().ToString();
            Console.Write($"Наоборот-->\t\t");
            Console.WriteLine(Reverse(str));





            Console.WriteLine("8.3");
            Console.Write("Какое название файла? ");
            string file = Console.ReadLine() + ".txt";
            Console.Write("searching.");
            if (File.Exists(file) && !file.Equals("finalfile.txt"))
            {

                StreamReader r = new StreamReader(file);
                file = r.ReadToEnd().ToUpper();
                File.AppendAllText("finalfile.txt", file);

            }
            else
            {

                Console.WriteLine("Ошибка! Файл с таким именем не найден!");

            }





            Console.WriteLine("8.4");
            Temperature t = new Temperature(50);
            IfsIFormatTable(t);





            Console.ReadKey();


            }

        public static char[] Reverse(string a)
        {
            char[] reverse = a.Reverse().ToArray();
            return reverse;
        }

        static void IfsIFormatTable(object obj)
        {
            if (obj is IFormattable)
            {
                Console.WriteLine(obj.ToString());
            }
            else
            {

                throw new Exception("Не удалось явно преобразовать к IFormatTable");
            }
        }



    }
}
