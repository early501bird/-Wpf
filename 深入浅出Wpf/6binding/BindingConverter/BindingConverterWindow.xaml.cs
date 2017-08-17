using System;
using System.Collections.Generic;
using System.IO;
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

namespace Wpf.binding.BindingConverter
{
    /// <summary>
    /// BindingConverterWindow.xaml 的交互逻辑
    /// </summary>
    public partial class BindingConverterWindow : Window
    {
        public BindingConverterWindow()
        {
            InitializeComponent();
        }

        private void ButtonLoad_OnClick(object sender, RoutedEventArgs e)
        {
            List<Plane> planList = new List<Plane>
            {
                new Plane() {Category= Category.Boomber, Name="B-1", State = State.Unknown},
                new Plane() {Category= Category.Boomber,Name="B-2",State = State.Unknown},
                new Plane() {Category= Category.Boomber,Name = "F-22",State = State.Unknown},
                new Plane() {Category= Category.Fighter,Name = "Su-47",State = State.Unknown},
                new Plane(){Category = Category.Boomber,Name = "B-52",State = State.Unknown},
                new Plane(){Category = Category.Fighter,Name = "J-10",State = State.Unknown}
            };
            this.ListBoxPlane.ItemsSource = planList;
        }

        private void ButtonSave_OnClick(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Plane plan in ListBoxPlane.ItemsSource)
            {
                sb.AppendLine($"Category={plan.Category},Name={plan.Name},State={plan.State}");
            }
            File.WriteAllText(@"d:\planlist.text", sb.ToString());
        }
    }
}
