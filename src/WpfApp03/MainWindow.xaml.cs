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

namespace WpfApp03
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i;
        double x, y;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ResButton_Click(object sender, RoutedEventArgs e)
        {
            x = Convert.ToDouble(XTextBox.Text);
            y = Convert.ToDouble(YTextBox.Text);
            Methods m = new Methods();
            double res = m.Evaluate(x, y, i);
            MessageBox.Show($"Результат = {res}");
        }

        private void SinhRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            i = 1;
        }

        private void X2RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            i = 2;
        }

        private void EXRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            i = 3;
        }
    }
    public class Methods
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
