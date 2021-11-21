using System;

namespace HOM
{
    class MousetrapGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"{name} играет мышеловку");
        }
    }
}