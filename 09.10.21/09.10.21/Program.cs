using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._10._21
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите количество вершин графа n: ");
            if (!uint.TryParse(Console.ReadLine(), out uint n))
            {
                throw new FormatException("Format of n is wrong. String: 12");
            }
            bool[,] matrixG = new bool[n, n];
            Console.WriteLine("Определите связь графов между собой\n0 - отсутсвие связи\n1 - наличие связи");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i; j < n - 1; j++)
                {
                    Console.Write($"Edge[{i}, {j + 1}] = ");
                    ConsoleKey consoleKey = Console.ReadKey().Key;
                    Console.WriteLine();
                    switch (consoleKey)
                    {
                        case ConsoleKey.D0:
                        case ConsoleKey.NumPad0:
                            break;
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            matrixG[i, j + 1] = true;
                            matrixG[j + 1, i] = matrixG[i, j + 1];
                            break;
                        default:
                            Console.WriteLine("Неверный выбор. Попробуй снова: ");
                            j--;
                            break;
                    }
                }
            }
            Console.Write("Введите точку входа a (0 < a <= n): ");
            if (!uint.TryParse(Console.ReadLine(), out uint start) || start > n || start < 0)
            {
                throw new FormatException("Format of start is wrong. String: 99");
            }
            Console.Write("Введите точку выхода b (0 < b <= n b != a): ");
            if (!uint.TryParse(Console.ReadLine(), out uint end) || end > n || end < 0 || end == start)
            {
                throw new FormatException("Format of end is wrong. String: 104");
            }
            if (BFS(out List<uint> path, matrixG, start, end))
            {
                Console.WriteLine("Путь от А до B: ");
                foreach (var item in path)
                {
                    Console.Write(item + " ");
                }
            }
            else
            {
                Console.WriteLine("Достигнуть точки B из A невозможно....");
            }
        }
        static List<int> QSort(List<int> order, bool descendingSort = false)
        {
            if (order.Count <= 1)
            {
                return order;
            }
            List<int> right = new List<int>();
            List<int> center = new List<int>();
            List<int> left = new List<int>();
            for (int i = 0; i < order.Count; i++)
            {
                if (!descendingSort)
                {
                    if (order[i] < order[0])
                    {
                        left.Add(order[i]);
                    }
                    else if (order[i] > order[0])
                    {
                        right.Add(order[i]);
                    }
                    else
                    {
                        center.Add(order[i]);
                    }
                }
                else
                {
                    if (order[i] > order[0])
                    {
                        left.Add(order[i]);
                    }
                    else if (order[i] < order[0])
                    {
                        right.Add(order[i]);
                    }
                    else
                    {
                        center.Add(order[i]);
                    }
                }

            }
            left = QSort(left, descendingSort);
            left.AddRange(center);
            left.AddRange(QSort(right, descendingSort));

            return left;
        }
        static bool BFS(out List<uint> path, bool[,] matrG, uint start, uint end)
        {
            List<uint> visited = new List<uint>() { start };
            List<uint> explore = new List<uint>() { start };
            path = new List<uint>();
            while (explore.Count != 0)
            {
                uint vertex = explore[0];
                explore.RemoveAt(0);
                path.Add(vertex);
                for (uint i = 0; i < matrG.GetLength(1); i++)
                {
                    if (!visited.Contains(i))
                    {
                        if (matrG[vertex, i])
                        {
                            explore.Add(i);
                            visited.Add(i);
                            if (i == end)
                            {
                                path.Add(end);
                                return true;
                            }
                        }
                    }
                }

            }
            path.Clear();
            return false;
        }
        static bool DFS(out List<uint> path, bool[,] matrG, uint start, uint end)
        {
            List<uint> visited = new List<uint>() { start };
            List<uint> explore = new List<uint>() { start };
            path = new List<uint>();
            while (explore.Count != 0)
            {
                uint vertex = explore[explore.Count - 1];
                explore.RemoveAt(explore.Count - 1);
                path.Add(vertex);
                for (uint i = 0; i < matrG.GetLength(1); i++)
                {
                    if (!visited.Contains(i))
                    {
                        if (matrG[vertex, i])
                        {
                            explore.Add(i);
                            visited.Add(i);
                            if (i == end)
                            {
                                path.Add(end);
                                return true;
                            }
                        }
                    }
                }

            }
            path.Clear();
            return false;










        }


        static int Fact(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n >= 1)
            {
                return Fact(n - 1) * n;
            }
            else
            {
                return 0;
            }
        }









    }
}
