using System;
using System.Diagnostics;

namespace _11._12._21
{
	class BankAccount
	{
		public enum Type
		{
			Current = 1,
			Saving
		}

		private readonly Type accountType;
		private readonly int number;
		private readonly double balance;
		private readonly int index;
		static int indexer = 4350;

		public BankAccount()
		{
			
			index = indexer++;
		}
		public BankAccount(double balance)
		{
			this.balance = balance;
			index = indexer++;
		}
		public BankAccount(Type accountType)
		{
			this.accountType = accountType;
			index = indexer++;
		}
		public BankAccount(int number)
		{
			this.number = number;
			index = indexer++;
		}
		public BankAccount(Type accountType, int number)
		{
			this.number = number;
			this.accountType = accountType;
			index = indexer++;
		}
		public BankAccount(Type accountType, double balance)
		{
			this.balance = balance;
			this.accountType = accountType;
			index = indexer++;
		}
		public BankAccount(double balance, int number)
		{
			this.balance = balance;
			this.number = number;
			index = indexer++;
		}
		public BankAccount(double balance, int number, Type accountType)
		{
			this.balance = balance;
			this.number = number;
			this.accountType = accountType;
			index = indexer++;
		}



		[Conditional("DEBUG_ACCOUNT")] //Условный атрибут	14.2
		public static void DumpToScreen(BankAccount acc)
		{
			Console.WriteLine($"Тип счёта: {acc.accountType}\nБаланс счёта: {acc.balance}\nИндекс счёта: {acc.index}\nНомер счёта: {acc.number}");
		}
	}
}