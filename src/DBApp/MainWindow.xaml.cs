using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlTypes;
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

namespace DBApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RoolEntities1 db_cont = new RoolEntities1();
        public MainWindow()
        {
            InitializeComponent();
            Dtg_Goods.ItemsSource = db_cont.Goods.ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var row = Dtg_Goods.SelectedItem as Goods;

            if (row == null)
            {
                MessageBox.Show("Не выбрана строка для удаления");
                return;
            }

            MessageBoxResult res = MessageBox.Show("Подтвердите удаление", "Удаление строки", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

            if (res == MessageBoxResult.Yes)
            {
                db_cont.Goods.Remove(row);
                db_cont.SaveChanges();

                MessageBox.Show("Строка удалена");
                Dtg_Goods.ItemsSource = db_cont.Goods.ToList();
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OrdersButton_Click(object sender, RoutedEventArgs e)
        {
            OrdersWindow ordersWindow = new OrdersWindow();
            ordersWindow.Show();
        }

        private void SuppliersButton_Click(object sender, RoutedEventArgs e)
        {
            SuppliersWindow suppliersWindow = new SuppliersWindow();
            suppliersWindow.Show();
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Dtg_Goods.ItemsSource = db_cont.Goods.Where(k => k.ItemName.ToString().Contains(SearchTextBox.Text) || k.Category.CategoryName.ToString().Contains(SearchTextBox.Text) || k.Manufacturer.ManufacturerName.ToString().Contains(SearchTextBox.Text) || k.Supplier.SupplierName.ToString().Contains(SearchTextBox.Text)).ToList();
            
            if (SearchTextBox.Text == "")
            {
                Dtg_Goods.ItemsSource = db_cont.Goods.ToList();
            }
        }
    }
}
