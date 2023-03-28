using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*номер 3*/
            Console.Write("x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Результат при x={x}: {MyMethods.SuperFunc(x)}");
        }
    }
    public class MyMethods
    {
        public static double SuperFunc(double x)
        {
            if (x < 0) return Math.Sin(Math.Pow(x, 2)) + 2 * x;
            else if (x >= 0) return Math.Sqrt(x) + Math.Sqrt(Math.Pow(x, 2) + 1);
            else return Math.Cos(x);
        }
    }
}
