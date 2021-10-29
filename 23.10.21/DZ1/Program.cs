using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>();
            int lastID = 0;
            employees.Add(new Boss("Борис", ref lastID));
            employees.Add(new BossAssistant("О Ильхам", ref lastID, employees[lastID - 1]));
            employees.Add(new MainDeveloper("Сергей", ref lastID, employees[lastID - 1]));
            employees.Add(new MainSystemEmployee("Ильшат", ref lastID, employees[lastID - 2]));
            employees.Add(new AssistantSystemEmployee("Иваныч", ref lastID, employees[lastID - 1]));
            employees.Add(new AssistantDeveloper("Ляйсан", ref lastID, employees[lastID - 3]));
            employees.Add(new Developer("Марат", ref lastID, employees[lastID - 1]));
            employees.Add(new Developer("Антон", ref lastID, employees[lastID - 2]));
            employees.Add(new Developer("Ильдар", ref lastID, employees[lastID - 3]));
            employees.Add(new Developer("Дина", ref lastID, employees[lastID - 4]));
            employees.Add(new SystemEmployee("Илья", ref lastID, employees[lastID - 6]));
            employees.Add(new SystemEmployee("Витя", ref lastID, employees[lastID - 7]));
            employees.Add(new SystemEmployee("Женя", ref lastID, employees[lastID - 8]));

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите команду <Задача>, чтобы дать задачу; <Выйти> чтобы завершить программу");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "задача":
                        Employee.GiveTask(employees);
                        break;
                    case "выйти":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Неверная команда!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Задачи на сегодня завершены,время отдыхать!");

        }
    }
}