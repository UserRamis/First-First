using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;
namespace Dolg
{
    class Program
    {
        private const string PathToListEmployees = @"..\..\4.txt";
        static List<string> listMates = new List<string>();
        private const string PathToListMatesEmployees = @"..\..\4.1.txt";
        private const string PathToListTablesForEmployees = @"..\..\4.2.txt";
        private const string PathToListHospitals = @"..\..\5.txt";
        enum Disease : byte
        {
            Оспа = 1,
            Грипп,
            Чахотка,
            Covid19,
            Артрит,
            Сифилис,
            Гепатит,
            Лихорадка
        }
        private const string PathToDirWithImages = "C:\\Users\\user9\\source\\repos\\16.10.21\\Images";
        struct Table
        {
            public string colour;
            public byte number;
            public List<Employee> persons;
        }
        struct Employee
        {
            public string name;
            public string position;
            public byte impudence;
            public bool stupidity;
            
        }

        struct Granny
        {
            public string name;
            public byte age;
            public List<Disease> diseases;
            public string medicine;
        }
        struct Hospital
        {
            public string name;
            public List<Disease> treatment;
            public List<Granny> patient;
            public ushort capacity;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Task 2");
            DirectoryInfo dirImage = new DirectoryInfo(PathToDirWithImages);
            List<FileInfo> imageList = new List<FileInfo>();
            imageList.AddRange(dirImage.GetFiles());
            Console.WriteLine("Картинки: ");
            foreach (var item in imageList)
            {
                Console.WriteLine(item.Name);
            }
            for (byte i = 0; i < imageList.Count; i++)
            {
                Random rnd = new Random();
                int indexRand = rnd.Next(imageList.Count);
                var temp = imageList[i];
                imageList[i] = imageList[indexRand];
                imageList[indexRand] = temp;
            }
            Console.WriteLine("\n\nКартинки после сортировки: ");
            foreach (var item in imageList)
            {
                Console.WriteLine(item.Name);
            }


            Console.WriteLine("Task 4");
            Queue<Employee> queEmployee = new Queue<Employee>();
            Stack<Table> stackTable = new Stack<Table>();
            Stack<Table> containerTable = new Stack<Table>();

            using (StreamReader fileTextRead = new StreamReader(PathToListMatesEmployees))
            {
                string stringfromfile;
                while ((stringfromfile = fileTextRead.ReadLine()) != null)
                {
                    listMates.Add(stringfromfile);
                }
            }
            AddTableFromFile(ref stackTable);
            FillQueueOfEmployees(ref queEmployee);
            while (queEmployee.Count != 0)
            {
                Employee currentEmployee = queEmployee.Dequeue();
                Table tableLastFree;
                
                Table currentTable;
                tableLastFree.colour = "";
                tableLastFree.number = 0;
                tableLastFree.persons = new List<Employee>();
                bool flagFoundPlace = false;
                while (stackTable.Count != 0 && !flagFoundPlace)
                {
                    currentTable = stackTable.Pop();
                    if (currentTable.persons.Count == 0)
                    {
                        currentTable.persons.Add(currentEmployee);
                        stackTable.Push(currentTable);
                        flagFoundPlace = true;
                    }
                    else if (currentEmployee.stupidity)
                    {
                        if (currentTable.persons.Count < 3)
                        {
                            tableLastFree = currentTable;
                            
                            foreach (var item in currentTable.persons.ToArray())
                            {
                                if (!GetExistingConnectionEmployees(item, currentEmployee))
                                {
                                    currentTable.persons.Add(currentEmployee);
                                    stackTable.Push(currentTable);
                                    flagFoundPlace = true;
                                }
                            }
                            if (!flagFoundPlace)
                            {
                                containerTable.Push(currentTable);
                            }
                        }
                        else
                        {
                            containerTable.Push(currentTable);
                        }
                    }
                    else
                    {

                        if (currentEmployee.impudence > 0)
                        {
                            if (currentTable.persons.Count < 4)
                            {
                                tableLastFree = currentTable;
                                foreach (var item in currentTable.persons.ToArray())
                                {
                                    if (GetExistingConnectionEmployees(item, currentEmployee))
                                    {
                                        currentTable.persons.Add(currentEmployee);
                                        stackTable.Push(currentTable);
                                        flagFoundPlace = true;
                                    }
                                }
                                if (!flagFoundPlace)
                                {
                                    containerTable.Push(currentTable);
                                }
                            }
                            else
                            {
                                containerTable.Push(currentTable);
                            }
                        }
                        else
                        {
                            if (currentTable.persons.Count < 3)
                            {
                                tableLastFree = currentTable;
                                foreach (var item in currentTable.persons.ToArray())
                                {
                                    if (GetExistingConnectionEmployees(item, currentEmployee))
                                    {
                                        currentTable.persons.Add(currentEmployee);
                                        stackTable.Push(currentTable);
                                        flagFoundPlace = true;
                                    }
                                }
                                if (!flagFoundPlace)
                                {
                                    containerTable.Push(currentTable);
                                }
                            }
                            else
                            {
                                containerTable.Push(currentTable);
                            }
                        }
                    }
                }
                while (containerTable.Count != 0 && !flagFoundPlace)
                {
                    currentTable = containerTable.Pop();
                    if (tableLastFree.number == currentTable.number)
                    {
                        tableLastFree.persons.Add(currentEmployee);
                        stackTable.Push(currentTable);
                        flagFoundPlace = true;
                    }
                    else
                    {
                        stackTable.Push(currentTable);
                    }
                }
                while (containerTable.Count != 0)
                {
                    stackTable.Push(containerTable.Pop());
                }
                if (!flagFoundPlace)
                {
                    Console.WriteLine($"Сотрудник {currentEmployee.name} {currentEmployee.position}" +
                        " не нашел свободного места!");
                }
            }
            Console.WriteLine("\nСписок столов: ");
            foreach (var item in stackTable)
            {
                Console.WriteLine("\n\nНомер стола - " + item.number);
                Console.WriteLine("Цвет стола - " + item.colour);
                Console.WriteLine($"Количество персон за столом: {item.persons.Count}");
                Console.WriteLine("Персоны за столом: ");
                foreach (var person in item.persons)
                {
                    Console.WriteLine(person.name + " " + person.position);
                }
            }


            Console.WriteLine("Task 5");
            Queue<Granny> visitorsGranny = new Queue<Granny>();
            Stack<Granny> grannyDead = new Stack<Granny>();
            Stack<Hospital> hospitals = new Stack<Hospital>();
            Stack<Hospital> containerHospitals = new Stack<Hospital>();
            using (StreamReader fileTextRead = new StreamReader(PathToListHospitals))
            {
                string stringfromfile;
                int numberString = 1;
                while ((stringfromfile = fileTextRead.ReadLine()) != null)
                {
                    string[] dateHospital = stringfromfile.Split('\\');
                    if (dateHospital.Length != 3)
                    {
                        Console.WriteLine($"Длина {numberString} строки не соответсвует формату");
                    }
                    else
                    {
                        Hospital newHospital;
                        newHospital.name = dateHospital[0];
                        newHospital.treatment = new List<Disease>();
                        for (int i = 0; i < dateHospital[1].Length; i++)
                        {
                            
                            newHospital.treatment.Add((Disease)(byte)dateHospital[1][i]);
                        }
                        if (!ushort.TryParse(dateHospital[2], out newHospital.capacity))
                        {
                            throw new FormatException($"Ошибка вместимости больницы строка №{numberString} в файле списка больниц");
                        }
                        newHospital.patient = new List<Granny>();
                        hospitals.Push(newHospital);
                    }
                    numberString++;
                }
            }
            Console.Write("Введите количество бабуль: ");
            if (!ushort.TryParse(Console.ReadLine(), out ushort numGranny))
            {
                throw new FormatException("Wrong format numGranny (DoTask5)");
            }
            for (int i = 1; i < numGranny + 1; i++)
            {
                Console.WriteLine($"Бабуля №{i}");
                Granny newGranny;
                Console.Write("Введите имя: ");
                newGranny.name = Console.ReadLine();
                Console.Write("Введите возраст: ");
                if (!byte.TryParse(Console.ReadLine(), out newGranny.age) || newGranny.age < 40)
                {
                    Console.WriteLine("Возраст имеет неправильный формат. Попробуй снова");
                    i--;
                    continue;
                }
                newGranny.diseases = new List<Disease>();
                Console.WriteLine("Список болезней:\n(1)Оспа (2)Грипп (3)Чахотка" +
                    " (4)Covid19\n(5)Артрит (6)Сифилис (7)Гепатит (8)Лихорадка (Другое)\"Больше\"Нет болезней");
                bool flagExistingDesies = true;
                while (flagExistingDesies)
                {
                    Console.Write("Введите болезень: ");
                    if (!byte.TryParse(Console.ReadLine(), out byte choise) || choise == 0 || choise > 8)
                    {
                        flagExistingDesies = false;
                    }
                    else
                    {
                        if (newGranny.diseases.Contains((Disease)choise))
                        {
                            Console.WriteLine("У бабушки уже есть такая болезнь!");
                        }
                        else
                        {
                            newGranny.diseases.Add((Disease)choise);
                        }
                    }
                }
                Console.Write("Введите лекартсво: ");
                newGranny.medicine = Console.ReadLine();
                visitorsGranny.Enqueue(newGranny);
            }
            while (visitorsGranny.Count != 0)
            {
                Granny grannyCurrent = visitorsGranny.Dequeue();
                Console.WriteLine("Имя бабули: " + grannyCurrent.name + "\tЛекарство бабули: " + grannyCurrent.medicine
                    + "\tВозраст бабули: " + grannyCurrent.age);
                Console.WriteLine("Болезни бабушки: ");
                foreach (var item in grannyCurrent.diseases)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                bool flagFound = true;
                while (hospitals.Count != 0 && flagFound)
                {
                   
                    Hospital hospitalCurrent = hospitals.Pop();
                    if (hospitalCurrent.capacity != 0)
                    {
                        if (grannyCurrent.diseases.Count == 0)
                        {
                            hospitalCurrent.patient.Add(grannyCurrent);
                            hospitalCurrent.capacity--;
                            hospitals.Push(hospitalCurrent);
                            flagFound = false;
                        }
                        else if (KnowFateGranny(grannyCurrent.diseases, hospitalCurrent.treatment))
                        {
                            hospitalCurrent.patient.Add(grannyCurrent);
                            hospitalCurrent.capacity--;
                            hospitals.Push(hospitalCurrent);
                            flagFound = false;
                        }
                        else
                        {
                            containerHospitals.Push(hospitalCurrent);
                        }
                    }
                    else
                    {
                        containerHospitals.Push(hospitalCurrent);
                    }
                }
                while (containerHospitals.Count != 0)
                {
                    hospitals.Push(containerHospitals.Pop());
                }
                if (flagFound)
                {
                    grannyDead.Push(grannyCurrent);
                }
            }
            Console.WriteLine("\n\nСписок Больниц");
            foreach (var item in hospitals)
            {
                Console.WriteLine($"\n\nНазвание больницы: {item.name}");
                Console.WriteLine($"В больнице лечат: ");
                foreach (var treatment in item.treatment)
                {
                    Console.WriteLine(treatment + "\t");
                }
                Console.WriteLine($"В больнице лечатcя: ");
                foreach (var patient in item.patient)
                {
                    Console.WriteLine(patient.name + " " + patient.age + "лет(год)");
                }
                Console.WriteLine($"В больнице осталось свободных мест: {item.capacity}");
            }
        






        Console.ReadKey();





        }


        static bool GetExistingConnectionEmployees(Employee employee1, Employee employee2)
        {
            foreach (var item in listMates)
            {
                string strNameEmp1 = employee1.name + " " + employee1.position;
                string strNameEmp2 = employee2.name + " " + employee2.position;
                if (item.Contains(strNameEmp1) && item.Contains(strNameEmp2))
                {
                    return true;
                }
            }
            return false;
        }


        static void FillQueueOfEmployees(ref Queue<Employee> queueEmployee)
        {
            List<Employee> listEmployees = new List<Employee>();
            using (StreamReader fileTextRead = new StreamReader(PathToListEmployees))
            {
                string stringfromfile;
                int numberString = 1;
                while ((stringfromfile = fileTextRead.ReadLine()) != null)
                {
                    string[] dateEmployee = stringfromfile.Split();
                    if (dateEmployee.Length != 4)
                    {
                        Console.WriteLine($"Длина  строки {numberString} не соответсвует формату. Работники");
                    }
                    else
                    {
                        Employee newEmployee;
                        newEmployee.name = dateEmployee[0];
                        newEmployee.position = dateEmployee[1];
                        if (!byte.TryParse(dateEmployee[2], out newEmployee.impudence) || newEmployee.impudence > 10)
                        {
                            throw new FormatException($"Нагласть сотрудника строки {numberString} из файла не соответсвует формату");
                        }
                        newEmployee.stupidity = dateEmployee[3].ToLower().Equals("тупой");
                        if (newEmployee.stupidity)
                        {
                            if (newEmployee.impudence >= listEmployees.Count)
                            {
                                listEmployees.Insert(0, newEmployee);
                            }
                            else if (newEmployee.impudence == 0)
                            {
                                listEmployees.Insert(listEmployees.Count - 1, newEmployee);
                            }
                            else
                            {
                                listEmployees.Insert(listEmployees.Count - newEmployee.impudence, newEmployee);
                            }
                        }
                        else
                        {
                            listEmployees.Add(newEmployee);
                        }
                    }
                    numberString++;
                }
            }
            foreach (var item in listEmployees)
            {
                queueEmployee.Enqueue(item);
            }
        }

        static void AddTableFromFile(ref Stack<Table> tables)
        {
            using (StreamReader fileTextRead = new StreamReader(PathToListTablesForEmployees))
            {
                string stringfromfile;
                int numberString = 1;
                while ((stringfromfile = fileTextRead.ReadLine()) != null)
                {
                    string[] dateTable = stringfromfile.Split();
                    if (dateTable.Length != 2)
                    {
                        Console.WriteLine($"Длина  строки {numberString} не соответсвует формату. Столы");
                    }
                    else
                    {
                        Table newTable;
                        newTable.persons = new List<Employee>();
                        newTable.colour = dateTable[0];
                        if (!byte.TryParse(dateTable[1], out newTable.number) || newTable.number == 0)
                        {
                            throw new FormatException($"Номер стола из строки  №{numberString} не соответсвует формату");
                        }
                        tables.Push(newTable);
                    }
                    numberString++;
                }
            }
        }

        static bool KnowFateGranny(List<Disease> diseasesGranny, List<Disease> treatmentsHospital)
        {
            byte NumberCurableDisease = 0;
            foreach (var item in diseasesGranny)
            {
                if (treatmentsHospital.Contains(item))
                {
                    NumberCurableDisease++;
                }
            }
            return (double)NumberCurableDisease / diseasesGranny.Count() >= 0.5;
        }
    }
}
