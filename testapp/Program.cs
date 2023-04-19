using System;

namespace testapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестирование работы индексаторов: ");
            Arr x = new Arr(3);
            x[0] = 5;
            Console.WriteLine(x[1]);
            x.Print();
        }
    }
    class Arr
    {
        int n;
        double[] x;
        public Arr()
        {
            n = 1;
            x = new double[n];
            x[0] = 1;
        }
        public Arr(int n0)
        {
            n = n0;
            if (n < 1) n = 1;
            x = new double[n];
            for (int i = 0; i < n; i++) x[i] = 1 + i;
        }
        public double this[int i]
        {
            get { return x[i]; }
            set { x[i] = value; }
        }
        public void Print()
        {
            Console.WriteLine("Массив крутой: " + string.Join(", ", x));
        }
    }
}
