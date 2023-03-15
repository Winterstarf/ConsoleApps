using System;

namespace ConsoleApp08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int m = Convert.ToInt32(Console.ReadLine());
            CustomMatrix(n, m);
        }
        static void CustomMatrix(int n, int m)
        {
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите элементы {i+1}-й строки:");
                for (int j = 0; j < m; j++) matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            MatrixSorter(matrix, n, m);

        }
        static void MatrixSorter(int[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                int min = matrix[i, 0];
                int max = matrix[i, 0];
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
                Console.WriteLine($"Min {i+1}: {min}");
                Console.WriteLine($"Маx {i+1}: {max}");
            }
        }
    }
}
