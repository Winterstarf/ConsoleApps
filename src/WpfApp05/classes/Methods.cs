using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp05.classes
{
    internal class Methods
    {
        public double[,] Fill(int n)
        {
            Random r = new Random();
            double[,] m = new double[n, n];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++) m[i, j] = r.Next(-10, 10);
            }
            return m;
        }

        public double[,] Transform(double[,] m, double s)
        {
            double[,] t = new double[m.GetLength(0), m.GetLength(1)];
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    if (s > 10) t[i, j] = m[i, j] + 13.5;
                    else t[i, j] = Math.Pow(m[i, j], 2) - 1.5;
                }
            }
            return t;
        }

        public double Sum(double[,] m)
        {
            double s = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                if (m[i, i] == m[i, i]) { s += m[i, i]; } 
            }
            return s;
        }

        public DataTable dtFill(double[,] m)
        {
            DataTable dt = new DataTable();
            int r = m.GetLength(0);
            int c = m.GetLength(1);
            for (int i = 0; i < c; i++) dt.Columns.Add($"Cln {i + 1}");
            for (int i = 0; i < r; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < c; j++) dr[j] = m[i, j];
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
