using System;
using System.Diagnostics;




namespace Tumakov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("######Выберите дейтствия! Виды сортировок:#####\nМетод пузырьком-1\nМетод сортировки слиянием-2\nМетод сортировки вставками-3\nСортировка методом бинарной вставки-4");
            int n = Convert.ToInt32(Console.ReadLine());
            Stopwatch stopwatch = new Stopwatch();
            switch (n)
            {
                case 1:
                    stopwatch.Start();
                    int[] array = { 5, 3, 4, 9, 7, 2, 1, 8, 6 };
                    BubbleSort(array);
                    foreach (int e in array)
                        Console.WriteLine(e);
                    stopwatch.Stop();
                    Console.WriteLine("Время выполнения работы в миллисекундах: " + stopwatch.ElapsedTicks);
                    break;

                case 2:
                    stopwatch.Start();
                    int[] arrayy = { 3, 2, 5, 7, 8, 1, 9 };
                    MergeSort(arrayy);
                    foreach (var e in arrayy)
                        Console.WriteLine(e);
                    stopwatch.Stop();
                    Console.WriteLine("Время выполнения работы в миллисекундах: " + stopwatch.ElapsedTicks);
                    break;

                case 3:
                    stopwatch.Start();
                    Console.WriteLine("Сортировка вставками");
                    Console.Write("Введите элементы массива: ");
                    var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
                    var aray = new int[parts.Length];
                    for (int i = 0; i < parts.Length; i++)
                    {
                        aray[i] = Convert.ToInt32(parts[i]);
                    }

                    Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", InsertionSort(aray)));

                    stopwatch.Stop();
                    Console.WriteLine("Время выполнения работы в миллисекундах: " + stopwatch.ElapsedTicks);
                    break;

                case 4:
                    stopwatch.Start();
                    // Считываем размер массива
                    
                    Console.Write("Введите кол-во элементов в массиве ");
                    int size;
                    size = Convert.ToInt32(Console.ReadLine());
                    
                    //считываем строку
                    string str = Console.ReadLine();
                    //разбиваем по пробелам
                    string[] mas = str.Split(' ');
                    int[] a = new int[size];
                    for (int i = 0; i < size; i++)
                    {
                        a[i] = int.Parse(mas[i]);
                    }

                    quickSort(a, 0, size - 1);

                    // Выводим отсортированный массив
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write(a[i]);
                        Console.Write(' ');
                    }
                    stopwatch.Stop();
                    Console.WriteLine("Время выполнения работы в миллисекундах: " + stopwatch.ElapsedTicks);
                    break;
            }
                Console.ReadKey();
        }


        static public void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        int t = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = t;
                    }
        }

        static int[] temporaryArray;

        static void Merge(int[] array, int start, int middle, int end)
        {
            var leftPtr = start;
            var rightPtr = middle + 1;
            var length = end - start + 1;
            for (int i = 0; i < length; i++)
            {
                if (rightPtr > end || (leftPtr <= middle && array[leftPtr] < array[rightPtr]))
                {
                    temporaryArray[i] = array[leftPtr];
                    leftPtr++;
                }
                else
                {
                    temporaryArray[i] = array[rightPtr];
                    rightPtr++;
                }
            }
            for (int i = 0; i < length; i++)
                array[i + start] = temporaryArray[i];
        }

        static void MergeSort(int[] array, int start, int end)
        {
            if (start == end) return;
            var middle = (start + end) / 2;
            MergeSort(array, start, middle);
            MergeSort(array, middle + 1, end);
            Merge(array, start, middle, end);

        }

        static void MergeSort(int[] array)
        {
            temporaryArray = new int[array.Length];
            MergeSort(array, 0, array.Length - 1);
        }

        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        static int[] InsertionSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }

                array[j] = key;
            }

            return array;
        }

        static void quickSort(int[] a, int l, int r)
        {
            int temp;
            int x = a[l + (r - l) / 2];
            //запись эквивалентна (l+r)/2, 
            //но не вызввает переполнения на больших данных
            int i = l;
            int j = r;
            //код в while обычно выносят в процедуру particle
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r)
                quickSort(a, i, r);

            if (l < j)
                quickSort(a, l, j);
        }



    }
}
