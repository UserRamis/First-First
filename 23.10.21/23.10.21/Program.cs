using System;
using System.Collections.Generic;
using System.IO;



namespace HomeWork
{
    class Program
    {
        public static void GetMail(ref string email)
        {
            string[] mail = email.Split('#');
            email = mail[mail.Length - 1];

        }
        public static void DoTask8_1()
        
        {
            string file = "namemail.txt";
            if (File.Exists(file))
            {
                string[] mail = File.ReadAllLines(file);
                for (int i = 0; i < mail.Length; i++)
                {
                    GetMail(ref mail[i]);
                }
                File.WriteAllLines("emails.txt", mail);
            }
            else
            {
                Console.WriteLine("Ошибка !");
            }
        }
        public static void DoTask8_2()
        {
            int SongsCount = 4;
            List<Song> songs = new List<Song>();
            for (int i = 0; i < SongsCount; i++)
            {
                Console.WriteLine("Название песни: ");
                string name = Console.ReadLine();
                Console.WriteLine("Автор песни: ");
                string author = Console.ReadLine();
                songs.Add(new Song(name, author));
            }
            Song.SearchSongs(songs);
        }
        static void Main(string[] args)
        {
            
        }
    }
}