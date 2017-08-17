using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.binding
{
    public class Student:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _name;

        public string Name
        {
            get { return Name; }
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("Name"));
            }
        }
    }
}
