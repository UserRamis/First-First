using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1_2
{



    class Houses
    {
        private int id = 0;
        private static int count = 1;
        public int Set_Id
        {
            get
            {
                return id;
            }
            
            set
            {
                id=count;   
            }

        }
        public int Get_Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }                     
        }
        private uint floor_count = 1;
        private uint Floor;
        public uint Set_Floor_Count
        {
            get
            {
                return floor_count;
            }
                       
            set
            {
                floor_count = Floor;
            }
        }
        public uint Get_Floor_Count
        {
            get
            {
                return floor_count;
            }
            set
            {
                floor_count = value;
            }                              
        }
        private uint height = 1;
        private uint Height;
        public uint Set_Height
        {
            get
            {
                return Height;
            }
                                             
            set
            {
                height = Height;
            }
        }
        public uint Get_Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }             
        }
        private uint flat_count = 1;
        private uint Flat_count;
        public uint Set_Flat_Count
        {
            get
            {
                return Flat_count;
            }
                                   
            set
            {
                flat_count = Flat_count;
            }
        }
        public uint Get_Flat_Count
        {
            get
            {
                return floor_count;
            }
            set
            {
                floor_count = value;
            }
        }
        public uint Flat_Height
        {
           get
           {
                return height / floor_count;
           }               
        }
        public uint Flat_On_Floor
        {
            get
            {
                return floor_count / flat_count;
            }
        }     
    }

    
    class Programm
    {
        static void Main()
        {
            House p1 = new House();
            p1.number = 1;
            p1.floor = 12;
            p1.flat = 13;
            p1.room = 14;

            House p2 = new House();
            p2.number = 12;
            p2.floor = 122;
            p2.flat = 132;
            p2.room = 142;

            
            //создание массива на 10 домов
            int[] House = new int[10];
            //создание индексатора
            House[3]=3;
            int t1 = House[3];
        
        }
    }
}



































