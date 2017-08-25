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
using Wpf.binding;

namespace Wpf._11Template.StyleSetter
{
    /// <summary>
    /// MutiDataTriggerWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class MutiDataTriggerWindow1 : Window
    {
        public MutiDataTriggerWindow1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            List<StudentEntity> listStudents =new List<StudentEntity>()
            {
                new StudentEntity {Age= 10,Id = 1,Name = "Tom" },
                new StudentEntity {Age= 11,Id = 2,Name = "Tom" },
                new StudentEntity {Age= 12,Id = 3,Name = "addf" },
                new StudentEntity {Age= 13,Id = 4,Name = "immi3e" },
                new StudentEntity {Age= 14,Id = 5,Name = "gges34" },
            };
            ListBoxStudent.ItemsSource = listStudents;
        }
    }
}
