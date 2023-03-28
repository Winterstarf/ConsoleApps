using System;
using System.Collections.Generic;

namespace ConsoleApp06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Последовательность действительных чисел, существуют только положительные и отрицательные числа. 
            Вычислите произведение положительных и отрицательных членов последовательности,
            сравнить полученных величины и указать произведение по модулю больше.*/
            Console.Write("N: ");
            Console.WriteLine($"Большее произведение: {SequenceEvaluator(Convert.ToInt32(Console.ReadLine()))}");
        }
        static double SequenceEvaluator(int n)
        {
            while (true)
            {
                try
                {
                    double prod1 = 1, prod2 = 1; // +, -
                    for (int i = 0; i < n; i++) 
                    {
                        double num = Convert.ToDouble(Console.ReadLine());
                        if (num == 0) throw new Exception("в последовательности запрещен '0', запишите числа заново.");
                        else if (num > 0) prod1 *= num;
                        else prod2 *= num;
                    }
                    if (Math.Abs(prod1) < Math.Abs(prod2)) return Math.Abs(prod2);
                    else return Math.Abs(prod1);
                }
                catch (Exception ex) 
                {
                    Console.Clear();
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
    }
}
