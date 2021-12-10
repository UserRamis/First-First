using System;
using System.Linq;

namespace  _12._4
{
    public delegate void DelegatSorted(int kret);
    public class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library();
            library.SortingLibrary(new DelegatSorted(library.Sort), 1);
            library.SortingLibrary(new DelegatSorted(library.Sort), 2);
            library.SortingLibrary(new DelegatSorted(library.Sort), 3);
            Console.ReadKey();
        }
    }
   
    
}