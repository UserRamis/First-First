using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloween
{
    public class Human : Entity
    {
        public readonly bool witcher;
        public bool alive => inventory[ItemType.Life] > 0;
        public Human(bool witcher, bool adult) : base("Человек")
        {
            this.witcher = witcher;
            if (adult && !witcher)
            {
                inventory[ItemType.Candy] = 3;
                inventory[ItemType.Blood] = 1;
            }
            else if (!witcher)
            {
                inventory[ItemType.Candy] = 2;
                inventory[ItemType.Blood] = 0.5;
            }
        }
    }
}