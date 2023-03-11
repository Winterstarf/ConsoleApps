using System;

namespace ConsoleApp05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Дана последовательность чисел, среди которых имеется единственный нуль. Вывести все числа до нуля включительно.*/
            Console.Write("N: ");
            ArrayZeroFinder(Convert.ToInt32(Console.ReadLine()));
        }
        static void ArrayZeroFinder(int n)
        {
            double[] nums = new double[n];
            for (int i = 0; i < nums.Length; i++) nums[i] = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) break;
                Console.WriteLine(nums[i]);
            }
        }
    }
}
