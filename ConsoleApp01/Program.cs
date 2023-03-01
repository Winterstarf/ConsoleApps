using System;
using System.Collections.Generic;

namespace ConsoleApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("N: ");
                    string str = Console.ReadLine();
                    if (string.IsNullOrEmpty(str)) throw new FormatException("введено null.");
                    if (str.Contains(',')) throw new FormatException("используйте точку вместо запятой.");
                    if (!int.TryParse(str, out int n) || string.IsNullOrWhiteSpace(str) || n <= 0) throw new FormatException("пустой символ, буква или нецелое число, либо число не натуральное.");
                    Console.WriteLine("Марсены: " + string.Join(", ", Marsen(n)));
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        static List<int> Marsen(int n)
        {
            List<int> primes = new List<int>();
            for (int i = 1; i < n; i++)
            {
                bool prime = true;
                for (int j = 1; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime) primes.Add(i);
            }
            List<int> marsens = new List<int>();
            foreach (int i in primes)
            {
                int marsen = (int)Math.Pow(2, i) - 1;
                if (primes.Contains(marsen)) marsens.Add(marsen);
            }
            return marsens;
        }
    }
}

