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

namespace Wpf._4
{
    /// <summary>
    /// xStaticWindow.xaml 的交互逻辑
    /// </summary>
    public partial class xStaticWindow : Window
    {

        public static string WindowTitle = "山高月小";
        public static string ShowText { get; } = "水落石出";

        public xStaticWindow()
        {
            InitializeComponent();
        }
    }
}
