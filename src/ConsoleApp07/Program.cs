using System;

namespace ConsoleApp07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Произведение A: {Sequence.SeqProdA(n)}");
            Console.WriteLine($"Произведение B: {Sequence.SeqProdB(n)}");
            Console.WriteLine($"Дв. факториал от {n}: {Sequence.DoubleFactorial(n)}");
        }
    }
    class Sequence
    {
        public static double SeqProdA(int n)
        {
            double prod = 1;
            for (int i = 1; i <= n; i++) prod *= 1.0 + Math.Pow(1.0 / 2.0, 2 * i);
            return prod;
        }
        public static double SeqProdB(int n)
        {
            double prod = 1;
            for (int i = 1; i <= n; i++) prod *= Math.Cos(Math.PI / Math.Pow(2, i + 1));
            return prod;
        }
        public static int DoubleFactorial(int n)
        {
            if (n <= 0) return 1;
            return n * DoubleFactorial(n - 2); //напр. n = 7, возвращает 7*5*3*2*1 = 105
        }
    }
}
