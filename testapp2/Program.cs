using System;

namespace testapp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Числа (через пробел): ");
            string input = Console.ReadLine();
            string[] strings = input.Split(' ');
            int[] ints = Array.ConvertAll(strings, int.Parse);

            Euclid e = new Euclid();
            double res = 0;
            if (ints.Length == 2) res = e.Nod(ints[0], ints[1]);
            else if (ints.Length == 3) res = e.Nod(e.Nod(ints[0], ints[1]), ints[2]);
            Console.WriteLine(res);
        }
    }
    class Euclid
    {
        public double Nod(double a, double b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b) a %= b;
                else b %= a;
            }
            return a + b;
        }
    }
}
