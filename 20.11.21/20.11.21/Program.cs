using System;

namespace LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнения раздела 11");
            BankFabric.DeleteAccount(BankFabric.CreateAccount());



            Console.WriteLine("\nHomework 11.1 - 11.2");
            Creator.CreateAccount(1, 1, 1, 1);
            Creator.DeleteAccount(BankFabric.CreateAccount(322));

            Console.ReadLine();
        }
    }
}