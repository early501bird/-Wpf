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

namespace Wpf.binding.MultiBind
{
    /// <summary>
    /// MultiBindingWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MultiBindingWindow : Window
    {
        public MultiBindingWindow()
        {
            InitializeComponent();

            SetMultiBinding();
        }

        private void SetMultiBinding()
        {
            Binding bind1 = new Binding("Text") { Source = TextBox1 };
            Binding bind2 = new Binding("Text") { Source = TextBox2 };
            Binding bind3 = new Binding("Text") { Source = TextBox3 };
            Binding bind4 = new Binding("Text") { Source = TextBox4 };

            MultiBinding multiBinding = new MultiBinding() { Mode = BindingMode.OneWay };
            multiBinding.Bindings.Add(bind1);
            multiBinding.Bindings.Add(bind2);
            multiBinding.Bindings.Add(bind3);
            multiBinding.Bindings.Add(bind4);
            multiBinding.Converter = new LogonMultiBindingConverter();
            Button1.SetBinding(Button.IsEnabledProperty, multiBinding);
        }
    }
}
