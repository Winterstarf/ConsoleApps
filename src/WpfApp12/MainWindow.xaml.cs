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

namespace WpfApp12
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

        private void btn_calc_Click(object sender, RoutedEventArgs e)
        {
            int ind = lb_src.SelectedIndex, count = 0;
            string str = Convert.ToString(lb_src.Items[ind]);

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.' || str[i] == ',' || str[i] == '!' || str[i] == '?' || str[i] == '(' || str[i] == ')' || str[i] == ':' || str[i] == ';' || str[i] == '-')
                {
                    count++;
                }
            }

            lbl_res.Content = $"Знаков препинания: {count}";
        }
    }
}
