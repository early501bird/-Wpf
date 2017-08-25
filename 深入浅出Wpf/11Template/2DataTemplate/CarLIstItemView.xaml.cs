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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf._11Template._2DataTemplate
{
    /// <summary>
    /// CarLIstItemView.xaml 的交互逻辑
    /// </summary>
    public partial class CarLIstItemView : UserControl
    {
        public CarLIstItemView()
        {
            InitializeComponent();
        }
        private string root = AppDomain.CurrentDomain.BaseDirectory;

        private Car _car;

        public Car Car
        {
            get { return _car; }
            set
            {
                _car = value;
                TextBlockName.Text = _car.Name;
                TextBlockYear.Text = _car.Year;
                var uriStr = $"{root}Resources\\{Car.Name}.jpg";
                imageLogo.Source=new BitmapImage(new Uri(uriStr,UriKind.Absolute));
            }
        }
    }
}
