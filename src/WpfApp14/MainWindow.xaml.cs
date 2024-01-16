using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using WpfApp14.classes;

namespace WpfApp14
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

        private void main_cvs_MouseDown(object sender, MouseButtonEventArgs e)
        {
            main_cvs.Children.Clear();
        }

        private void draw_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                main_cvs.Children.Clear();
                res_tb.Text = "";

                Point a = new Point(double.Parse(ax_tb.Text), double.Parse(ay_tb.Text));
                Point b = new Point(double.Parse(bx_tb.Text), double.Parse(by_tb.Text));
                Point c = new Point(double.Parse(cx_tb.Text), double.Parse(cy_tb.Text));
                Point d = new Point(double.Parse(dx_tb.Text), double.Parse(dy_tb.Text));

                SolidColorBrush black = new SolidColorBrush(Colors.Black);
                SolidColorBrush red = new SolidColorBrush(Colors.Red);

                Line ab = new Line();
                ab.X1 = a.X;
                ab.X2 = b.X;
                ab.Y1 = a.Y;
                ab.Y2 = b.Y;
                ab.StrokeThickness = 2;
                ab.Stroke = black;
                main_cvs.Children.Add(ab);

                Line cd = new Line();
                cd.X1 = c.X;
                cd.X2 = d.X;
                cd.Y1 = c.Y;
                cd.Y2 = d.Y;
                cd.StrokeThickness = 2;
                cd.Stroke = red;
                main_cvs.Children.Add(cd);

                Point ta = new Point(ab.X1, ab.Y1);
                Point tb = new Point(ab.X2, ab.Y2);
                Point tc = new Point(cd.X1, cd.Y1);
                Point td = new Point(cd.X2, cd.Y2);

                //метод через формулу углового коэффа, k = (y2 - y1) / (x2 - x1)
                double k1 = (tb.Y - ta.Y) / (tb.X - ta.X);
                double k2 = (td.Y - tc.Y) / (td.X - tc.X);

                //b уравнений прямых
                double b1 = ta.Y - k1 * ta.X;
                double b2 = tc.Y - k2 * tc.X;

                //x и y точки пересечения по коэффам
                double ix = (b2 - b1) / (k1 - k2);
                double iy = k1 * ix + b1;

                //расстояние между точками
                double dist1 = Math.Sqrt(Math.Pow(tb.X - ta.X, 2) + Math.Pow(tb.Y - ta.Y, 2));
                double dist2 = Math.Sqrt(Math.Pow(td.X - tc.X, 2) + Math.Pow(td.Y - tc.Y, 2));

                MessageBox.Show($"{ta}, {tb}, {tc}, {td}, {k1}, {k2}, {ix}, {iy}, {b1}, {b2}");

                if (k1 == k2)
                {
                    res_tb.Text = "Прямые параллельны";
                }

                else if (double.IsInfinity(k1) == true && k2 == 0)
                {
                    ix = ta.X;
                    iy = b2;

                    res_tb.Text = $"Т. пер. в ({ix}, {iy}). Прямые перпедикулярны";
                }

                else
                {
                    ix = (b2 - b1) / (k1 - k2);
                    iy = k1 * ix + b1;

                    res_tb.Text = $"Т. пер. в ({ix}, {iy}). Прямые пересекаются";
                }

                res_tb.Text += $". Расстояние между a и b, с и d = {dist1}, {dist2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
