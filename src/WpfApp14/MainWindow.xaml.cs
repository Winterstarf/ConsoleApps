using System;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

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

            SolidColorBrush black = new SolidColorBrush(Colors.Black);
            SolidColorBrush red = new SolidColorBrush(Colors.Red);

            Line cl1 = new Line();
            cl1.X1 = -250;
            cl1.X2 = 250;
            cl1.Y1 = 0;
            cl1.Y2 = 0;
            cl1.StrokeThickness = 1;
            cl1.Stroke = black;
            main_cvs.Children.Add(cl1);
            Line cl2 = new Line();
            cl2.X1 = 0;
            cl2.X2 = 0;
            cl2.Y1 = -150;
            cl2.Y2 = 150;
            cl2.StrokeThickness = 1;
            cl2.Stroke = black;
            main_cvs.Children.Add(cl2);
            Line ar1 = new Line();
            ar1.X1 = -5;
            ar1.X2 = 0;
            ar1.Y1 = 142;
            ar1.Y2 = 150;
            ar1.StrokeThickness = 1;
            ar1.Stroke = black;
            main_cvs.Children.Add(ar1);
            Line ar2 = new Line();
            ar2.X1 = 5;
            ar2.X2 = 0;
            ar2.Y1 = 142;
            ar2.Y2 = 150;
            ar2.StrokeThickness = 1;
            ar2.Stroke = black;
            main_cvs.Children.Add(ar2);
            Line ar3 = new Line();
            ar3.X1 = 242;
            ar3.X2 = 250;
            ar3.Y1 = -5;
            ar3.Y2 = 0;
            ar3.StrokeThickness = 1;
            ar3.Stroke = black;
            main_cvs.Children.Add(ar3);
            Line ar4 = new Line();
            ar4.X1 = 242;
            ar4.X2 = 250;
            ar4.Y1 = 5;
            ar4.Y2 = 0;
            ar4.StrokeThickness = 1;
            ar4.Stroke = black;
            main_cvs.Children.Add(ar4);
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

                SolidColorBrush black = new SolidColorBrush(Colors.Black);
                SolidColorBrush red = new SolidColorBrush(Colors.Red);

                Line cl1 = new Line();
                cl1.X1 = -250;
                cl1.X2 = 250;
                cl1.Y1 = 0;
                cl1.Y2 = 0;
                cl1.StrokeThickness = 1;
                cl1.Stroke = black;
                main_cvs.Children.Add(cl1);
                Line cl2 = new Line();
                cl2.X1 = 0;
                cl2.X2 = 0;
                cl2.Y1 = -150;
                cl2.Y2 = 150;
                cl2.StrokeThickness = 1;
                cl2.Stroke = black;
                main_cvs.Children.Add(cl2);
                Line ar1 = new Line();
                ar1.X1 = -5;
                ar1.X2 = 0;
                ar1.Y1 = 142;
                ar1.Y2 = 150;
                ar1.StrokeThickness = 1;
                ar1.Stroke = black;
                main_cvs.Children.Add(ar1);
                Line ar2 = new Line();
                ar2.X1 = 5;
                ar2.X2 = 0;
                ar2.Y1 = 142;
                ar2.Y2 = 150;
                ar2.StrokeThickness = 1;
                ar2.Stroke = black;
                main_cvs.Children.Add(ar2);
                Line ar3 = new Line();
                ar3.X1 = 242;
                ar3.X2 = 250;
                ar3.Y1 = -5;
                ar3.Y2 = 0;
                ar3.StrokeThickness = 1;
                ar3.Stroke = black;
                main_cvs.Children.Add(ar3);
                Line ar4 = new Line();
                ar4.X1 = 242;
                ar4.X2 = 250;
                ar4.Y1 = 5;
                ar4.Y2 = 0;
                ar4.StrokeThickness = 1;
                ar4.Stroke = black;
                main_cvs.Children.Add(ar4);

                if (double.Parse(ax_tb.Text) > 250 || double.Parse(ax_tb.Text) < -250 || !double.TryParse(ax_tb.Text, out double ax) || double.Parse(ay_tb.Text) > 150 || double.Parse(ay_tb.Text) < -150 || !double.TryParse(ay_tb.Text, out double ay))
                {
                    throw new Exception($"Значение точки a превышает лимиты или не является числом.");
                }
                if (double.Parse(bx_tb.Text) > 250 || double.Parse(bx_tb.Text) < -250 || !double.TryParse(bx_tb.Text, out double bx) || double.Parse(by_tb.Text) > 150 || double.Parse(by_tb.Text) < -150 || !double.TryParse(by_tb.Text, out double by))
                {
                    throw new Exception($"Значение точки b превышает лимиты или не является числом.");
                }
                if (double.Parse(cx_tb.Text) > 250 || double.Parse(cx_tb.Text) < -250 || !double.TryParse(cx_tb.Text, out double cx) || double.Parse(cy_tb.Text) > 150 || double.Parse(cy_tb.Text) < -150 || !double.TryParse(cy_tb.Text, out double cy))
                {
                    throw new Exception($"Значение точки c превышает лимиты или не является числом.");
                }
                if (double.Parse(dx_tb.Text) > 250 || double.Parse(dx_tb.Text) < -250 || !double.TryParse(dx_tb.Text, out double dx) || double.Parse(dy_tb.Text) > 150 || double.Parse(dy_tb.Text) < -150 || !double.TryParse(dy_tb.Text, out double dy))
                {
                    throw new Exception($"Значение точки d превышает лимиты или не является числом.");
                }

                Point a = new Point(ax, ay);
                Point b = new Point(bx, by);
                Point c = new Point(cx, cy);
                Point d = new Point(dx, dy);

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

                //метод через формулу углового коэффа, k = (y2 - y1) / (x2 - x1)
                double k1 = (b.Y - a.Y) / (b.X - a.X);
                double k2 = (d.Y - c.Y) / (d.X - c.X);

                //b уравнений прямых (смещение)
                double b1 = a.Y - k1 * a.X;
                double b2 = c.Y - k2 * c.X;

                //x и y точки пересечения по коэффам
                double ix = (b2 - b1) / (k1 - k2);
                double iy = k1 * ix + b1;

                //расстояние между точками
                double dist1 = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
                double dist2 = Math.Sqrt(Math.Pow(d.X - c.X, 2) + Math.Pow(d.Y - c.Y, 2));

                string answer = $"Точка пер. в ({ Math.Round(ix, 2)}; { Math.Round(iy, 2)})";

                //kostyly ktore dzialaja, nie wiem jak
                if (k1 == k2) answer = "Прямые параллельны";
                else if (double.IsInfinity(k1) == true && k2 == 0)
                {
                    ix = a.X;
                    iy = b2;
                    answer += $". Прямые перпедикулярны";
                }
                else if (double.IsInfinity(k2) == true || double.IsInfinity(b2) == true)
                {
                    ix = c.X;
                    iy = b1;
                    answer += $". Прямые перпедикулярны";
                }
                else if (double.IsInfinity(k1) == true && double.IsInfinity(b1) == true)
                {
                    k1 = 0;
                    b1 = 0;
                    ix = (b2 - b1) / (k1 - k2);
                    iy = k1 * ix + b1;
                    answer += $". Прямые пересекаются";
                }
                else answer += $". Прямые пересекаются";

                answer += $". Расстояние между точками a и b = {Math.Round(dist1, 2)}, между c и d = {Math.Round(dist2, 2)}.";
                res_tb.Text = answer;
            }
            catch (FormatException)
            {
                MessageBox.Show("Одно/несколько из введённых значений - не число или пусто.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
