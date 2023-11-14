using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
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

        int[] arr = new int[18];
        double[] arrEdited = new double[18];

        private void btn_fill_Click(object sender, RoutedEventArgs e)
        {
            lb_orig.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-50, 50);
                lb_orig.Items.Add($"Arr[{i + 1}] = {arr[i]}");
            }
        }

        private void btn_replace_Click(object sender, RoutedEventArgs e)
        {
            lb_edit.Items.Clear();

            for (int i = 0; i < arrEdited.Length; i++)
            {
                arrEdited[i] = (0.13 * Math.Pow(arr[i], 3)) - (2.5 * arr[i]) + 8;
                lb_edit.Items.Add($"Arr[{i + 1}] = {arrEdited[i]}");
            }

            lb_edit.Items.Add("\nОтрицательные (если есть):\n");

            for (int i = 0; i < arrEdited.Length; i++)
            {
                if (arrEdited[i] < 0)
                {
                    lb_edit.Items.Add($"Arr[{i + 1}] = {arrEdited[i]}");
                }
            }
        }

        private void tbNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            int n;
            
            if (int.TryParse(tbNum.Text, out n))
            {
                if (n > 0)
                {
                    arr = new int[n];
                    arrEdited = new double[n];
                }
                else
                {
                    MessageBox.Show("Cant be smaller than or zero");
                    tbNum.Text = "18";
                }
            }
            else
            {
                if (tbNum.Text.Contains('-'))
                {
                    MessageBox.Show("Cant be smaller than or zero");
                    tbNum.Text = "18";
                }
                else if (tbNum.Text == String.Empty)
                {
                    tbNum.Text = "";
                }
                else
                {
                    MessageBox.Show("Cant be not integer");
                    tbNum.Text = "18";
                }
            }
        }
    }
}
