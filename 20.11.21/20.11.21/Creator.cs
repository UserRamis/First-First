namespace LAB
{
    class Creator
    {
        public static HashTable hashTable;

        static Creator()
        {
            hashTable = new HashTable();
        }

        public static int CreateAccount()
        {
            Building building = new Building();
            hashTable.Add(building);
            return building.Index;
        }

        public static int CreateAccount(double high, int storeys, int aparts, int entrances)
        {
            Building building = new Building(high, storeys, aparts, entrances);
            hashTable.Add(building);
            return building.Index;
        }
        public static void DeleteAccount(int index)
        {
            hashTable.Delete(index);
        }
    }
}