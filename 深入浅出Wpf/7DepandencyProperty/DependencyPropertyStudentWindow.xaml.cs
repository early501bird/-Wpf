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

namespace Wpf.DepandencyProperty
{
    /// <summary>
    /// DependencyPropertyStudentWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DependencyPropertyStudentWindow : Window
    {
        private Student stu;
        public DependencyPropertyStudentWindow()
        {
            InitializeComponent();

            stu=new Student();
            Binding bind=new Binding("Text") {Source = TextBox1};
            stu.SetBinding(Student.NameProperty, bind);
            TextBox2.SetBinding(TextBox.TextProperty, new Binding("Name") {Source = stu});
        }

        private void OK_OnClick(object sender, RoutedEventArgs e)
        {
            //Student stu = new Student();
            //stu.SetValue(Student.NameProperty,TextBox1.Text);
            //TextBox2.Text = stu.GetValue(Student.NameProperty).ToString();


            //MessageBox.Show(stu.GetValue(Student.NameProperty).ToString());

            //stu.Name = TextBox1.Text;
            MessageBox.Show(stu.Name);
        }
    }
}
