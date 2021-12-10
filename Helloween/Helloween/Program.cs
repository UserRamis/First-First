using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloween
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            List<Monster> dieingMonsters = new List<Monster>();
            List<Monster> SleepingMonsters = new List<Monster>();
            #region Adding some humans
            List<Human> crowd = new List<Human>();
            for (int i = 0; i < 5; i++)
            {
                crowd.Add(new Human(false, true));
            }
            crowd.Add(new Human(true, true));
            for (int i = 0; i < 5; i++)
            {
                crowd.Add(new Human(false, false));
            }
            Shuffle(crowd);
            #endregion
            int mnstDieCount = 0;
            int mnstSleepCount = 0;
            int humanDieCount = 0;
            List<Monster> monsters = new List<Monster>();
            monsters.Add(new Monster(MonsterType.Vampire));
            monsters.Add(new Monster(MonsterType.Witch));
            monsters.Add(new Monster(MonsterType.Verewolf));
            monsters.Add(new Monster(MonsterType.Ghost));
            monsters.Add(new Monster(MonsterType.Demon));
            monsters.Add(new Monster(MonsterType.Zombie));
            monsters.Add(new Monster(MonsterType.BlackWidow));

            while (monsters.Count > 0)
            {
                foreach (var mnst in monsters)
                {
                    int index = rnd.Next(0, crowd.Count);
                    Console.WriteLine(mnst.Meet(crowd[index]));
                    if (mnst.Enough)
                    {
                        SleepingMonsters.Add(mnst);
                        mnstSleepCount++;
                        Console.WriteLine("Теперь этот монстр наелся и спит.");
                    }
                    else if (mnst.inventory[ItemType.Life] == 0 || mnst.lifespan == 0)
                    {
                        if (mnst.inventory[ItemType.Life] == 0)
                        {
                            Console.WriteLine($"Монстр [ID:{mnst.ID}] умирает от рук ведьмака");
                        }
                        else
                        {
                            Console.WriteLine($"Монстр [ID:{mnst.ID}] умирает от старости");
                        }
                        mnstDieCount++;
                        dieingMonsters.Add(mnst);
                    }
                    if (crowd[index].inventory[ItemType.Life] <= 0)
                    {
                        if (crowd[index].inventory[ItemType.Immortality] >= 1)
                        {
                            crowd[index].inventory[ItemType.Life] = 1;
                            Console.WriteLine($"Челик [ID:{crowd[index].ID}] бессметрный, поэтому улететь на тот свет не может");
                        }
                        else
                        {
                            Console.WriteLine($"Челик [ID:{crowd[index].ID}] умер");
                            humanDieCount++;
                            crowd.RemoveAt(index);
                        }
                    }
                    Console.WriteLine();
                }
                dieingMonsters.ForEach(x => monsters.Remove(x));
                SleepingMonsters.ForEach(x => monsters.Remove(x));
            }
            Console.WriteLine($"Итоги торжества");
            Console.WriteLine($"Всего монстров наелось и спят: {mnstSleepCount}");
            Console.WriteLine($"Всего монстров умерло: {mnstDieCount}");
            Console.WriteLine($"Всего людей умерло: {humanDieCount}");
            Console.ReadKey();
        }

        private static void Shuffle(List<Human> list)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int rndIndex1 = 0, rndIndex2 = 0;
            Human temp = null;
            for (int i = 0; i < list.Count * 3; i++)
            {
                rndIndex1 = rand.Next(0, list.Count);
                rndIndex2 = rand.Next(0, list.Count);
                temp = list[rndIndex1];
                list[rndIndex1] = list[rndIndex2];
                list[rndIndex2] = temp;
            }
        }
    }
}