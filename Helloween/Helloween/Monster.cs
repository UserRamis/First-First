using System;
using System.Text;

namespace Helloween
{
    public class Monster : Entity
    {
        public readonly Random rnd;
        public readonly ItemType needs;
        public double needAmount;
        public readonly ItemType gives;
        public double giveAmount;
        public byte lifespan;

        public bool Enough => needAmount == 0;
        public Monster(MonsterType type) : base(type.ToString())
        {
            rnd = new Random(DateTime.Now.Millisecond + (int)ID);
            switch (type)
            {
                case MonsterType.Vampire:
                    lifespan = 10;
                    needs = ItemType.Blood;
                    needAmount = 2;
                    gives = ItemType.Immortality;
                    giveAmount = 1;
                    break;
                case MonsterType.Witch:
                    lifespan = 5;
                    needs = ItemType.Blood;
                    needAmount = 1;
                    gives = ItemType.Candy;
                    giveAmount = 5;
                    break;
                case MonsterType.Verewolf:
                    lifespan = 5;
                    needs = ItemType.Life;
                    needAmount = 1;
                    break;
                case MonsterType.Ghost:
                    lifespan = 5;
                    needs = ItemType.Candy;
                    needAmount = 5;
                    gives = ItemType.Candy;
                    giveAmount = 5;
                    break;
                case MonsterType.Demon:
                    lifespan = 10;
                    needs = ItemType.Life;
                    needAmount = 1;
                    gives = ItemType.Blood;
                    giveAmount = 1;
                    break;
                case MonsterType.Zombie:
                    lifespan = 5;
                    needs = ItemType.Blood;
                    needAmount = 1.5;
                    break;
                case MonsterType.BlackWidow:
                    lifespan = 10;
                    needs = ItemType.Candy;
                    needAmount = 3;
                    gives = ItemType.Blood;
                    giveAmount = 1.5;
                    break;
            }
        }

        public string Meet(Human meet)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"Монстр:{name}[ID:{ID}] происходит встреча с человеком: [ID:{meet.ID}] и ");
            lifespan -= 1;
            if (rnd.Next(0, 11) < 3)
            {
                //gives
                meet.inventory[gives] += giveAmount;
                builder.Append($"дарит ему {giveAmount} {gives}");
            }
            else
            {
                //takes
                if (meet.witcher)
                {
                    inventory[ItemType.Life] = 0;
                    builder.Append($"он оказался ведьмаком");
                    //kills monster
                }
                else
                {
                    if (meet.inventory[needs] > 0 && meet.inventory[needs] < needAmount)
                    {
                        builder.Append($"забирает у него {meet.inventory[needs]} {needs}");
                        inventory[needs] += meet.inventory[needs];
                        needAmount -= meet.inventory[needs];
                        meet.inventory[needs] = 0;
                    }
                    else if (meet.inventory[needs] > 0 && meet.inventory[needs] >= needAmount)
                    {
                        builder.Append($"забирает у него {needAmount} {needs}");
                        inventory[needs] += needAmount;
                        meet.inventory[needs] -= needAmount;
                        needAmount = 0;
                    }
                    else if (meet.inventory[needs] == 0)
                    {
                        builder.Append($"ничего невозможно сделать, т.к. у него недостаточно {needs}");
                    }
                }
            }
            return builder.ToString();
        }
    }

    public enum MonsterType
    {
        Vampire = 0,
        Witch = 1,
        Verewolf = 2,
        Ghost = 3,
        Demon = 4,
        Zombie = 5,
        BlackWidow = 6
    }
}