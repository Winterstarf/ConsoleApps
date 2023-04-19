using System;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Drob - test");

            Drob x = new Drob(2, 5);
            x.print();

            Drob y = new Drob();
            y = -x;
            y.print();

            Drob z = new Drob();
            z = ++x;
            z.print();
        }
    }
    public class Drob
    {
        int a; //числитель
        int b; //знаменатель
        public Drob()
        {
            a = 0;
            b = 1;
        }
        public Drob(int a0, int b0)
        {
            a = a0;
            b = b0;
            if (b == 0)
            {
                Console.WriteLine("недопустимое значение b");
            }
            else
            {
                a = -a;
                b = -b;
            }
        }
        public static Drob operator -(Drob x) //смена знака a
        {
            Drob t = new Drob();
            t.a = -x.a;
            t.b = x.b;
            return t;
        }
        public static Drob operator ++(Drob x)
        {
            Drob t = new Drob();
            t.a = ++x.a;
            t.b = x.b;
            return t;
        }
        public void print()
        {
            Console.WriteLine("{0}/{1}", a, b);
        }
    }
}
