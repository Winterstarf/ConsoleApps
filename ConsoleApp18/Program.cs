using System;
using SquareMatrixApp;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("N (exit чтобы закрыть): ");
                string input = Console.ReadLine();
                if (input == "exit") System.Environment.Exit(0);
                if (!int.TryParse(input, out int n) || string.IsNullOrWhiteSpace(input) || n <= 0) throw new Exception("введено пустое или отрицательное число");

                int[,] matrix = MatrixMethods.BinaryMatrix(n);
                Console.WriteLine("Оригинальная матрица: ");
                SquareMatrixApp.MatrixMethods.ShowMatrix(matrix);

                int sum = MatrixMethods.BinaryMatrixSum(matrix, n);
                Console.WriteLine($"Сумма элементов гл. диагонали: {sum}");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
    class MatrixMethods
    {
        public static int[,] BinaryMatrix(int n) //возвращает квадратную матрицу с 1-ми по гл. и поб. диагоналях и 0-ми как остальные элементы
        {
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || j == n - i - 1) matrix[i, j] = 1;
                    else matrix[i, j] = 0;
                }
            }
            
            return matrix;
        }
        public static int BinaryMatrixSum(int[,] matrix, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++) for (int j = 0; j < n; j++) if (i == j) sum += matrix[i, j];
            return sum;
        }
    }
}
