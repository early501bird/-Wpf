using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Wpf._11Template
{
    public class NameToPhotoPathConverter:IValueConverter
    {
        private readonly string _root = AppDomain.CurrentDomain.BaseDirectory;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var uriStr = $"{_root}Resources\\{value}.jpg";
            return new BitmapImage(new Uri(uriStr, UriKind.Absolute));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
