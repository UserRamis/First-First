using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._12._21
{
    public abstract class Additional_Methods
    {
        public static void Close()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nНажмите");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Enter");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(", чтобы закончить.");
        button:
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key != ConsoleKey.Enter)
            {
                goto button;
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}