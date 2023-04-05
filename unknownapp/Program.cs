using System;
using System.Collections.Generic;

namespace unknownapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fN = "Гжегож", lN = "Бженчищчикевич", c = "Польша"; //написать метод с параметрами для вычисления суммы произведения и частного x и y, input from keyboard
            int a = 20;
            MyMethods.MyMethod(); //дефолтные значения
            MyMethods.MyMethod(fN, lN, a, c); //переданы все значения
            MyMethods.MyMethod(fN); //передано одно значение
            MyMethods.MyMethod(age: a, firstN: fN, country: c, lastN: lN); //все значения по своему порядку

            Console.ReadKey();
            Console.Clear();

            MyMethods.MyInput(out double x, out double y);
            MyMethods.MyDiv(x, y, out string divres);
            Console.WriteLine($"sum={MyMethods.MySum(x, y)}, prod={MyMethods.MyProd(x, y)}, div={divres}");
        }
        class MyMethods
        {
            public static void MyMethod(string firstN = "Анджей", string lastN = "Якувиц", int age = 31, string country = "Чехия")
            {
                Console.WriteLine($"{firstN} {lastN} {age} {country}");
            }
            public static void MyInput(out double x, out double y)
            {
                Console.Write("X: ");
                string inputx = Console.ReadLine();
                if (inputx.Contains('.')) inputx = inputx.Replace('.', ',');
                x = Convert.ToDouble(inputx);

                Console.Write("Y: ");
                string inputy = Console.ReadLine();
                if (inputy.Contains('.')) inputy = inputy.Replace('.', ',');
                y = Convert.ToDouble(inputy);
            }
            public static double MySum(double x, double y) => x + y;
            public static double MyProd(double x, double y) => x * y;
            public static void MyDiv(double x, double y, out string res)
            {
                res = x == 0 || y == 0 ? "на 0 незя" : Convert.ToString(x / y);
            }
        }
    }
}
