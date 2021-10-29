using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Boss : Employee
    {
        public Boss()
        {

        }
        public Boss(string name, ref int lastID) : base(name, ref lastID)
        {

        }
        public Boss(string name, string surname, Employee head, ref int lastID) : base(name, surname, head, ref lastID)
        {

        }
    }
}