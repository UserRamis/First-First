using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _12._4
{
    class Library
    {
        public Book[] books = new Book[]{new Book{Name = "Война и мир", Aut = "Лев Толстой", Publish = "Классика"},
                new Book{Name = "Недоросль", Aut = "Михаил Юрьевич Достоевский", Publish = "Комедия"},
                new Book{Name = "Мастер и Маргарита", Aut = "Михаил Булгаков", Publish = "Роман"},
                new Book{Name = "Евгений Онегин", Aut = "Сергей Пушкин", Publish = "Роман"}};
        public void SortingLibrary(DelegatSorted deleg, int i)
        {
            deleg.Invoke(i);
        }
        public void Sort(int kret)
        {
            if (kret == 1)
            {
                Console.Write("По названию ");
                books = books.OrderBy(e => e.Name).ToArray();
            }
            else if (kret == 2)
            {
                Console.Write("По автору ");
                books = books.OrderBy(e => e.Aut).ToArray();
            }
            else
            {
                Console.Write("По издательству ");
                books = books.OrderBy(e => e.Publish).ToArray();
            }
            Console.WriteLine("отсортированныи массив");
            foreach (var item in books)
            {
                Console.WriteLine("Название - {0}, автор - {1}, издательство - {2}", item.Name, item.Aut, item.Publish);
            }
        }
    }
}
