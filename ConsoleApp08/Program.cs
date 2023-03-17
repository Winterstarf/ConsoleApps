using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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
            MatrixMinMax(CustomMatrix(n, m));
        }
        static int[,] CustomMatrix(int n, int m)
        {
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите элементы {i+1}-й строки:");
                for (int j = 0; j < m; j++) matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            return matrix;
        }
        static void MatrixMinMax(int[,] matrix)
        {
            int min, max, n = matrix.GetUpperBound(0) + 1, m = matrix.GetLength(1), temp = 0;
            for (int i = 0; i < n; i++)
            {
                min = matrix[i, 0];
                max = matrix[i, 0];
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == min && matrix[i, j] == max) temp++;
                    if (matrix[i, j] < min) min = matrix[i, j];
                    if (matrix[i, j] > max) max = matrix[i, j];
                }
                if (temp == m)
                {
                    Console.WriteLine($"В строке {i + 1} числа одинаковые");
                    temp = 0;
                }
                else if (temp != m)
                {
                    Console.WriteLine($"Мин. в строке {i + 1} = {min}, макс. = {max}");
                    temp = 0;
                }
            }
        }
    }
}
