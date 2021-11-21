using System;

namespace HOM
{
    class FishingGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"{name} играет рыбалку");
        }
    }
}
