using System;

namespace ConsoleApp06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("x: ");
                string input = Console.ReadLine();
                if (!double.TryParse(input, out double x) || Math.Abs(x) >= 1 || string.IsNullOrWhiteSpace(input)) throw new Exception("x больше или равен 1 или введен пустой символ");

                Console.WriteLine($"Сумма ряда при x={x}: {Sequence.Finder(x)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
    class Sequence
    {
        public static double Finder(double x)
        {
            const int border = 100;
            double seq = 0;

            for (int i = 0; i < border; i++) seq += (i + 1) * Math.Pow(x, i);
            
            return seq;
        }
    }
}   
