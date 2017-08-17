using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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
using System.Xml;

namespace Wpf.binding
{
    /// <summary>
    /// XmlItemSourceWindow.xaml 的交互逻辑
    /// </summary>
    public partial class XmlItemSourceWindow : Window
    {
        public XmlItemSourceWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            
            string xmlPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "binding/StudentList.xml");
            XmlDocument xmlDoc=new XmlDocument();
            xmlDoc.Load(xmlPath);

            XmlDataProvider xmlData=new XmlDataProvider();
            xmlData.Document = xmlDoc;
            xmlData.XPath = @"/StudentList/Student";

            ListViewStudent.DataContext = xmlData;
            ListViewStudent.SetBinding(ListView.ItemsSourceProperty, new Binding());
        }
    }
}
