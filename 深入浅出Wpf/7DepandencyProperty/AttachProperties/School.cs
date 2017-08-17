using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf.DepandencyProperty.AttachProperties
{
    public class School:DependencyObject
    {
        public static readonly DependencyProperty GradeProperty = DependencyProperty.Register(
            "Grade", typeof(int), typeof(School), new PropertyMetadata(default(int)));

        public static int GetGrade(DependencyObject obj)
        {
            return (int) obj.GetValue(GradeProperty);
        }

        public static void SetGrade(DependencyObject obj, int value)
        {
            obj.SetValue(GradeProperty,value);
        }
    }
}
