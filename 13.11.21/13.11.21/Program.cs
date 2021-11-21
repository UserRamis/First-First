using System;

namespace HOM
{
    class Program
    {
        static void Main(string[] args)
        {
            Team[] teams = 
            {
                new Team("Россия"),
                new Team("Франция"),
                new Team("Китай"),
                new Team("Украина")
            };

            foreach (Team team in teams)
            {
                team.ToPlay(new BeachGame());
                team.ToPlay(new FishingGame());
                team.ToPlay(new MousetrapGame());
                team.ToPlay(new PostmanGame());
                team.ToPlay(new SeaGame());
                team.ToPlay(new SlideGame());
                team.ToPlay(new MyGame());
                team.ToPlay(new MyGame1());
            }

            Console.ReadLine();
        }
    }
}

