using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 6.1");
            char[] vowels = "АЕЁИОУЫЭЮЯ".ToLower().ToCharArray(); //Гласные
            char[] consonants = "БВГДЖЗЙКЛМНПРСТФХЦЧШЩЬЪ".ToLower().ToCharArray(); //Согласные

            string text = File.ReadAllText("C:\\Users\\user9\\source\\repos\\09.10.21\\Буквы.txt"); //Строка
            char[] array = text.ToLower().ToCharArray(); //Разбиваем строку на массив символов

            int vowelsCount = GetCount(array, vowels); //Количество гласных
            int consonantsCount = GetCount(array, consonants); //Количество согласных

            Console.WriteLine("Гласных в массиве: " + vowelsCount);
            Console.WriteLine("Согласных в массиве: " + consonantsCount);
            Console.ReadKey();


            Console.WriteLine("\nTask 6.2");
            LinkedList<int> matrix1 = new LinkedList<int>();
            LinkedList<int> matrix2 = new LinkedList<int>();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Введите a({i + 1},{j + 1}) для 1ой и 2ой матрицы:");
                    matrix1.AddLast(Convert.ToInt32(Console.ReadLine()));
                    matrix2.AddLast(Convert.ToInt32(Console.ReadLine()));

                }
            }
            Console.WriteLine("1 - печать матриц\n2 - умножение матриц\nВыберите: ");
            try
            {
            start:
                int todo = Convert.ToInt32(Console.ReadLine());
                if (todo == 1)
                {
                    Press(matrix1, matrix2);
                }
                else if (todo == 2)
                {
                    Multiplication(matrix1, matrix2);
                }
                else
                {
                    Console.WriteLine("Ошибка: введеное неверное число. Повторите ввод: ");
                    goto start;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введён неверный формат.");
            }














            Console.WriteLine("Task 6.3");
            int sum, numberofmonth = 0;
            Random rnd = new Random();
            int[] temperature = new int[30];
            int[] months = new int[12];
            for (int m = 0; m < 12; m++) //заполнение месяцей и дней температурами
            {
                sum = 0;
                for (int i = 0; i < 30; i++)
                {
                    temperature[i] = rnd.Next(12, 30);
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
                        int buffer = months[k];
                        months[k] = months[l];
                        months[l] = buffer;
                    }
                }
            }
            Console.WriteLine("отсортированный массив: " + string.Join(", ", months));

            Console.ReadKey();
        }

            static  void AverageTemperature(int Numberofmonth, int Sum, int[] Months)
            {
                Months[Numberofmonth] = Sum / 30;
                Console.WriteLine($"в {Numberofmonth + 1} месяце: " + Months[Numberofmonth]);
            }


             static int GetCount(char[] array, char[] ar)
             {
            int Count = 0;

            foreach (char ch in array)
                foreach (char cha in ar)
                    if (ch == cha)
                        Count++;

            return Count;

             }


        static void Press(LinkedList<int> Array1, LinkedList<int> Array2)
        {
            Console.WriteLine("1ая матрица:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(Array1.First() + " ");
                if (i == 1 || i == 3)
                {
                    Console.WriteLine();
                }
                Array1.RemoveFirst();
            }
            Console.WriteLine("2ая матрица:");
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
        static void Multiplication(LinkedList<int> matrix1, LinkedList<int> matrix2)
        {
            int a11, a12, a21, a22;
            a11 = matrix1.ElementAt(0) * matrix2.ElementAt(0) + matrix1.ElementAt(1) * matrix2.ElementAt(2);
            a12 = matrix1.ElementAt(0) * matrix2.ElementAt(1) + matrix1.ElementAt(1) * matrix2.ElementAt(3);
            a21 = matrix1.ElementAt(2) * matrix2.ElementAt(0) + matrix1.ElementAt(3) * matrix2.ElementAt(2);
            a22 = matrix1.ElementAt(2) * matrix2.ElementAt(1) + matrix1.ElementAt(3) * matrix2.ElementAt(3);
            Console.WriteLine(a11 + " " + a12 + "\n" + a21 + " " + a22);
        }



















    }

}
