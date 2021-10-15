using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;


namespace ClassTask
{
    class Program
    {
        private const string PathToListStudent = "C:\\Users\\user9\\source\\repos\\09.10.21\\Data.txt";
        

        static void Main(string[] args)
        {


            Console.WriteLine("Task 1");
            Console.Write("Введите кол-во пятерок первой команды ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во пятерок второй команды ");
            int n2 = int.Parse(Console.ReadLine());
            if (n1 <= 9 && n2 < 9)
            {
                int[] team1 = new int[n1];
                int[] team2 = new int[n2];
                if (team1.Length == team2.Length)
                { Console.WriteLine("«Drinks All Round! Free Beers on Bjorg!»"); }
                else
                { Console.WriteLine("«Ой, Бьорг - пончик! Ни для кого пива!»"); }
            }
            else
                Console.WriteLine("Ошибка введите числа от 0 до 9!");




            Console.WriteLine("Task 2");
            List<int> Pictures = new List<int>();
            string Numberfromfile; int numberofstring = 0;
            StreamReader sr = new StreamReader("C:\\Users\\Huawei\\source\\repos\\ClassTasks9.10.21\\Numbers.txt");
            while ((Numberfromfile = sr.ReadLine()) != null)
            {
                Pictures[numberofstring] = Convert.ToInt32(Numberfromfile);
                numberofstring++;
            }
            Random rnd = new Random();
            foreach (int numb in Pictures)
            {
                int random = rnd.Next(1, 64);
                int buffer = Pictures[random];
                Pictures[random] = Pictures[numb];
                Pictures[numb] = buffer;
                Console.WriteLine(Pictures[numb] + ", ");
            }



            Console.WriteLine("\nTask 3");
            string stringfromfile; int numberString = 1;
            Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();
            StreamReader fileTextRead = new StreamReader(PathToListStudent);
            while ((stringfromfile = fileTextRead.ReadLine()) != null) //считывание файла построчно пока не кончатся символы
            {
                string[] dateStudent = stringfromfile.Split();
                Student studentNew; //создание нового студента
                studentNew.surname = dateStudent[0];
                studentNew.name = dateStudent[1];
                studentNew.YearOfBirth = Convert.ToUInt16(dateStudent[2]);
                studentNew.subject = dateStudent[3];
                studentNew.scores = Convert.ToUInt16(dateStudent[4]);
                studentDictionary.Add(dateStudent[0] + " " + dateStudent[1], studentNew);
                numberString++; //переход на следующую строку
            }
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("* * * Меню * * *\n1.Добавить нового студента\n2.Удалить студента по имени и фамилии\n3. Сортировать по баллам");
                Console.Write("Выберите действие. Нажми цифру: ");
                byte choiсe = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();
                switch (choiсe)
                {
                    case 1:
                        Student studentNew;
                        Console.Write("Введите имя: ");
                        studentNew.name = Console.ReadLine();
                        Console.Write("Введите фамилию студента: ");
                        studentNew.surname = Console.ReadLine();
                        Console.Write("Введите год рождения: ");
                        studentNew.YearOfBirth = Convert.ToUInt16(Console.ReadLine());
                        Console.Write("Введите основной предмет: ");
                        studentNew.subject = Console.ReadLine();
                        Console.Write("Введите количество баллов: ");
                        studentNew.scores = Convert.ToUInt16(Console.ReadLine());
                        studentDictionary.Add(studentNew.name + " " + studentNew.surname, studentNew);
                        break;
                    case 2:
                        Console.Write("Введите имя и фамилию студента: ");
                        string studentRemove = Console.ReadLine();
                        if (!studentDictionary.Remove(studentRemove))
                        {
                            Console.WriteLine("Ошибка: такого студента не существует");
                        }
                        break;
                    case 3:
                        List<Student> studentsList = new List<Student>();
                        foreach (var item in studentDictionary)
                        {
                            studentsList.Add(item.Value);
                        }
                        foreach (var item in QuickSortListStruct(studentsList))
                        {
                            Console.WriteLine(item.name + " " + item.surname + " "
                                + item.YearOfBirth + " " + item.subject + " " + item.scores);
                        }
                        break;
                    default:
                        flag = false;
                        break;
                }
            }










            Console.WriteLine("Task 4");
            



            Console.ReadKey();
        }





        static List<Student> QuickSortListStruct(List<Student> list)
        {
            int left = 0, right = list.Count() - 1;
            Student a, b;
            if (left >= right)
            {
                return list;
            }
            var fundation = left - 1;
            for (var i = left; i < right; i++)
            {
                if (list[i].scores < list[right].scores)
                {
                    fundation++;
                    a = list[fundation];
                    b = list[i];
                    Swap(ref a, ref b);
                }
            }
            return list;
        }
        static List<Student> QuickSortListStruct(List<Student> list, int left, int right)
        {
            Student a, b;
            if (left >= right)
            {
                return list;
            }
            var fundation = left - 1;
            for (var i = left; i < right; i++)
            {
                if (list[i].scores < list[right].scores)
                {
                    fundation++;
                    a = list[fundation];
                    b = list[i];
                    Swap(ref a, ref b);
                }
            }

            fundation++;
            a = list[fundation];
            b = list[right];
            Swap(ref a, ref b);
            QuickSortListStruct(list, left, fundation - 1);
            QuickSortListStruct(list, fundation + 1, right);

            return list;
        }
        static void Swap(ref Student x, ref Student y)
        {
            var t = x;
            x = y;
            y = t;
        }

        struct Employee
        {
            public string name;
            public string position;
            public byte impudence;
            public bool stupidity;
            public List<Employee> mates;
        }
        struct Student
        {
            public string name;
            public string surname;
            public ushort YearOfBirth;
            public string subject;
            public ushort scores;
        }
        struct Table
        {
            public string colour;
            public byte number;
            public List<Employee> persons;
        }

        





























    }

} 