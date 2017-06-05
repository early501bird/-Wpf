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

namespace Wpf._5
{
    /// <summary>
    /// ItemControl.xaml 的交互逻辑
    /// </summary>
    public partial class ItemControl : Window
    {
        public ItemControl()
        {
            InitializeComponent();

            List<Employee> empList = new List<Employee>
            {
                new Employee() {Id = 1, Age = 30, Name = "Tom"},
                new Employee() {Id = 2, Age = 29, Name = "Tim"},
                new Employee() {Id = 3, Age = 28, Name = "Guo"},
                new Employee() {Id = 4, Age = 30, Name = "Yan"},
                new Employee() {Id = 5, Age = 31, Name = "Owen"},
                new Employee() {Id = 6, Age = 34, Name = "Victor"}
            };

            listBoxEmplyee.DisplayMemberPath = "Name";
            listBoxEmplyee.SelectedValuePath = "Id";
            listBoxEmplyee.ItemsSource = empList;
        }

    }
}
