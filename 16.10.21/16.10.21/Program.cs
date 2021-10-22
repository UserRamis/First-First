using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._10._21
{
    class BankAccounts
    {
        public enum typeAcc
        {
            currentAccount = 1,
            savingAccount
        }
        public struct Account
        {
            public ulong number;
            public double balance;
            public typeAcc type;
        }
        public void CreateAndPrintAccounts()
        {
            Dictionary<byte, Account> Accounts = new Dictionary<byte, Account>();
            int r;
            byte accountNumber = 0;
            List<int> randomList = new List<int>();
            Console.Write("Сколько количетсво банковских счетов у вас имеется? ");
            byte.TryParse(Console.ReadLine(), out byte accountCount);
            while (accountNumber <= (accountCount + 1))
            {
                Account newUser;

                Console.Write("1.Текущий счёт \n2. Сберегательный счёт \nВыберите счёт: ");
                newUser.type = (typeAcc)Convert.ToByte(Console.ReadLine());
            random:
                Random rnd = new Random();
                r = rnd.Next(1, 99999);
                if (randomList.Contains(r))
                {
                    goto random;
                }
                else
                {
                    randomList.Add(r);
                    newUser.number = Convert.ToUInt64(r);
                }

                Console.Write("Введите номер: " + newUser.number);
                string number = Console.ReadLine();
                ulong.TryParse(number, out newUser.number);

                Console.Write("Введите баланс: ");
                string balance = Console.ReadLine();
                double.TryParse(balance, out newUser.balance);

                Accounts.Add(accountNumber, newUser);
                accountNumber++;
                accountCount--;
            }

            foreach (KeyValuePair<byte, Account> keyValue in Accounts)
            {
                Console.WriteLine($"Тип {keyValue.Key + 1} счёта : {keyValue.Value.type}\nНомер {keyValue.Key + 1} счёта: {keyValue.Value.number}\nБаланс {keyValue.Key + 1} счёта: {keyValue.Value.balance}");
            }

            //////////////////////////////////////////

            Console.Write("Введите дейтсвие:\nСнять наличные-1\nПоложить наличные");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите баланс: ");
            int balanc = Convert.ToInt32(Console.ReadLine());




            switch (q)
            {
                case 1:
            Console.Write("Введите сумму, которую хотите снять ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            if (n > balanc)
            {
                Console.Write("Ошибка! Недостаточно средств!");
            }
            else
            {
                int ost = balanc - n;
                Console.Write("Баланс вашего счета составит " + ost);
            }
                    break;

                case 2:
                    Console.Write("Введите сумму, которую хотите внести ");
                    int w = Convert.ToInt32(Console.ReadLine());
                    int e = balanc + w;
                    Console.Write("Ваш баланс составит: " + e);
                    break;

            }
        }

       








    }
    class Body : BankAccounts
    {
        static void Main()
        {
            BankAccounts Dictionary = new BankAccounts();
            Dictionary.CreateAndPrintAccounts();
            
            Console.ReadKey();
       
        
        
        }
    }
}