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

namespace Wpf.binding
{
    /// <summary>
    /// ObjectDataProviderWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class ObjectDataProviderWindow1 : Window
    {
        public ObjectDataProviderWindow1()
        {
            InitializeComponent();
            SetBinding();
        }

        private void SetBinding()
        {
            ObjectDataProvider odp = new ObjectDataProvider();
            odp.ObjectInstance = new Caculator();
            odp.MethodName = "Add";
            odp.MethodParameters.Add("0");
            odp.MethodParameters.Add("0");

            Binding bindArg1 = new Binding("MethodParameters[0]")
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            Binding bindArg2 = new Binding("MethodParameters[1]")
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            Binding bindResult = new Binding(".") { Source = odp };

            TextBoxArg1.SetBinding(TextBox.TextProperty, bindArg1);
            TextBoxArg2.SetBinding(TextBox.TextProperty, bindArg2);
            TextBoxResult.SetBinding(TextBox.TextProperty, bindResult);
        }
    }
}
