using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*номер 4*/
            Console.WriteLine(MyMethods.SummaRjada());
        }
    }
    public class MyMethods
    {
        public static double SummaRjada()
        {
            double sum = 0;
            for (double i = 1; i <= 30; i += 0.5) sum += i;
            return sum;
        }
    }
}
