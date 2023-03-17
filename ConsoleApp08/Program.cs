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
            int[,] matrix = MatrixMethods.MatrixInput(n, m);
            Console.WriteLine("Оригинальная матрица");
            MatrixMethods.ShowMatrix(matrix);
            MatrixMethods.MatrixMinMax(matrix);
            MatrixMethods.ShowSortedMatrix(matrix);
            MatrixMethods.TransponedMatrix(matrix);
        }
    }
    public class MatrixMethods
    {
        public static int[,] MatrixInput(int n, int m)
        {
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите элементы {i + 1}-й строки:");
                for (int j = 0; j < m; j++) matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            return matrix;
        }
        public static void MatrixMinMax(int[,] matrix)
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
        public static void ShowMatrix(int[,] matrix)
        {
            int n = matrix.GetUpperBound(0) + 1, m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++) Console.Write($"{matrix[i, j]}\t");
                Console.WriteLine();
            }
        }
        public static void ShowSortedMatrix(int[,] matrix)
        {
            int n = matrix.GetUpperBound(0) + 1, m = matrix.GetLength(1);
            List<int> sorted = new List<int>(m);
            Console.WriteLine("Отсортированная матрица");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++) sorted.Add(matrix[i, j]);
                sorted.Sort();
                for (int j = 0; j < m; j++) Console.Write($"{sorted[j]}\t");
                Console.WriteLine();
                sorted.Clear();
            }
        }
        public static void TransponedMatrix(int[,] matrix)
        {
            int n = matrix.GetUpperBound(0) + 1, m = matrix.GetLength(1);
            Console.WriteLine("Транспонированная матрица (оригинальной)");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++) Console.Write($"{matrix[j, i]}\t");
                Console.WriteLine();
            }
        }
        public static int MatrixTrack(int[,] matrix)
        {
            int n = matrix.GetUpperBound(0) + 1, m = matrix.GetLength(1), tracksum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) tracksum += matrix[i, j];//гл. диагональ
                    else if (j == n - i - 1) tracksum = matrix[i, j]; //поб. диагональ
                }
            }
            return tracksum;
        }
        public static int[,] MatrixEvenOddRowsTransform(int[,] matrix)
        {
            int n = matrix.GetUpperBound(0) + 1, m = matrix.GetLength(1);
            int[,] transformedMatrix = new int[n, m];
            int track = MatrixTrack(matrix);
            if (track == 0) track = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; i < n; i++)
                {
                    if (matrix[i, j] % 2 == 0) transformedMatrix[i, j] = matrix[i, j] / track;
                    else transformedMatrix[i, j] = matrix[i, j];
                }
            }
            return transformedMatrix;
        }
    }
}
