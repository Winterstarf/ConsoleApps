using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp14.classes
{
    public class NumberRange : ValidationRule
    {
        public double MinValue { get; set; }
        public double MaxValue { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double num;

            if (double.TryParse(value as string, out num))
            {
                if (num >= MinValue && num <= MaxValue) return ValidationResult.ValidResult;
                else
                {
                    MessageBox.Show($"Число должно быть между {MinValue} и {MaxValue}", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return new ValidationResult(false, $"Число должно быть между {MinValue} и {MaxValue}");
                }
            }
            else
            {
                MessageBox.Show("Надо ввести число", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return new ValidationResult(false, "Надо ввести число");
            }
        }
    }
}
