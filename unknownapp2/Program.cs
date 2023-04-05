using System;

namespace unknownapp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("x: ");
                double x = MyMethods.MyInput();

                double res = MyMethods.MyLog(1 + x);
                double restest = Math.Log(1 + x);

                Console.WriteLine($"res={res}\nrestest={restest}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
    class MyMethods
    {
        public static double MyInput() => Convert.ToDouble(Console.ReadLine());
        public static double MyLog(double x)
        {
            const int border = 10;

        }
    }
}
