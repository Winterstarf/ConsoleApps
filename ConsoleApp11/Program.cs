using System;
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
                    Console.Write("N: ");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out int n) || string.IsNullOrEmpty(input) || n <= 0) throw new Exception("введено пустое или отрицательное число");
                    
                    int[,] matrix = MyMethods.MatrixInput(n, n);
                    Console.WriteLine("Оригинальная матрица: ");
                    MyMethods.ShowMatrix(matrix);

                    int[,] binaryMatrix = MyMethods.BinaryMatrix(matrix);
                    Console.WriteLine("Матрица с нулями и единицами: ");
                    MyMethods.ShowMatrix(binaryMatrix);

                    Console.WriteLine("Матрица с эл. под главной диагональю: ");
                    MyMethods.ShowUnderMainDiagonal(binaryMatrix);

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
    public class MyMethods : MatrixMethods
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
