using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Дана последовательность чисел, среди которых имеется единственный нуль. Вывести все числа до нуля включительно.*/
            Console.Write("N: ");
            Console.WriteLine(string.Join(", ", ArrayZeroFinder(Convert.ToInt32(Console.ReadLine()))));
        }
        static List<double> ArrayZeroFinder(int n)
        {
            List<double> nums = new List<double>();
            for (int i = 0; i < n; i++) nums.Add(Convert.ToDouble(Console.ReadLine()));
            nums.RemoveRange(nums.IndexOf(0) + 1, nums.Count - nums.IndexOf(0));
            return nums;
        }
    }
}
