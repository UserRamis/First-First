using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class MainDeveloper : Employee
    {
        public MainDeveloper()
        {

        }
        public MainDeveloper(string name, ref int lastID, Employee head) : base(name, ref lastID, head)
        {

        }
        public MainDeveloper(string name, string surname, Employee head, ref int lastID) : base(name, surname, head, ref lastID)
        {

        }
    }
}