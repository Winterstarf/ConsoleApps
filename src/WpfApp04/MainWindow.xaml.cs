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
using System.Xml.Resolvers;

namespace WpfApp04
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double x0, xk, dx, a, b;

        private void ResButton_Click(object sender, RoutedEventArgs e)
        {
            ResTextBox.Text = string.Empty;

            x0 = Convert.ToDouble(X0TextBox.Text);
            xk = Convert.ToDouble(XkTextBox.Text);
            dx = Convert.ToDouble(DxTextBox.Text);
            a = Convert.ToDouble(ATextBox.Text);
            b = Convert.ToDouble(BTextBox.Text);

            double x = x0;

            while (x <= (xk + dx / 2))
            {
                double y = Math.Pow(10, -1) * a * Math.Pow(x, 3) * Math.Tan(a - b * x);
                ResTextBox.Text += "x=" + Convert.ToString(x) + "; y=" + Convert.ToString(y) + Environment.NewLine;
                x += dx;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
