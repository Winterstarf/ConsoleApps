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
    /// Логика взаимодействия для OrdersWindow.xaml
    /// </summary>
    public partial class OrdersWindow : Window
    {
        RoolEntities2 db_cont = new RoolEntities2();
        public OrdersWindow()
        {
            InitializeComponent();
            Dtg_Orders.ItemsSource = db_cont.Orders.ToList();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var row = Dtg_Orders.SelectedItem as Orders;

            if (row == null)
            {
                MessageBox.Show("Не выбрана строка для удаления");
                return;
            }

            MessageBoxResult res = MessageBox.Show("Подтвердите удаление", "Удаление строки", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

            if (res == MessageBoxResult.Yes)
            {
                db_cont.Orders.Remove(row);
                db_cont.SaveChanges();

                MessageBox.Show("Строка удалена");
                Dtg_Orders.ItemsSource = db_cont.Orders.ToList();
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Dtg_Orders.ItemsSource = db_cont.Orders.Where(k => k.id.ToString().Contains(SearchTextBox.Text) || k.UserList.FirstName.ToString().Contains(SearchTextBox.Text) || k.UserList.LastName.ToString().Contains(SearchTextBox.Text) || k.UserList.Patronym.ToString().Contains(SearchTextBox.Text)).ToList();

            if (SearchTextBox.Text == "")
            {
                Dtg_Orders.ItemsSource = db_cont.Orders.ToList();
            }
        }
    }
}
