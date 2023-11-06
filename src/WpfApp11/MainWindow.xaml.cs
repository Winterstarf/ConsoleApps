using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace WpfApp11
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

        List<int> arr = new List<int>(18);
        List<double> arrEdited = new List<double>(18);

        private void btn_fill_Click(object sender, RoutedEventArgs e)
        {
            lb_orig.Items.Clear();
            Random rnd = new Random();
            if (Convert.ToInt32(tbNum.Text) != 18)
            {
                arr.Capacity = Convert.ToInt
            }
            for (int i = 0; i < arr.Capacity; i++)
            {
                arr[i] = rnd.Next(-50, 50);
                lb_orig.Items.Add($"Arr[{i + 1}] = {arr[i]}");
            }
        }

        private void btn_replace_Click(object sender, RoutedEventArgs e)
        {
            lb_edit.Items.Clear();

            for (int i = 0; i < arrEdited.Capacity; i++)
            {
                arrEdited[i] = (0.13 * Math.Pow(arr[i], 3)) - (2.5 * arr[i]) + 8;
                lb_edit.Items.Add($"Arr[{i + 1}] = {arrEdited[i]}");
            }

            lb_edit.Items.Add("\nОтрицательные (если есть):\n");

            for (int i = 0; i < arrEdited.Capacity; i++)
            {
                if (arrEdited[i] < 0)
                {
                    lb_edit.Items.Add($"Arr[{i + 1}] = {arrEdited[i]}");
                }
            }
        }
    }
}
