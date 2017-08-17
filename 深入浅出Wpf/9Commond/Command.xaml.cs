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

namespace Wpf._9Commond
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            InitializeCommand();
        }

        private RoutedCommand clearCmd = new RoutedCommand("Clear", typeof(Window1));

        private void InitializeCommand()
        {
            //命令赋给命令源，并指定快捷键
            Button1.Command = clearCmd;
            clearCmd.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));
            //指定目标
            Button1.CommandTarget = TextBoxA;

            //创建命令关联
            CommandBinding cb = new CommandBinding();
            cb.Command = clearCmd;
            cb.CanExecute += Cb_CanExecute;
            cb.Executed += Cb_Executed;

            //把命令关联安置在外围控件上
            StackPanel1.CommandBindings.Add(cb);
        }

        private void Cb_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TextBoxA.Clear();
            e.Handled = true;
        }

        private void Cb_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !string.IsNullOrEmpty(TextBoxA.Text);
            e.Handled = true;
        }
    }
}
