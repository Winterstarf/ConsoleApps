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

namespace WpfApp08
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

        private void resbtn_Click(object sender, RoutedEventArgs e)
        {
            restbx.Text = "Result:";

            if (xtbx.Text == string.Empty || ytbx.Text == string.Empty || ztbx.Text == string.Empty) MessageBox.Show("One of fields is empty");
            else if (!double.TryParse(xtbx.Text, out double x) || !double.TryParse(ytbx.Text, out double y) || !double.TryParse(ztbx.Text, out double z)) MessageBox.Show("One of fields has incorrect num");
            else
            {
                x = double.Parse(xtbx.Text);
                y = double.Parse(ytbx.Text);
                z = double.Parse(ztbx.Text);

                double v = (1 + Math.Pow(Math.Sin(x + y), 2)) / (Math.Abs(x - ((2 * y) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2))))) * Math.Pow(x, Math.Abs(y)) + Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);

                restbx.Text += "\n" + Convert.ToString(v);
            }    
        }
    }
}
