using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Employee
    {
        private string name;
        private string surname;
        private Task currentTask;


        public Task CurrentTask
        {
            get { return currentTask; }
            private set { currentTask = value; }
        }


        public string Name
        {
            get { return name; }
        }
        public string Surname
        {
            get { return surname; }
        }
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public static void GiveTask(List<Task> tasks, List<Employee> employees, int deadline)
        {
            List<Task> tmpTasks = new List<Task>(tasks.Count);
            tmpTasks.AddRange(tasks);
            int counterTasks = 0;
            int countTasks = tasks.Count;
            for (int i = 0; i < employees.Count; i++)
            {
                int retryCounter = 0;
                for (int j = 0; j < tmpTasks.Count; j++)
                {

                    Console.WriteLine($"Задач осталось для выбора : {countTasks - counterTasks - retryCounter - 1}");
                    Console.WriteLine($"Задача {counterTasks + 1}");
                    tmpTasks[j].PrintInfo();
                    Console.WriteLine($"Согласен ли сотрудник {employees[i].Name} {employees[i].Surname} выполнять ее?да/нет");
                    string input = Console.ReadLine().ToLower();
                    if (!input.Equals("нет") || j == tmpTasks.Count - 1)
                    {
                        if (tasks.Count - 1 == j)
                        {
                            Console.WriteLine("Ну что ж! Все задачи закончились, кроме последней, придется дать ее.");
                        }
                        employees[i].currentTask = tmpTasks[j];
                        employees[i].currentTask.TaskAdded(deadline);
                        tmpTasks.Remove(tmpTasks[j]);
                        Console.WriteLine("Задача успешно передана!Нажмите enter для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        retryCounter++;
                    }
                }
                counterTasks++;
            }

        }
        public static void SendTask(Employee employee)
        {
            if (employee.currentTask != null && employee.currentTask.Status == StatusOfTask.InProcess)
            {
                Task.GiveOnCheck(employee.currentTask);
            }
        }

    }
}