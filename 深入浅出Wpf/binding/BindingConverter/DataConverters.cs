using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Wpf.binding.BindingConverter
{
    public class CategoryToSourceConverter : IValueConverter
    {
        
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string rootPath = AppDomain.CurrentDomain.BaseDirectory;

            Category c = (Category) value;
            switch (c)
            {
                case Category.Boomber:
                    return Path.Combine(rootPath, "Resource/Boomber.png");
                case Category.Fighter:
                    return Path.Combine(rootPath, "Resource/Fighter.png");
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    public class StringToNullableBoolConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            State s = (State) value;
            switch (s)
            {
                case State.Available:
                    return true;
                case State.Locked:
                    return false;
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? nb = (bool?) value;
            switch (nb)
            {
                case true:
                    return State.Available;
                case false:
                    return State.Locked;
                default:
                    return State.Unknown;
            }
        }
    }
}
