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
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        RoolEntities1 db_cont = new RoolEntities1();
        public AddWindow(RoolEntities1 cont, Goods g)
        {
            InitializeComponent();

            this.db_cont = cont;
            this.DataContext = g;

            MeasureUnitCB.ItemsSource = db_cont.MeasureUnit.ToList();
            ManufacturerCB.ItemsSource = db_cont.Manufacturer.ToList();
            SupplierCB.ItemsSource = db_cont.Supplier.ToList();
            CategoryCB.ItemsSource= db_cont.Category.ToList();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (ItemNameTB.Text == "" || MeasureUnitCB.SelectedItem == null || PriceTB.Text == "" || ManufacturerCB.SelectedItem == null || SupplierCB.SelectedItem == null || CategoryCB.SelectedItem == null || SaleTB.Text == "" || ItemCountTB.Text == "") //article, itempic - nullable
            {
                MessageBox.Show("Только Article и ItemPic могут не иметь значений");
            }

            else
            {
                db_cont.SaveChanges();
                this.Close();
            }
        }
    }
}
