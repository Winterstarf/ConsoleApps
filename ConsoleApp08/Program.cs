using System;

namespace ConsoleApp08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*дана матрица nxm, заполняется пользователем, в каждой строке этой матрицы найти мин и макс число*/
            Console.Write("Строки: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Столбцы: ");
            int m = Convert.ToInt32(Console.ReadLine());
            CustomMatrix(n, m);
        }
        static void CustomMatrix(int n, int m)
        {
            int[,] nums = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    nums[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
