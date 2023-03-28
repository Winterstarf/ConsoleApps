using System;
using SquareMatrixApp;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("M: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = MatrixMethods.MatrixInput(n, m);
            Console.WriteLine($"Оригинальная матрица: ");
            MatrixMethods.ShowMatrix(matrix);

            Console.WriteLine();
            MatrixMethods.MatrixMinMax(matrix);
        }
    }
}
