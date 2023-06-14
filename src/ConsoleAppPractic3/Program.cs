using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractic3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = Matrix.Input();
            Console.WriteLine("Ориг. матрица: ");
            Matrix.Show(matrix);

            double sum = Matrix.Sum(matrix);
            Console.WriteLine($"Сумма ориг. матрицы {sum}");

            double[,] tmatrix = Matrix.Transform(matrix, sum);
            Console.WriteLine("Изменённая матрица: ");
            Matrix.Show(tmatrix);

            Console.ReadKey();
        }
    }
    class Matrix
    {
        public static double[,] Input()
        {
            Random rnd = new Random();
            double[,] matrix = new double[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 10);
                }
            }
            Console.Clear();
            return matrix;
        }
        public static void Show(double[,] matrix)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        public static double Sum(double[,] matrix)
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; i < 10; i++)
                {
                    if (i == j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
        public static double[,] Transform(double[,] matrix, double sum)
        {
            double[,] tmatrix = new double[10, 10];
            if (sum > 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        tmatrix[i, j] = matrix[i, j] + 13.5;
                    }
                }    
            }
            else if (sum <= 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        tmatrix[i, j] = Math.Pow(matrix[i, j], 2) - 1.5;
                    }
                }
            }
            return tmatrix;
        }
    }
}
