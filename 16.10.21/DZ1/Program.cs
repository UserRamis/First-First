using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    class Program
    {



        static void Main(string[] args)
        {
            home dom = new home();
            Console.Write("Введите номер здания ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту здания в метрах ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите этажность здания ");
            int floor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во квартир ");
            int flats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во подъездов ");
            int pod = Convert.ToInt32(Console.ReadLine());

            dom.number = number;
            dom.height = height;
            dom.floor = floor;
            dom.flats = flats;
            dom.pod = pod;
            dom.Info();

            int q = floor * 4;//высота одного этажа
            int q1 = flats / pod;//кол-во квартир в одном подъезде

            Console.Write("***Введите действие:1-высота одного этажа.2-кол-во квартир в одном подъезде***");
            int n1 = Convert.ToInt32(Console.ReadLine());
            switch (n1)
            {
                case 1:
                    Console.Write("Высота одного этажа будет: " + q);
                    break;
                case 2:
                    Console.Write("Кол-во квартир в одном подъезде " + q1);
                    break;
            }
            Console.WriteLine("Выберите дальнейшее дейтсвие:1-высота одного этажа.2-кол-во квартир в одном подъезде.3-ВЫЙТИ ИЗ ПРИЛОЖЕНИЯ!");
            int n2 = Convert.ToInt32(Console.ReadLine());
            switch (n2)
            {
                case 1:
                    Console.Write("Высота одного этажа будет: " + q);
                    break;
                case 2:
                    Console.Write("Кол-во квартир в одном подъезде " + q1);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;





            }






            Console.ReadKey();
        }
    }

    class home
    {
        public int number;
        public int height;
        public int floor;
        public int flats;
        public int pod;

        public void Info()
        {
            Console.WriteLine($"Номер здания {number} Высота здания {height} Этажность {floor} Кол-во квартир {flats} Кол-во пдъездов {pod} ");
        }



    }








}

