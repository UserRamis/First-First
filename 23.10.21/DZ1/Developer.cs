using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Developer : Employee
    {
        public Developer()
        {

        }
        public Developer(string name, ref int lastID, Employee head) : base(name, ref lastID, head)
        {

        }
        public Developer(string name, string surname, Employee head, ref int lastID) : base(name, surname, head, ref lastID)
        {

        }
    }
}