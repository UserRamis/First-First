using System;

namespace HOM
{
    class SeaGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"{name} играет море");
        }
    }
}