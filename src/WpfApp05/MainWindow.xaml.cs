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
using WpfApp05.classes;

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
            Methods m = new Methods();

            OrigM.Text = "Ориг. матрица:" + Environment.NewLine;
            TransM.Text = "Изм. матрица:" + Environment.NewLine;
            Sum.Text = "Сумма S: ";

            double[,] matrix = m.Input();
            double sum = m.Sum(matrix);
            double[,] tmatrix = m.Transform(matrix, sum);

            Sum.Text += sum.ToString();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    OrigM.Text += $"{matrix[i, j]}\t";
                }
                OrigM.Text += Environment.NewLine;
            }

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
}
