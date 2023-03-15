using System;

namespace ConsoleApp07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Сформировать квадратную матрицу у которй на главной диагонале единицы, а все остальные нули*/
            Console.Write("N: ");
            SquareMatrix(Convert.ToInt32(Console.ReadLine()));
        }
        static void SquareMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int count = 0;
            int m = n - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = 5;
                        count += matrix[i, j];
                    }
                    else if (j == n - i - 1) matrix[i, j] = 1;
                    else matrix[i, j] = 0;
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма элементов гл. диагонали: {count}");
        }
    }
}
