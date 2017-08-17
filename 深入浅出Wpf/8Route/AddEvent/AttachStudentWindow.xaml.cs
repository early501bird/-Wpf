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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Wpf.Route.AddEvent
{
    /// <summary>
    /// AttachStudentWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AttachStudentWindow : Window
    {
        public AttachStudentWindow()
        {
            InitializeComponent();

            AttachedStudent.AddNameChangedHandler(GridMain, new RoutedEventHandler(StudentNameChangedHandler));
            //GridMain.AddHandler(AttachedStudent.NameChangedEvent,new RoutedEventHandler(StudentNameChangedHandler));
        }

        private void Button1_OnClick(object sender, RoutedEventArgs e)
        {
            AttachedStudent student = new AttachedStudent() {Id = 1, Name = "Tom"};
            student.Name = "Tim";
            Button1.RaiseEvent(new RoutedEventArgs(AttachedStudent.NameChangedEvent,student));
        }

        private void StudentNameChangedHandler(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as AttachedStudent).Id.ToString());
        }
    }
}
