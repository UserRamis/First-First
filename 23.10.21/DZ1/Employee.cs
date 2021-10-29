using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    abstract class Employee
    {
        public string Post { get; protected set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public Employee Head { get; private set; }
        public int id { get; private set; }

        public Employee() { }
        public Employee(string name, ref int lastID)
        {
            lastID++;
            Name = name;
            id = lastID;
        }
        public Employee(string name, ref int lastID, Employee head)
        {
            lastID++;
            Name = name;
            id = lastID;
            Head = head;
        }
        public Employee(string name, string surname, Employee head, ref int lastID)
        {
            lastID++;
            Name = name;
            Surname = surname;
            id = lastID;
            Head = head;
        }
        private List<Task> tasks = new List<Task>();
        public virtual void PrintInfo()
        {
            if (Surname == null)
            {
                Surname = "У работника нет фамилии";
            }
            if (Head == null)
            {
                Console.WriteLine("Он босс!");
            }
            Console.WriteLine($"Имя работника {Name}, фамилия работника {Surname}, id работника {id}");
        }
        public static void GiveTask(List<Employee> employees)
        {
            Console.WriteLine("Введите имя того,кто даёт задачу:");
            string name = Console.ReadLine();
            Employee employee1 = new Developer();
            bool CanGiveTask = false;
            Type typeBossGivingTask = employee1.GetType();
            foreach (var employee in employees)
            {
                if ((employee.Name == name) && !(employee is SystemEmployee) && !(employee is Developer))
                {
                    CanGiveTask = true;
                    typeBossGivingTask = employee.GetType();
                    Console.WriteLine("Данные работника,который даёт задачу:");
                    employee.PrintInfo();
                    Console.WriteLine("Он даёт задачу!");
                }
            }
            if (!CanGiveTask)
            {
                Console.WriteLine("Этот работник не может дать задачу");
            }
            else
            {
                Console.WriteLine("Введите имя работника,которому нужно дать задачу:");
                name = Console.ReadLine();
                for (int i = 0; i < employees.Count; i++)
                {
                    if (employees[i].Head == null)
                    {
                        continue;
                    }
                    if (employees[i].Name == name && employees[i].Head.GetType() == typeBossGivingTask)
                    {
                        Console.WriteLine("Задача может быть передана этому работнику!");
                        employees[i].tasks.Add(Task.CreateTask());
                    }
                }
            }
        }
    }
}