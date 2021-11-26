using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace HM
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Билетная лотерея.\n\nСписок студентов:\n");

            ReadFromPathStudents();

            foreach (int index in data.Keys)
            {
                Console.WriteLine($"{index}. {data[index]}");
            }

            Queue<Draw> draws = new Queue<Draw>();

            string choice = "1";
            while (choice == "1")
            {
                //Информация по розыгрышу
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\nОписание розыгрыша: ");
                string name = Console.ReadLine();

                Console.Write("\nКоличество студентов, участвующих в розыгрыше: ");
            students:
                if (!int.TryParse(Console.ReadLine(), out int num_students))
                {
                    Console.WriteLine("Ошибка преобразования. Повторите ввод: ");
                    goto students;
                }

                Console.Write("\nКоличество билетов: ");
            tickets:
                if (!int.TryParse(Console.ReadLine(), out int num_tickets))
                {
                    Console.WriteLine("Ошибка преобразования. Повторите ввод: ");
                    goto tickets;
                }
                ///...

                List<int> exist = new List<int>();

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\nНомера студентов, участвующих в розыгрыше:");
                for (int i = 0; i < num_students; i++)
                {
                enter:
                    if (int.TryParse(Console.ReadLine(), out int number) && !exist.Contains(number) && number < (data.Count() + 1))
                    {
                        exist.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка преобразования. Повторите ввод: ");
                        goto enter;
                    }
                }
                Console.WriteLine();

                foreach (Draw draw in draws)
                {
                    foreach (int index in draw.Winners)
                    {
                        data[index].Ratio *= 0.5;
                    }
                }

                double ratio_sum = 0;
                foreach (int index in exist)
                {
                    ratio_sum += data[index].Ratio;
                }

                Stack<int> winNumbers = new Stack<int>();
                for (int i = 0; i < num_tickets; i++)
                {
                    Dictionary<double, int> pool = new Dictionary<double, int>();

                    double sum = 0;
                    foreach (int index in exist)
                    {
                        sum += data[index].Ratio / ratio_sum;
                        pool.Add(sum, index);
                    }

                    Random random = new Random();

                    double winNumber = random.NextDouble();
                    foreach (double range in pool.Keys)
                    {
                        if (winNumber < range)
                        {
                            winNumbers.Push(pool[range]);
                            exist.Remove(winNumbers.Peek());
                            ratio_sum -= data[winNumbers.Peek()].Ratio;
                            break;
                        }
                    }
                }

                draws.Enqueue(new Draw(name, num_tickets, winNumbers));
                WriteToPath(draws.Peek().ToString());

                Console.WriteLine("Информация по розыгрышам:");
                foreach (Draw draw in draws)
                {
                    Console.WriteLine(draw);
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1 - создать ещё один розыгрыш\n0 - выйти:");
                choice = Console.ReadLine();
                if (choice != "1" && choice != "0")
                {
                    Console.WriteLine("Ошибка: введено неверное значение. Выход из программы...");
                    Thread.Sleep(2500);
                    choice = "0";
                }
            }
        }
        public static Dictionary<int, Student> data = new Dictionary<int, Student>();
        static Dictionary<int, Student> ReadFromPathStudents()
        {
            StreamReader sr = new StreamReader(@"..\..\Student.txt");
            string[] students = sr.ReadToEnd().Trim().Split(Convert.ToChar("\n"));
            sr.Close();
            int index = 0;
            foreach (string line in students)
            {
                string[] studentt = line.Split();
                data.Add(++index, new Student(studentt[0], studentt[1], studentt[2])); //Добавление в директорию (индекс, студент)
            }
            return data;
        }
        static readonly string PathToOut = @"..\..\output.txt";
        static void WriteToPath(string str)
        {
            string sout = "";
            if (File.Exists(PathToOut))
            {
                StreamReader sr = new StreamReader(PathToOut);
                sout = sr.ReadToEnd();
                sr.Close();
            }
            StreamWriter sw = new StreamWriter(PathToOut);
            sw.Write(sout + str);
            sw.Close();
        }
    }
}