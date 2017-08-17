using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Wpf.binding
{
    /// <summary>
    /// SliderBindingValidation.xaml 的交互逻辑
    /// </summary>
    public partial class SliderBindingValidation : Window
    {
        public SliderBindingValidation()
        {
            InitializeComponent();

            Binding binding = new Binding("Value") { Source = Slider1 };
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            RangeValidationRule rvr=new RangeValidationRule();
            rvr.ValidatesOnTargetUpdated = true;
            binding.ValidationRules.Add(rvr);
            binding.NotifyOnValidationError = true;
            TextBox1.SetBinding(TextBox.TextProperty, binding);
            TextBox1.AddHandler(Validation.ErrorEvent,new RoutedEventHandler(ValidationError));
        }

        private void ValidationError(object sender, RoutedEventArgs e)
        {
            if (Validation.GetErrors(TextBox1).Count > 0)
            {
                TextBox1.ToolTip = Validation.GetErrors(TextBox1)[0].ErrorContent.ToString();
            }
        }
    }

    public class RangeValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double d = 0;
            if (double.TryParse(value.ToString(), out d))
            {
                if (d >= 0 && d <= 100)
                {
                    return new ValidationResult(true, null);
                }
            }
            return new ValidationResult(false, "Validation failed");
        }
    }
}
