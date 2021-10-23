using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DZ
{
    abstract class Library
    {
        private const string recipess = @"..\..\recipes.txt";
        
        public string GetString()
        {
            return recipess;
        }
        
        
        
        
        public struct Recipes
        {
            public string name;
            public string meat;
            public string fruit;
            public byte salt;
            public byte water;
            public byte time;
        }
    }
    class PrintList : Library
    {
        public void CreateAndPrintList()
        {
            Dictionary<string, Recipes> recipesDictionary = new Dictionary<string, Recipes>();
            StreamReader fileTextRead = new StreamReader(GetString());
            string stringfromfile; byte numberString = 1;
            while ((stringfromfile = fileTextRead.ReadLine()) != null) //считывание файла построчно пока не кончатся символы
            {
                string[] oneRecipes = stringfromfile.Split();
                Recipes recipesNew; 
                recipesNew.name = oneRecipes[0];
                recipesNew.meat = oneRecipes[1];
                recipesNew.fruit = oneRecipes[2];
                byte.TryParse(oneRecipes[3], out recipesNew.salt);
                byte.TryParse(oneRecipes[4], out recipesNew.water);
                byte.TryParse(oneRecipes[5], out recipesNew.time);



                recipesDictionary.Add(oneRecipes[0] + " " + oneRecipes[1], recipesNew);
                numberString++; //переход на следующую строку
            }
            numberString = 1;
            Console.WriteLine("*****"+"Список рецептов"+"*****");
            foreach (KeyValuePair<string, Recipes> keyValue in recipesDictionary) //печать списка
            {
                Console.Write("\n"+"***"+keyValue.Value.name+"***" + "\n"+"Нужно ли мясо? "+ keyValue.Value.meat+ "\n"+ "Нужны ли фрукты? "+keyValue.Value.fruit+ "\n" +"Сколько грамм соли? "+keyValue.Value.salt+"грамм" + "\n"+ "Сколько мл. воды? "+keyValue.Value.water+"мл"+ "\n"+"Сколько минут жарить/готовить? "+keyValue.Value.time+"минут");
                
            }
        }
    }
    class Recipess : PrintList
    {
        static void Main()
        {
            PrintList recipes = new PrintList();
            recipes.CreateAndPrintList();
            Console.ReadKey();
        }
    }








}
