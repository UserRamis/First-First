using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Song
    {
        private string name;
        private string author;
        public string Name
        {
            get { return name; }
        }
        public string Author
        {
            get { return author; }
        }
        public Song(string name, string author)
        {
            this.name = name;
            this.author = author;
        }
        public string Title()
        {
            return name + " " + author;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Song song = obj as Song;
            return (this.name == song.name) && (this.author == song.author);
        }
        public static void SearchSongs(List<Song> songs)
        {
            bool flag = false;
            for (int i = 0; i < songs.Count; i++)
            {
                for (int j = i; j < songs.Count; j++)
                {
                    if (songs[i].Equals(songs[j]))
                    {
                        flag = true;
                        Console.WriteLine("Песня:" +songs[i].author + "-" + songs[i].name);
                    }
                }
            }
            if (!flag)
            {
                Console.WriteLine("Нету одинаковых песен.");
            }
        }
    }
}