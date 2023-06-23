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
using System.Windows.Shapes;

namespace DBApp
{
    /// <summary>
    /// Логика взаимодействия для SuppliersWindow.xaml
    /// </summary>
    public partial class SuppliersWindow : Window
    {
        RoolEntities1 db_cont = new RoolEntities1();
        public SuppliersWindow()
        {
            InitializeComponent();
            Dtg_Suppliers.ItemsSource = db_cont.Supplier.ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
