using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Report
    {
        private string textReport;
        private DateTime delivery = new DateTime();
        private Employee employee;
        public DateTime DateDelivery
        {
            get { return delivery; }
        }
        public Report(string text, Employee employee)
        {
            textReport = text;
            this.employee = employee;
        }

        public static Report TakeReport(Employee employee)
        {
            Console.WriteLine("Какой текст отчета у сотрудника?");
            string text = Console.ReadLine();

            return new Report(text, employee);

        }
    }
}