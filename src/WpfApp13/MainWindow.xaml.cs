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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp13
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

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Ellipse head = new Ellipse { Width = 50, Height = 50, Stroke = Brushes.Black };
            Rectangle body = new Rectangle { Width = 3, Height = 100, Stroke = Brushes.Black };
            
            Canvas c = new Canvas();
            Canvas.SetLeft(body, 150);
            Canvas.SetTop(body, 180);
            c.Children.Add(head);
            c.Children.Add(body);
            this.Content = c;

            DoubleAnimation da = new DoubleAnimation { From = 0, To = this.Width - head.Width, Duration = TimeSpan.FromSeconds(3), AutoReverse = true, RepeatBehavior = RepeatBehavior.Forever };
            body.BeginAnimation(Canvas.LeftProperty, da);

            DoubleAnimation daLeg = new DoubleAnimation { From = body.ActualHeight, To = 25, Duration = TimeSpan.FromSeconds(1), AutoReverse = true, RepeatBehavior = RepeatBehavior.Forever };
            Rectangle lLeg = new Rectangle { Width = 3, Height = 50, Stroke = Brushes.Black };
            Canvas.SetLeft(lLeg, 250);
            Canvas.SetTop(lLeg, 320);
            c.Children.Add(lLeg);
            lLeg.BeginAnimation(Canvas.LeftProperty, da);
            lLeg.BeginAnimation(Canvas.BottomProperty, daLeg);

            Rectangle rLeg = new Rectangle { Width = 3, Height = 50, Stroke = Brushes.Black };
            Canvas.SetLeft(rLeg, 100);
            Canvas.SetTop(rLeg, 280);
            c.Children.Add(rLeg);
            rLeg.BeginAnimation(Canvas.LeftProperty, da);
            rLeg.BeginAnimation(Canvas.BottomProperty, daLeg);
        }
    }
}
