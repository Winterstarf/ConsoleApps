using System;
using System.Collections.Generic;
using ConsoleApp08;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    /*дана квадратная матрица (элементы вводит юзер), записать вместо отриц. эл. нули, заместо положит. единицы,
                    вывести на печать элементы под гл. диагональю*/
                    Console.Write("N (exit чтобы закрыть): ");
                    string input = Console.ReadLine();
                    if (input == "exit") System.Environment.Exit(0);
                    if (!int.TryParse(input, out int n) || string.IsNullOrWhiteSpace(input) || n <= 0) throw new Exception("введено пустое или отрицательное число");
                    
                    int[,] matrix = MatrixMethods.MatrixInput(n, n);
                    Console.WriteLine("Оригинальная матрица: ");
                    MatrixMethods.ShowMatrix(matrix);

                    int[,] binaryMatrix = MatrixMethods.BinaryMatrix(matrix);
                    Console.WriteLine("Матрица с нулями и единицами: ");
                    MatrixMethods.ShowMatrix(binaryMatrix);

                    Console.WriteLine("Матрица с эл. под главной диагональю: ");
                    MatrixMethods.ShowUnderMainDiagonal(binaryMatrix);

                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
    public class MatrixMethods
    {
        public static int[,] BinaryMatrix(int[,] matrix)
        {
            int n = matrix.GetUpperBound(0) + 1, m = matrix.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] <= 0) matrix[i, j] = 0;
                    else if (matrix[i, j] > 0) matrix[i, j] = 1;
                }
            }
            return matrix;
        }
        public static void ShowUnderMainDiagonal(int[,] matrix)
        {
            int n = matrix.GetUpperBound(0) + 1, m = matrix.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i != j && j < i) Console.Write($"{matrix[i, j]}\t");
                    else Console.Write("*\t");
                }
                Console.WriteLine();
            }
        }

    }
}
