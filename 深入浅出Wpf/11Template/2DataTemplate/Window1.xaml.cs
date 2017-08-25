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
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            InitCarList();
        }

        private void InitCarList()
        {
            List<Car> carList = new List<Car>()
            {
                new Car() { Automaker="Lamborghini",Name = "11",Year = "1990",TopSpeed = "340"},
                new Car() { Automaker = "Lamborghini", Name = "22", Year = "2001", TopSpeed = "340" },
                new Car() { Automaker = "Lamborghini", Name = "33", Year = "2003", TopSpeed = "340" },
                new Car() { Automaker = "Lamborghini", Name = "44", Year = "2008", TopSpeed = "340" },
                new Car() { Automaker = "Lamborghini", Name = "55", Year = "2015", TopSpeed = "340" }
            };
            carList.ForEach(s =>
            {
                var view = new CarLIstItemView();
                view.Car = s;
                ListBoxCars.Items.Add(view);
            });
        }

        private void ListBoxCars_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CarLIstItemView view=e.AddedItems[0] as CarLIstItemView;
            if (view != null)
            {
                DetailView.Car = view.Car;
            }
        }
    }
}
