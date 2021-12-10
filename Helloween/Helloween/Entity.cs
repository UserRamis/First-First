using System.Collections.Generic;

namespace Helloween
{
    public abstract class Entity
    {
        public readonly ulong ID;
        public readonly string name;
        public Dictionary<ItemType, double> inventory;

        private static ulong IDcounter;

        public Entity(string name)
        {
            ID = IDcounter++;
            this.name = name;
            inventory = new Dictionary<ItemType, double>();
            inventory.Add(ItemType.Blood, 0);
            inventory.Add(ItemType.Candy, 0);
            inventory.Add(ItemType.Life, 1);
            inventory.Add(ItemType.Immortality, 0);
        }
    }

    public enum ItemType
    {
        Blood,
        Candy,
        Life,
        Immortality
    }
}