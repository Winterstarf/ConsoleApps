using System;
using ConsoleApp08;

namespace ConsoleApp09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = MatrixMethods.MatrixInput(n, n);
            Console.WriteLine("Оригинальная матрица");
            MatrixMethods.ShowMatrix(matrix);
            Console.WriteLine($"След матрицы: {MatrixMethods.MatrixTrack(matrix)}");
            Console.WriteLine("Матрица, чётные строки которой поделены на след");
            MatrixMethods.ShowMatrix(MatrixMethods.MatrixEvenOddRowsTransform(matrix));
        }
    }
}
