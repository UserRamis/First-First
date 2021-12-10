using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 12.1");
            BankAccount a = new BankAccount(BankAccount.Type.Current, 1000);
            BankAccount b = new BankAccount(BankAccount.Type.Saving, 1000);
            Console.WriteLine(a != b);
            Console.WriteLine(a.Equals(b));
        }
    }
}
