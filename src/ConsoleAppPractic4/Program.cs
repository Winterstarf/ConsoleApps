using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractic4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var f = Console.ReadLine();
            int count = f.Count(char.IsPunctuation);
            Console.WriteLine($"Знаков препинания - {count}");
            Console.ReadKey();
        }
    }
}
