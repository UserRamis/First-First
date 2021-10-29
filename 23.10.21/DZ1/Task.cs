using System;

namespace ClassWork
{
    class Task
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Destination { get; private set; }
        public Task(string name, string description, string destination)
        {
            Name = name;
            Description = description;
            Destination = destination;
        }
        public static Task CreateTask()
        {
            Console.WriteLine("Введите имя задачи");
            string name = Console.ReadLine();
            Console.WriteLine("Введите описание");
            string description = Console.ReadLine();
            Console.WriteLine("Для кого эта задача?");
            string destination = Console.ReadLine();
            return new Task(name, description, destination);

        }
    }
}
