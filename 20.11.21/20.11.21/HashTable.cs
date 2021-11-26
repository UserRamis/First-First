using System.Collections.Generic;

namespace LAB
{
    public class HashTable
    {
        private Dictionary<int, Creation> table;

        public HashTable()
        {
            table = new Dictionary<int, Creation>();
        }

        internal void Add(Creation creation)
        {
            table.Add(creation.Index, creation);
        }

        internal void Delete(int index)
        {
            table.Remove(index);
        }
    }
}