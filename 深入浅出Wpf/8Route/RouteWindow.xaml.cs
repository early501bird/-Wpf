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

namespace Wpf.Route
{
    /// <summary>
    /// RouteWindow.xaml 的交互逻辑
    /// </summary>
    public partial class RouteWindow : Window
    {
        public RouteWindow()
        {
            InitializeComponent();
            GridRoot.AddHandler(Button.ClickEvent,new RoutedEventHandler(ButtonClicked));
        }

        private void ButtonClicked(object sender,RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as FrameworkElement).Name);
        }
    }
}
