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

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var row = Dtg_Suppliers.SelectedItem as Supplier;

            if (row == null)
            {
                MessageBox.Show("Не выбрана строка для удаления");
                return;
            }

            MessageBoxResult res = MessageBox.Show("Подтвердите удаление", "Удаление строки", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

            if (res == MessageBoxResult.Yes)
            {
                db_cont.Supplier.Remove(row);
                db_cont.SaveChanges();

                MessageBox.Show("Строка удалена");
                Dtg_Suppliers.ItemsSource = db_cont.Supplier.ToList();
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Dtg_Suppliers.ItemsSource = db_cont.Supplier.Where(k => k.id.ToString().Contains(SearchTextBox.Text) || k.SupplierName.ToString().Contains(SearchTextBox.Text)).ToList();

            if (SearchTextBox.Text == "")
            {
                Dtg_Suppliers.ItemsSource = db_cont.Supplier.ToList();
            }
        }
    }
}
