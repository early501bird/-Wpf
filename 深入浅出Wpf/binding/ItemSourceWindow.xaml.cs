using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// ItemSourceWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ItemSourceWindow : Window
    {
        public ItemSourceWindow()
        {
            InitializeComponent();
            ObservableCollection<StudentEntity> students = StudentsCollection.GetStudents();
            ListBoxStudents.ItemsSource = students;
            //ListBoxStudents.DisplayMemberPath = "Name";

            Binding bind = new Binding("SelectedItem.Id") {Source = ListBoxStudents};
            TxtBoxId.SetBinding(TextBox.TextProperty, bind);
        }
    }
}
