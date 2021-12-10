using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1
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

		static int indexer = 0;

		public BankAccount()
		{
			index = indexer++;
		}

		public BankAccount(int balance)
		{
			index = indexer++;
			this.balance = balance;
		}

		public BankAccount(Type accountType)
		{
			index = indexer++;
			this.accountType = accountType;
		}

		public BankAccount(Type accountType, int balance) : this(accountType)
		{
			this.balance = balance;
		}

		public bool Withdraw(int sum)
		{
			if (sum <= balance)
			{
				balance -= sum;
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool PutInBalance(int sum)
		{
			if (sum > 0)
			{
				balance += sum;
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool MakeTransfer(BankAccount accPaymentReceiver, int sum)
		{
			if (Withdraw(sum))
			{
				accPaymentReceiver.PutInBalance(sum);
				return true;
			}
			else
			{
				return false;
			}
		}
		public static bool operator ==(BankAccount bankAccount1, BankAccount bankAccount2)
		{
			return bankAccount1.accountType == bankAccount2.accountType
				&& bankAccount1.balance == bankAccount2.balance;
		}

		public static bool operator !=(BankAccount bankAccount1, BankAccount bankAccount2)
		{
			return !(bankAccount1.accountType == bankAccount2.accountType
				&& bankAccount1.balance == bankAccount2.balance);
		}
		public override bool Equals(object obj)
		{
			if (obj is BankAccount)
			{
				return this == (obj as BankAccount);
			}
			else
			{
				return false;
			}
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		public override string ToString()
		{
			return $"{index}. Тип: {accountType}, баланс: {balance}";
		}
	}
}
