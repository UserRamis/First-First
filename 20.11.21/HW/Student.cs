using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public double Ratio;

        public Student(string name, string surname, string group)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Ratio = 1;
        }

        public override string ToString()
        {
            return $"Имя: {Name}\nФамилия: {Surname}\nГруппа: {Group}";
        }
    }
}