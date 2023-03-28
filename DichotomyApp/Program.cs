using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace WinFormsApp01
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public static class Dichotomy
    {
        /*func delegate named 'f', declared in btnFindRoot_Click, 
        its essentially a short way to make a simple method, 
        here it takes double (x) and returns a double*/
        public static double FindRoot(Func<double, double> func, double a, double b, double tol) 
        {
            double funca = func(a); //calculates the value of the user-entered function at the lower endpoint a, using the f delegate
            double funcb = func(b); //a and b are initial bounds
            double c = (a + b) / 2; //mid bound
            double funcc = func(c);

            while (Math.Abs(b - a) > tol) //
            {
                if (funcc == 0) return c; //exact root value found, other ifs are skipped
                else if (funca * funcc < 0) //root is in interval [a,c]
                {
                    b = c;
                    funcb = funcc;
                }
                else //root is in [c,b]
                {
                    a = c;
                    funca = funcc;
                }
                c = (a + b) / 2;
                funcc = func(c);
            }
            return c; //exact root couldnt be found so this returns an approximate one using formulas above
        }
    }
}
