namespace LAB
{
    class BankFabric
    {
        public static HashTable hashTable;

        static BankFabric()
        {
            hashTable = new HashTable();
        }

        public static int CreateAccount()
        {
            BankAccount account = new BankAccount();
            hashTable.Add(account);
            return account.Index;
        }

        public static int CreateAccount(int balance)
        {
            BankAccount account = new BankAccount(balance);
            hashTable.Add(account);
            return account.Index;
        }

        public static int CreateAccount(BankAccount.Type accountType)
        {
            BankAccount account = new BankAccount(accountType);
            hashTable.Add(account);
            return account.Index;
        }

        public static int CreateAccount(int balance, BankAccount.Type accountType)
        {
            BankAccount account = new BankAccount(accountType, balance);
            hashTable.Add(account);
            return account.Index;
        }
        public static void DeleteAccount(int index)
        {
            hashTable.Delete(index);
        }
    }
}