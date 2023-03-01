using System;

﻿namespace ConsoleApp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестирование класса Triangle");
            Triangle.Input();
            if (!Triangle.IsTriangle()) Console.WriteLine("Не треугольник");
            else if (Triangle.IsTriangle()) Console.WriteLine($"Площадь треугольника = {Triangle.Geron()}");
        }
    }
    static class Triangle
    {
        public static double a, b, c;
        public static void Input()
        {
            Console.Write("A = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("B = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("C = ");
            c = double.Parse(Console.ReadLine());
        }
        public static bool IsTriangle()
        {
            if (a + b > c && a + c > b && b + c > a) return true;
            return false;
        }
        public static double Geron()
        {
            double s = 0;
            double p = (a + b + c) / 2;
            if (IsTriangle()) s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
    }
}
