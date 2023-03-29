using System;

namespace ConsoleApp05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*номер 5*/
            Console.Write("x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Cos(x): {MyMethods.MyCos(x)}");
            Console.WriteLine($"Проверка: {Math.Cos(x)}");
        }
    }
    public class MyMethods
    {
        public static double MyCos(double x)
        {
            const int border = 10;
            double sum = 1;
            double term = 1;
            for (int i = 1; i <= border; i++)
            {
                term *= (-1) * x * x / ((2 * i - 1) * 2 * i);
                sum += term * 1;
            }
            return sum;
        }
        public static long Factorial(int x)
        {
            long fact = 1;
            for (int i = 1; i <= x; i++) fact *= i;
            return fact;
        }
    }
}
