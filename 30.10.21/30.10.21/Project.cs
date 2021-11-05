using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public enum StatusOfProject
    {
        Assigned,
        Perfomance,
        Closed
    }
    class Project
    {
        public StatusOfProject Status { get; private set; }
        private string description;
        private string name;
        private Employer employer;
        private List<Task> tasks = new List<Task>();
        private DateTime deadline;
        public Project(string name, string description, Employer teamLead, List<Task> tasks, DateTime deadline)
        {
            this.deadline = deadline;
            this.name = name;
            this.description = description;
            employer = teamLead;
            this.tasks = tasks;
            Status = StatusOfProject.Assigned;
        }
        public void GiveProgect(List<Employee> employees)
        {
            bool projectIsAvaliable = true;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i] == null)
                {
                    Console.WriteLine("Проект нельзя сформировать,некоторые работники не получили задачи!");
                    projectIsAvaliable = false;
                }
            }
            if (projectIsAvaliable)
            {
                this.Status = StatusOfProject.Perfomance;
                Console.WriteLine("Проект принят на исполнение");
            }
        }
        public void CloseProject()
        {
            if (Status == StatusOfProject.Perfomance && this != null)
            {
                Status = StatusOfProject.Closed;
            }
            if (deadline < DateTime.Now)
            {
                Console.WriteLine("Не успели сделать проект в срок!Уволены!!!");
            }
            else
            {
                Console.WriteLine("Успели сделать проект в срок! Всем по конфете!");
            }
        }
    }
}