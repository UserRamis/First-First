using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите русскую букву ");
            string bukva = Convert.ToString(Console.ReadLine());
            List<string> alphabet = new List<string> { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            var index = alphabet.IndexOf(bukva);
            if (index != 32)
            {
                var nextSymbol = alphabet[index + 1];
                Console.WriteLine("Следующая буква по алфавиту: " + nextSymbol);
            }
            else
            {
                Console.WriteLine("Тогда следующая буква будет а");
            }
            Console.ReadKey();
        }
    }
}
