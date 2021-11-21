using System;

namespace HOM
{
    class PostmanGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"{name} играет почтальона");
        }
    }
}