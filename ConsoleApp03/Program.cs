using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Эпсилон: ");
            MyMethods.Sequence(Convert.ToDouble(Console.ReadLine()));
        }
    }
    public static class MyMethods
    {
        public static void Sequence(double eps)
        {
            List<double> nums = new List<double>();
            int min = 0;
            nums.Add(2);
            for (int i = 1; ; i++)
            {
                nums.Add(2 + (1 / nums[i - 1]));
                if (Math.Abs(nums[i] - nums[i - 1]) < eps)
                {
                    min = i + 1;
                    break;
                }
            }
            Console.WriteLine($"Наименьший номер: {min}\nЭлементы: {string.Join(", ", nums)}");
        }
    }
}
