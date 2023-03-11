using System;

namespace ConsoleApp04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Дан массив действительных чисел размерности N (пользователем вводится с клавиатуры и количество членнов последовательности, 
            и сами члены последовательности). Определить, сколько в нем отрицательных, положительных и нулевых элементов.*/
            Console.Write("N: ");
            ArraySorter(Convert.ToInt32(Console.ReadLine()));
        }   
        static void ArraySorter(int n)
        {
            double[] nums = new double[n];
            int cnt1 = 0, cnt2 = 0, cnt3 = 0; //-,+,0
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
                if (nums[i] < 0) cnt1++;
                else if (nums[i] > 0) cnt2++;
                else cnt3++;
            }
            Console.WriteLine($"Positives: {cnt2}, Negatives: {cnt1}, Zeroes {cnt3}");
        }
    }
}
