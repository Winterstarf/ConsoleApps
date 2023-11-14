using System;
using System.Collections.Generic;
using System.Data;
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

            if (!int.TryParse(tbNum.Text, out int n) || n <= 0 || tbNum.Text == String.Empty)
            {
                MessageBox.Show("Cant be not an positive int");
                tbNum.Text = "10";
            }
            else
            {
                n = int.Parse(tbNum.Text);
                double[,] mx = m.Fill(n);
                double[,] tmx = m.Transform(mx, m.Sum(mx));

                Sum.Text = $"Сумма S: {m.Sum(mx)}";
                dgOrig.ItemsSource = m.dtFill(mx).DefaultView;
                dgEdit.ItemsSource = m.dtFill(tmx).DefaultView;
            }
        }
    }
}
