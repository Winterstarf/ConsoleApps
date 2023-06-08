using System.Data;

namespace ConsoleAppPractic1
{
    internal class Program
    {
        //Лаба 3, варик 3
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Methods m = new Methods();

                    Console.Write("X: ");
                    string i1 = Console.ReadLine();
                    if (!double.TryParse(i1, out double x) || string.IsNullOrWhiteSpace(i1)) throw new Exception("недопустимый/пустой символ");

                    Console.Write("Y: ");
                    string i2 = Console.ReadLine();
                    if (!double.TryParse(i2, out double y) || string.IsNullOrWhiteSpace(i2)) throw new Exception("недопустимый/пустой символ");

                    Console.Write("Формула (1, 2, 3): ");
                    string i3 = Console.ReadLine();
                    if (!int.TryParse(i3, out int i) || string.IsNullOrWhiteSpace(i3) || i <= 0 || i > 3) throw new Exception("недопустимая формула");

                    Console.WriteLine($"Результат формулы {i} = {m.Evaluate(x, y, i)}");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
    }
    class Methods
    {
        public double Evaluate(double x, double y, int i)
        {
            double res = 0;

            if (i == 1)
            {
                if (x - y == 0) res = Math.Pow(Math.Sinh(x), 2) + Math.Pow(y, 2) + Math.Sin(y);
                else if (x - y > 0) res = Math.Pow(Math.Sinh(x) - y, 2) + Math.Cos(y);
                else res = Math.Pow(y - Math.Sinh(x), 2) + Math.Tan(y);
            }

            else if (i == 2)
            {
                if (x - y == 0) res = Math.Pow(Math.Pow(x, 2), 2) + Math.Pow(y, 2) + Math.Sin(y);
                else if (x - y > 0) res = Math.Pow(Math.Pow(x, 2) - y, 2) + Math.Cos(y);
                else res = Math.Pow(y - Math.Pow(x, 2), 2) + Math.Tan(y);
            }

            else if (i == 3)
            {
                if (x - y == 0) res = Math.Pow(Math.Pow(Math.E, x), 2) + Math.Pow(y, 2) + Math.Sin(y);
                else if (x - y > 0) res = Math.Pow(Math.Pow(Math.E, x) - y, 2) + Math.Cos(y);
                else res = Math.Pow(y - Math.Pow(Math.E, x), 2) + Math.Tan(y);
            }

            return res;
        }
    }
}
