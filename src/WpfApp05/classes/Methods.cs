using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp05.classes
{
    internal class Methods
    {
        public double[,] Input()
        {
            Random rnd = new Random();
            double[,] matrix = new double[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 10);
                }
            }
            return matrix;
        }
        public double Sum(double[,] matrix)
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; i < 10; i++)
                {
                    if (i == j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
        public double[,] Transform(double[,] matrix, double sum)
        {
            double[,] tmatrix = new double[10, 10];
            if (sum > 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        tmatrix[i, j] = matrix[i, j] + 13.5;
                    }
                }
            }
            else if (sum <= 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        tmatrix[i, j] = Math.Pow(matrix[i, j], 2) - 1.5;
                    }
                }
            }
            return tmatrix;
        }
    }
}
