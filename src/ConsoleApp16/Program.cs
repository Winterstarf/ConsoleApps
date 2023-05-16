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
            try
            {
                Console.Write("N: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int n) || string.IsNullOrWhiteSpace(input) || string.IsNullOrEmpty(input)) throw new Exception("пустой/недопустимый символ или дробное число");
                if (n <= 0) throw new Exception($"число элементов не может быть {n}");
                Console.WriteLine(string.Join(',', ArrayZeroFinder(n)));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static List<double> ArrayZeroFinder(int n)
        {
            List<double> nums = new List<double>();
            List<double> sorted = new List<double>();
            Console.WriteLine("Элементы: ");
            for (int i = 0; i < n; i++) nums.Add(Convert.ToDouble(Console.ReadLine()));
            
            Console.Clear();
            
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == 0) break;
                else sorted.Add(nums[i]);
            }
            return sorted;
        }
    }
}
