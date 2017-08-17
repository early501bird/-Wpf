using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf._9Commond.MyClearCommond
{
    public class ClearCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            IView view = parameter as IView;
            if (view != null) view.Clear();
        }

        public event EventHandler CanExecuteChanged;
    }
}
