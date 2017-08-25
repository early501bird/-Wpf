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

namespace Wpf._9Commond.MyClearCommond
{
    /// <summary>
    /// MiniView.xaml 的交互逻辑
    /// </summary>
    public partial class MiniView : UserControl, IView
    {
        public MiniView()
        {
            InitializeComponent();
        }

        public bool IsChanged { get; set; }
        public void SetBinding()
        {
        }

        public void Refresh()
        {
        }

        public void Save()
        {
        }

        public void Clear()
        {
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();
            TextBox4.Clear();
        }

    }
}
