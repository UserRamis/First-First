using System;

namespace HOM
{
    class MyGame1 : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"name играет в cвою игру");
        }
    }
}