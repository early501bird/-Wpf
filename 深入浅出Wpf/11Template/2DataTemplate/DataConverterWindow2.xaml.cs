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
using Wpf._11Template._2DataTemplate;

namespace Wpf._11Template
{
    /// <summary>
    /// DataConverterWindow2.xaml 的交互逻辑
    /// </summary>
    public partial class DataConverterWindow2 : Window
    {
        public DataConverterWindow2()
        {
            InitializeComponent();
            InitCarList();
        }

        private void InitCarList()
        {
            List<Car> carList = new List<Car>()
            {
                new Car() { Automaker="11",Name = "11",Year = "1990",TopSpeed = "340"},
                new Car() { Automaker = "22", Name = "22", Year = "2001", TopSpeed = "340" },
                new Car() { Automaker = "33", Name = "33", Year = "2003", TopSpeed = "340" },
                new Car() { Automaker = "44", Name = "44", Year = "2008", TopSpeed = "340" },
                new Car() { Automaker = "55", Name = "55", Year = "2015", TopSpeed = "340" }
            };
            ListBoxCar.ItemsSource = carList;
        }
    }
}
