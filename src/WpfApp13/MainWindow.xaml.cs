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
            Canvas c = new Canvas();
            this.Content = c;

            Ellipse head = new Ellipse { Width = 50, Height = 50, Stroke = Brushes.Black };
            Canvas.SetLeft(head, 225);
            Canvas.SetTop(head, 80);
            c.Children.Add(head);

            Rectangle body = new Rectangle { Width = 3, Height = 100, Stroke = Brushes.Black };
            Canvas.SetLeft(body, 224);
            Canvas.SetTop(body, 130);
            c.Children.Add(body);

            Rectangle leftLeg = new Rectangle { Width = 3, Height = 50, Stroke = Brushes.Black };
            Canvas.SetLeft(leftLeg, 224);
            Canvas.SetTop(leftLeg, 230);
            c.Children.Add(leftLeg);

            Rectangle rightLeg = new Rectangle { Width = 3, Height = 50, Stroke = Brushes.Black };
            Canvas.SetLeft(rightLeg, 227);
            Canvas.SetTop(rightLeg, 230);
            c.Children.Add(rightLeg);

            DoubleAnimation da = new DoubleAnimation 
            {  
               From = 0, 
               To = this.Width - head.Width, 
               Duration = TimeSpan.FromSeconds(3),
               AutoReverse = true,
               RepeatBehavior = RepeatBehavior.Forever 
            };

            head.BeginAnimation(Canvas.LeftProperty, da);
            body.BeginAnimation(Canvas.LeftProperty, da);
            leftLeg.BeginAnimation(Canvas.LeftProperty, da);
            rightLeg.BeginAnimation(Canvas.LeftProperty, da);

            DoubleAnimation daLeg1 = new DoubleAnimation 
            { 
                From = 224, 
                To = 250, 
                Duration = TimeSpan.FromSeconds(1), 
                AutoReverse = true, 
                RepeatBehavior = RepeatBehavior.Forever 
            };

            leftLeg.BeginAnimation(Canvas.TopProperty, daLeg1);

            DoubleAnimation daLeg2 = new DoubleAnimation
            {
                From = 221,
                To = 255,
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            rightLeg.BeginAnimation(Canvas.TopProperty, daLeg2);
        }
    }
}
