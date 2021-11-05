using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public enum StatusOfTask
    {
        Assigned,
        InProcess,
        OnCheck,
        Complited
    }
    class Task
    {
        public StatusOfTask Status { get; private set; }
        private string description;
        private string name;
        private Employer employer;
        private List<Report> reports = new List<Report>();
        private DateTime deadline = new DateTime();
        public DateTime DateDeadline
        {
            get { return deadline; }
        }
        public Task(string name, string description, Employer teamLead)
        {
            this.name = name;
            this.description = description;
            employer = teamLead;
            Status = StatusOfTask.Assigned;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Задача {name}, Описание: {description}");
        }
        public void TaskAdded(int deadline)
        {
            this.deadline = DateTime.Now.AddDays(deadline);
            Status = StatusOfTask.InProcess;
        }
        public static void GiveOnCheck(Task task)
        {
            if (task != null && task.Status == StatusOfTask.InProcess)
            {
                task.Status = StatusOfTask.InProcess;
            }
        }
    }
}