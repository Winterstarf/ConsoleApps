using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Butt_Click(object sender, RoutedEventArgs e)
        {
            OrigM.Text = "Ориг. матрица:" + Environment.NewLine;
            TransM.Text = "Изм. матрица:" + Environment.NewLine;
            Sum.Text = "Сумма S: ";

            double[,] matrix = Matrix.Input();
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    OrigM.Text += $"{matrix[i, j]}\t";
                }
                OrigM.Text += Environment.NewLine;
            }

            double sum = Matrix.Sum(matrix);
            double[,] tmatrix = Matrix.Transform(matrix, sum);

            Sum.Text += sum.ToString();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    TransM.Text += $"{tmatrix[i, j]}\t";
                }
                TransM.Text += Environment.NewLine;
            }
        }
    }
    class Matrix
    {
        public static double[,] Input()
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
        public static double Sum(double[,] matrix)
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
        public static double[,] Transform(double[,] matrix, double sum)
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
