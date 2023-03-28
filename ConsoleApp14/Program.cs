using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*номер 5*/
            Console.Write("x: ");
            Console.WriteLine(MyMethods.Factorial(6));
        }
    }
    public class MyMethods
    {
        public static double MyCos(double x)
        {
            const int border = 100;
            double cos = 1;
            for (int i = 0; i < border; i++) cos = (Math.Pow(-1, i) * Math.Pow(x, 2 * i)) / MyMethods.Factorial(2 * i);
            return cos;
        }
        public static double Factorial(int x)
        {
            int fact = 1;
            for (int i = 1; i < x; i++) fact *= i;
            return fact;
        }
    }
}
