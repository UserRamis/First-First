using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1.1");
            double shet, procent, shet1, shet2, shet3, srok;
            Console.Write("Введите текущий банковский счет(тыс) ");
            shet = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите под какой процент были вложены средства(%) ");
            procent = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите под какой срок были вложены деньги(лет) ");
            srok = Convert.ToDouble(Console.ReadLine());
            shet1 = shet * (procent / 100);
            shet2 = shet1 * srok;
            shet3 = shet1 + shet2 * 10;
            Console.WriteLine("Если на " + srok + " лет были вложены,то сберегательный счет будет составлять " + shet3 + " тыс");


            Console.WriteLine("Task1.2");
            Console.Write("Введите номер счета ");
            int nomer = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите тип банковского счета ");
            string tip = Convert.ToString(Console.ReadLine());
            Console.Write("Введите баланс банковского счета(тыс) ");
            int balans = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Номер счета: " + nomer + "\nТип банковского счета: " + tip + "\nБаланс банковского счета: " + balans);


            Console.WriteLine("Task1.3");
            Console.Write("Введите ВУЗ ");
            string vyz1 = Convert.ToString(Console.ReadLine());
            Console.Write("Введите имя работника ");
            string name1 = Convert.ToString(Console.ReadLine());
            Console.Write("Введите ВУЗ ");
            string vyz2 = Convert.ToString(Console.ReadLine());
            Console.Write("Введите имя работника ");
            string name2 = Convert.ToString(Console.ReadLine());
            Console.Write("Введите ВУЗ ");
            string vyz3 = Convert.ToString(Console.ReadLine());
            Console.Write("Введите имя работника ");
            string name3 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(vyz1 + " " + name1 + "\n"+vyz2 + " " + name2 + "\n"+ vyz3 + " " + name3);

































































            Console.ReadKey();

        }
    }
}
