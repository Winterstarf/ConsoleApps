using System;
using ConsoleApp05;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("N: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.Write("А или Б: ");
                string method = Console.ReadLine();
                double res;

                if (method == "А" || method == "A" || method == "1") res = Sequence.SeqSumA(n);
                else if (method == "Б" || method == "B" || method == "2") res = Sequence.SeqSumB(n);
                else throw new Exception("несуществующий метод");
                Console.WriteLine($"Сумма ряда: {res}");
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
    class Sequence
    {
        public static double SeqSumA(int n)
        {
            double sum = 0;
            for (int i = 1; i < n; i++) sum += (Math.Pow(10, i)) / (ConsoleApp05.MyMethods.Factorial(i));
            return sum;
        }
        public static double SeqSumB(int n)
        {
            double sum = 0;
            for (int i = 1; i < n; i++) sum += (1) / ((3 * i - 2) * (3 * i + 1));
            return sum;
        }
    }
}
