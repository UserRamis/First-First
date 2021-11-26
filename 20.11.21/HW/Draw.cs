using System.Collections.Generic;

namespace HM
{
    internal class Draw
    {
        public string Name;
        public int Tickets;
        public Stack<int> Winners;

        public Draw(string name, int tickets, Stack<int> winner)
        {
            Name = name;
            Tickets = tickets;
            Winners = winner;
        }
        public override string ToString()
        {
            string sout = "";
            foreach (int index in Winners)
            {
                sout += Program.data[index] + "\n";
            }
            return $"Название: {Name}, билетов: {Tickets}\n{sout}";
        }
    }
}