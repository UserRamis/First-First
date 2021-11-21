using System;

namespace HOM
{
    class SlideGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"{name} играет горку");
        }
    }
}