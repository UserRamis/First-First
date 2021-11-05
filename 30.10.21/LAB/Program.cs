using System;
using System.Collections.Generic;
using System.IO;


namespace Lab_9
{

	class Program
	{
		class BankAccount
		{
			public enum Type
			{
				Current,
				Saving
			}
            private int index;
            private Type accountType;
            private int balance;
			private Queue<BankTransaction> transactions;

			static int indexer = 0;

			public BankAccount()
			{
				index = indexer++;
				transactions = new Queue<BankTransaction>();
			}

			public BankAccount(int Balance)
			{
				index = indexer++;
				balance = Balance;
				transactions = new Queue<BankTransaction>();
			}

			public BankAccount(Type AccountType)
			{
				index = indexer++;
				accountType = AccountType;
				transactions = new Queue<BankTransaction>();
			}

			public BankAccount(Type AccountType, int Balance)
			{
				accountType = AccountType;
				balance = Balance;
			}

			public bool Withdraw(int sum)
			{
				if (sum <= balance)
				{
					balance -= sum;
					transactions.Enqueue(new BankTransaction(-1 * sum));
					return true;
				}
				else
				{
					return false;
				}
			}
			public bool Put_In_Balance(int sum)
			{
				if (sum > 0)
				{
					balance += sum;
					transactions.Enqueue(new BankTransaction(sum));
					return true;
				}
				else
				{
					return false;
				}
			}
			public bool Transfer(BankAccount accPaymentReceiver, int sum)
			{
				if (Withdraw(sum))
				{
					accPaymentReceiver.Put_In_Balance(sum);
					return true;
				}
				else
				{
					return false;
				}
			}
			public void Dispose(string file)
			{
				StreamWriter stream = new StreamWriter(file);
				stream.Write(string.Join("\n", transactions));
				stream.Close();
				GC.SuppressFinalize(stream);
			}
		}
		class BankTransaction
		{
			private readonly DateTime date;
			private readonly TimeSpan time;
			private readonly int sum;
			public BankTransaction(int Sum)
			{
				date = DateTime.Now.Date;
				time = DateTime.Now.TimeOfDay;
				sum = Sum;
			}
			public override string ToString() => $"{date.ToShortDateString()} {time} {sum}";
		}
		class Song
		{
			string name;
			string author;
			Song previous;
			public Song()
			{

			}
			public Song(string Name, string Author)
			{
				name = Name;
				author = Author;
				previous = null;
			}
			public Song(string Name, string Author, Song Previous)
			{
				name = Name;
				author = Author;
				previous = Previous;
			}
		}
		static void Main(string[] args)
		{
			Song mySong = new Song();



		}
	}
}