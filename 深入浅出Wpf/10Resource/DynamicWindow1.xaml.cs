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

namespace Wpf._10Resource
{
    /// <summary>
    /// DynamicWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class DynamicWindow1 : Window
    {
        public DynamicWindow1()
        {
            InitializeComponent();
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            Resources["res1"]=new TextBlock() {Text="天涯共此时"};
            Resources["res2"]=new TextBlock() {Text = "天涯共此时"};
        }
    }
}
