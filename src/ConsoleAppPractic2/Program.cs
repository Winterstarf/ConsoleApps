using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x0= ");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("xk= ");
            double xk = Convert.ToDouble(Console.ReadLine());
            Console.Write("dx= ");
            double dx = Convert.ToDouble(Console.ReadLine());
            Console.Write("a= ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            double b = Convert.ToDouble(Console.ReadLine());

            double x = x0;

            while (x <= (xk + dx / 2))
            {
                double y = Math.Pow(10, -1) * a * Math.Pow(x, 3) * Math.Tan(a - b * x);
                Console.WriteLine($"x={x}, y={y}");
                x += dx;
            }

            Console.ReadKey();
        }
    }
}
