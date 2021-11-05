using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClassWork
{
    class Program
    {
        static void Shuffle(ref List<Employee> list)
        {
            Random r = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                int swapIndex = r.Next(list.Count - 1);
                var temp = list[swapIndex];
                list[swapIndex] = list[i];
                list[i] = temp;
            }
        }
        static void Main(string[] args)
        {
            Employer teamLead = new Employer("Дина");
            Console.WriteLine("Количество дней на рещение задачи? ");
            int deadLine;
            while (!int.TryParse(Console.ReadLine(), out deadLine) || deadLine < 0)
            {
                Console.WriteLine("Ошибка!!Повторите");
            }
            DateTime date = DateTime.Now.AddDays(deadLine);
            Console.Clear();
            int countEmployees = 10;
            List<Employee> employees = new List<Employee>(countEmployees);
            employees.Add(new Employee("Витя", "Бажитов"));
            employees.Add(new Employee("Димон", "Абрамов"));
            employees.Add(new Employee("Игорян", "Сучков"));
            employees.Add(new Employee("Артём", "Гареев"));
            employees.Add(new Employee("София", "Кулагина"));
            employees.Add(new Employee("Вадим", "Гофман"));
            

            Shuffle(ref employees);
            int countTasks = countEmployees;
            List<Task> tasks = new List<Task>(countTasks);
            tasks.Add(new Task("Работа с текстом", "Напечатать текст заглавными буквами", teamLead));
            tasks.Add(new Task("Работа с клиентами", "Держать клиента в курсе всех новостей о проекте", teamLead));
            tasks.Add(new Task("Печатать", "Распечатать текст разными цветами на принтере", teamLead));
            tasks.Add(new Task("Удалить", "Удалить все элементы", teamLead));
            tasks.Add(new Task("Озвучка", "Озвучить сказку", teamLead));
            tasks.Add(new Task("Ничего не делать", "Написать заявление о увольнении", teamLead));
            Project project = new Project("Приложение", "Создать приложение к началу месяца", teamLead, tasks, date);
            if (project.Status.Equals(StatusOfProject.Assigned))
            {
                project.GiveProgect(employees);
                Employee.GiveTask(tasks, employees, deadLine);
                {
                    string letter = "Все задачи переданы";
                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (var ch in letter)
                    {
                        Console.Write(ch);
                        Thread.Sleep(50);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }


            while (employees.Count > 0)
            {
                Console.WriteLine("Выберите номер сотрудника,который сдает отчет:");

                for (int i = 0; i < employees.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {employees[i].Name} {employees[i].Surname}");
                }
                int index;
                while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > employees.Count)
                {
                    Console.WriteLine("Неверный ввод,повторите ввод!");
                }
                Report report = Report.TakeReport(employees[index - 1]);
                Employee.SendTask(employees[index - 1]);

                Console.WriteLine("Проверка прошла успешна?да/нет");
                bool input = Console.ReadLine().ToLower().Equals("да");
                if (input)
                {
                    Console.WriteLine("Работник сдал эту задачу!");
                    employees.Remove(employees[index - 1]);
                    report = null;
                }
                else
                {
                    Console.WriteLine("Задача отправлена на доработку!");
                    report = null;
                }
            }
            project.CloseProject();
        }
    }
}