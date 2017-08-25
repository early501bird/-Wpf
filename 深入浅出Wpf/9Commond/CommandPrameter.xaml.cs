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
    /// CommandPrameter.xaml 的交互逻辑
    /// </summary>
    public partial class CommandPrameter : Window
    {
        public CommandPrameter()
        {
            InitializeComponent();
        }

        private void New_CanExcute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
        }

        private void New_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            var name = nameTextBox.Text;
            if (e.Parameter.ToString() == "Teacher")
            {
                ListBoxNewItems.Items.Add($"New Teacher:{name},学而不厌，诲人不倦");
            }
            if (e.Parameter.ToString() == "Student")
            {
                ListBoxNewItems.Items.Add($"New Student:{name},好好学习，天天向上");
            }
        }
    }
}
