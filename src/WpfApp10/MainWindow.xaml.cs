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
                if (label.Content is Panel panel)
                {
                    panel.Children.Clear();
                    panel.Children.Add(new Button { Content = "button1", HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, Width = 30, Height = 10 });
                    panel.Children.Add(new Button { Content = "button2", HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Bottom, Width = 30, Height = 10 });
                    panel.Children.Add(new Button { Content = "button3", HorizontalAlignment = HorizontalAlignment.Right, VerticalAlignment = VerticalAlignment.Top, Width = 30, Height = 10 });
                    panel.Children.Add(new Button { Content = "button1", HorizontalAlignment = HorizontalAlignment.Right, VerticalAlignment = VerticalAlignment.Bottom, Width = 30, Height = 10 });
                    /*if (e.OriginalSource is MouseButtonEventArgs args && args.ChangedButton == MouseButton.Left)
                    {
                        
                    }*/
                }
            }    
        }
    }
}
