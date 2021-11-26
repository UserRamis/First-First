namespace LAB
{
	class BankAccount : Creation
	{
		public enum Type
		{
			Current,
			Saving
		}

		private Type accountType;
		private int balance;

		static int indexer = 0;

		internal BankAccount()
		{
			index = indexer++;
		}

		internal BankAccount(int balance)
		{
			index = indexer++;
			this.balance = balance;
		}

		internal BankAccount(Type accountType)
		{
			index = indexer++;
			this.accountType = accountType;
		}

		internal BankAccount(Type accountType, int balance) : this(accountType)
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
	}
}