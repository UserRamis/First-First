#define DEBUG_ACCOUNT //Директива, которая использует идентификатор DEBUG_ACCOUNT и запускает Method DumpToScreen

using System;


namespace _11._12._21
{
    class Program : Additional_Methods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите какое задание открыть?\n1)Лабораторная работа 14.1\n2)Лабораторная работа 14.2\n3)Домашняя работа 14.1");
            int n = Convert.ToInt32(Console.ReadLine());
            Type typeInfo = typeof(RationalNumbers);
            object[] attributes = typeInfo.GetCustomAttributes(false);
            switch (n)
            {
                case 1:
                    Console.WriteLine("\n#######Лабораторная работа 14.1#######");
                    BankAccount acc = new BankAccount(6.4323, 621356536, BankAccount.Type.Current);
                    BankAccount.DumpToScreen(acc);
                    break;

                case 2:
                    Console.WriteLine("\n#######Лабораторная работа 14.2#######");
                    RationalNumbers rational = new RationalNumbers();                    
                    Console.WriteLine("typeof(RationalNumber): " + typeInfo);                    
                    Console.WriteLine("Дата разработки: " + (attributes[0] as DeveloperInfoAttribute).Time + "\nРазработчик: " + (attributes[0] as DeveloperInfoAttribute).Developer);
                    break;

                case 3:
                    Console.WriteLine("\n#######Домашняя работа 14.1#######");
                    Console.Write("typeof(OrganizationInfoAttribute) = " + typeof(DeveloperInfoAttribute) + "\n");
                    Console.WriteLine("Разработчик: " + (attributes[1] as OrganizationInfoAttribute).Developer + "\nКомпания: " + (attributes[1] as OrganizationInfoAttribute).Organization);
                    break;

                default:
                    Console.WriteLine("Ошбика! Введите число от 1 до 3!");
                    break;
            
            
            }      
            Console.ReadKey();           
        }        
        public bool IsFormattable(object param) => param is IFormattable;

       
        public bool AsFormattable(object param) => param as IFormattable != null;
    }
}