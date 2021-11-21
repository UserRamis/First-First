using System;

namespace HOM
{
    class BeachGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"{name} играет пляж");
        }
    }
}