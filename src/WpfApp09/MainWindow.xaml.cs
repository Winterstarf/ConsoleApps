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

namespace WpfApp09
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void resBtn_Click(object sender, RoutedEventArgs e)
        {
            resTbx.Text = string.Empty;
            
            int f;
            string fStr;

            if (shxRbtn.IsChecked == true) f = 1;
            else if (x2Rbtn.IsChecked == true) f = 2;
            else f = 3;

            double c;

            if (xTbx.Text == string.Empty || yTbx.Text == string.Empty) MessageBox.Show("Either x or y is empty");
            else if (!double.TryParse(xTbx.Text, out double x) || !double.TryParse(yTbx.Text, out double y)) MessageBox.Show("Either x or y is not a number");
            else
            {
                if (f == 1)
                {
                    if (x - y == 0) c = Math.Pow(Math.Sinh(x), 2) + Math.Pow(y, 2) + Math.Sin(y);
                    else if (x - y > 0) c = Math.Pow(Math.Sinh(x) - y, 2) + Math.Cos(y);
                    else c = Math.Pow(y - Math.Sinh(x), 2) + Math.Tan(y);

                    fStr = shxTb.Text;
                }
                else if (f == 2)
                {
                    if (x - y == 0) c = Math.Pow(Math.Pow(x, 2), 2) + Math.Pow(y, 2) + Math.Sin(y);
                    else if (x - y > 0) c = Math.Pow(Math.Pow(x, 2) - y, 2) + Math.Cos(y);
                    else c = Math.Pow(y - Math.Pow(x, 2), 2) + Math.Tan(y);

                    fStr = x2Tb.Text;
                }
                else
                {
                    if (x - y == 0) c = Math.Pow(Math.Exp(x), 2) + Math.Pow(y, 2) + Math.Sin(y);
                    else if (x - y > 0) c = Math.Pow(Math.Exp(x) - y, 2) + Math.Cos(y);
                    else c = Math.Pow(y - Math.Exp(x), 2) + Math.Tan(y);

                    fStr = exTb.Text;
                }

                resTbx.Text = $"При:\nx={x}\ny={y}\nf(x)={fStr}\n\nРезультат:\nc={Convert.ToString(c)}";
            }
        }
    }
}
