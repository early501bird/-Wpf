using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Wpf.DepandencyProperty
{
    public class Student:DependencyObject
    {
        public static readonly DependencyProperty NameProperty = DependencyProperty.Register(
            "Name", typeof(string), typeof(Student));

        public string Name
        {
            get
            {
                return GetValue(NameProperty).ToString();
            }
            set
            {
                SetValue(NameProperty,value);
            }
        }

        public BindingExpressionBase SetBinding(DependencyProperty dp, BindingBase binding)
        {
            return BindingOperations.SetBinding(this, dp, binding);
        }
    }
}
