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

namespace WpfApp10
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

        private void Label_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Label label)
            {
                if (label.Content is Grid panel)
                {
                    panel.Children.Clear();
                    panel.Children.Add(new Button { Content = "button1", HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, MinWidth = 20, MinHeight = 15 });
                    panel.Children.Add(new Button { Content = "button2", HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Bottom, MinWidth = 20, MinHeight = 15 });
                    panel.Children.Add(new Button { Content = "button3", HorizontalAlignment = HorizontalAlignment.Right, VerticalAlignment = VerticalAlignment.Top, MinWidth = 20, MinHeight = 15 });
                    panel.Children.Add(new Button { Content = "button4", HorizontalAlignment = HorizontalAlignment.Right, VerticalAlignment = VerticalAlignment.Bottom, MinWidth = 20, MinHeight = 15 });
                }
            }
        }

        private void Grid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            DependencyObject source = (DependencyObject)e.OriginalSource;
            if (sender is Grid grid && !isChildOfPanel(source, lbl_1))
            {
                MessageBox.Show("aboba");
                /*if (window.Content is Grid grid && !isChildOfPanel(source, lbl_1))
                {
                    grid.Children.Clear();
                    grid.Children.Add(new TextBox { Text = "textbox1", HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, MinWidth = 20, MinHeight = 15 });
                    grid.Children.Add(new TextBox { Text = "textbox2", HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Bottom, MinWidth = 20, MinHeight = 15 });
                    grid.Children.Add(new TextBox { Text = "textbox3", HorizontalAlignment = HorizontalAlignment.Right, VerticalAlignment = VerticalAlignment.Top, MinWidth = 20, MinHeight = 15 });
                    grid.Children.Add(new TextBox { Text = "textbox4", HorizontalAlignment = HorizontalAlignment.Right, VerticalAlignment = VerticalAlignment.Bottom, MinWidth = 20, MinHeight = 15 });
                }*/
            }    
        }

        private bool isChildOfPanel(DependencyObject child, DependencyObject panel)
        {
            var parent = VisualTreeHelper.GetParent(child);

            if (parent == panel) return true;
            else if (parent ==)
        }
    }
}
