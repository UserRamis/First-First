using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Task 6.1");
            int lowelscount = 0, consonanscount = 0;
            List<char> vowels = new List<char>() { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            List<char> consonans = new List<char>() { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ъ' };
            string array = File.ReadAllText("C:\\Users\\user9\\source\\repos\\09.10.21\\Буквы.txt");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (array[i] == vowels[j])
                    {
                        lowelscount++;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < 23; j++)
                {
                    if (array[i] == consonans[j])
                    {
                        consonanscount++;
                    }
                }
            }
            Console.WriteLine("Гласных букв:" + lowelscount + "\nСогласных букв" + consonanscount);






            Console.WriteLine("\nTask 6.2");
            LinkedList<int> matrixx1 = new LinkedList<int>();
            LinkedList<int> matrixx2 = new LinkedList<int>();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Введите a({i + 1},{j + 1}) для 1ой и 2ой матрицы:");
                    matrixx1.AddLast(Convert.ToInt32(Console.ReadLine()));
                    matrixx2.AddLast(Convert.ToInt32(Console.ReadLine()));
                }
            }
            Console.Write("Введите действие:\n1-вывести матрицы.\n2-Умножить матрицы.");
            int nomer = Convert.ToInt32(Console.ReadLine());
            switch (nomer)
            {
                case 1:
                    Press(matrixx1, matrixx2);
                    break;
                case 2:
                    press(matrixx1, matrixx2);
                    break;
            }





            Console.WriteLine("\nTask 6.3");
            Random rnd = new Random();
            Dictionary<int, double> months = new Dictionary<int, double>(12);
            double sum; int numberofmonth = 0;
            double[] temperature = new double[30];
            for (int m = 0; m < 12; m++) //заполнение месяцей и дней температурами
            {
                sum = 0;
                for (int i = 0; i < 30; i++)
                {
                    temperature[i] = rnd.Next(120, 300) / 10;
                    sum += temperature[i];
                }
                AverageTemperature(numberofmonth, sum, months); //метод для нахождения средних температур в каждом месяце
                numberofmonth++; //прибавление для метода
            }
            for (int k = 0; k < 12; k++) //сортировка массива средних температур
            {
                for (int l = 0; l < 12; l++)
                {
                    if (months[k] < months[l])
                    {
                        double buffer = months[k];
                        months[k] = months[l];
                        months[l] = buffer;
                    }
                }
            }
            Console.Write("Отсортированный массив: ");
            foreach (var celsium in months)
                Console.Write(celsium.Value + ", ");







            Console.WriteLine("\nTask 1");
            FileInfo filePasssword = new FileInfo("C:\\Users\\user9\\source\\repos\\09.10.21\\Пароли.txt");
            using (StreamReader filePasswordRead = filePasssword.OpenText())
            {
                string passwordBinary = filePasswordRead.ReadToEnd();
                Console.Write("Введите строку возможных паролей: ");
                string inputPasswords = Console.ReadLine();
                object result = CheckPasword(inputPasswords.Split(), passwordBinary);
                try
                {
                    bool unboxingresult = (bool)result;
                    Console.WriteLine("Правильного пароля нет!");
                }
                catch
                {
                    string unboxingresult = (string)result;
                    Console.WriteLine("Пароль: " + unboxingresult);
                }
            }




            Console.WriteLine("\nTask 2");
            Console.Write("Введите фразу из 4 слов: ");
            string inputUser = Console.ReadLine().Trim();
            if (inputUser.Split().Length != 4)
            {
                throw new FormatException("Wrong number of words in pharse. Task 2");
            }
            inputUser = ConvertStrRuToRamsayLanguage(inputUser);
            Console.WriteLine(inputUser);


            Console.ReadKey();
        }



        static void Press(LinkedList<int> Array1, LinkedList<int> Array2)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write(Array1.First() + " ");
                if (i == 1)
                {
                    Console.WriteLine();
                }
                Array1.RemoveFirst();
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(Array2.First() + " ");
                if (i == 1)
                {
                    Console.WriteLine();
                }
                Array2.RemoveFirst();
            }

        }

        static void press(LinkedList<int> matrix1, LinkedList<int> matrix2)
        {
            int a11, a12, a21, a22;
            a11 = matrix1.ElementAt(0) * matrix2.ElementAt(0) + matrix1.ElementAt(1) * matrix2.ElementAt(2);
            a12 = matrix1.ElementAt(0) * matrix2.ElementAt(1) + matrix1.ElementAt(1) * matrix2.ElementAt(3);
            a21 = matrix1.ElementAt(2) * matrix2.ElementAt(0) + matrix1.ElementAt(3) * matrix2.ElementAt(2);
            a22 = matrix1.ElementAt(2) * matrix2.ElementAt(1) + matrix1.ElementAt(3) * matrix2.ElementAt(3);
            Console.WriteLine($"Конечная матрица будет \n{a11} {a12}\n{a21} {a22}");


        }

        static void AverageTemperature(int numberofmonth, double sum, Dictionary<int, double> months)
        {
            months[numberofmonth] = Math.Round(sum / 30, 2);
            Console.WriteLine($"в {numberofmonth + 1} месяце: " + months[numberofmonth]);
        }

        static object CheckPasword(string[] userPasswords, string passwordBinary)
        {
            string password = "";
            foreach (var item in passwordBinary.Split())
            {
                if (CheckBinarityOfString(item))
                {
                    throw new FormatException("Task 1. Char From file do not have binary form!");
                }
                password += (char)Convert.ToInt32(item, 2);
            }
            return 1;
        }
        
        static bool CheckBinarityOfString(string s)
            {
                if (s.Length != 8)
                {
                    return false;
                }
                foreach (var item in s.ToCharArray())
                {
                    if (item != '0' || item != '1')
                    {
                        return false;
                    }
                }
                return true;
            }

        static string ConvertStrRuToRamsayLanguage(string str)
        {
            string strNewFormat = "";
            foreach (var item in str.ToCharArray())
            {
                if (item == 'А' || item == 'а')
                {
                    strNewFormat += '@';
                }
                else if (Array.IndexOf("уоиэыюеё".ToCharArray(), Char.ToLower(item)) != -1)
                {
                    strNewFormat += '*';
                }
                else if (item == ' ')
                {
                    strNewFormat += "!!! ";
                }
                else
                {
                    strNewFormat += item;
                }
            }
            strNewFormat += "!!!";
            return strNewFormat;
        }

    }
}
