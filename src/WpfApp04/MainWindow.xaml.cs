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
            x0 = Convert.ToDouble(X0TextBox.Text);
            xk = Convert.ToDouble(XkTextBox.Text);
            dx = Convert.ToDouble(DxTextBox.Text);
            a = Convert.ToDouble(ATextBox.Text);
            b = Convert.ToDouble(BTextBox.Text);


        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
    class Methods
    {
        public double Evaluate(double x0, double xk, double dx, double a, double b)
        {
            double x = x0;

            while (x <= (xk + dx / 2))
            {

            }
        }
    }
}
