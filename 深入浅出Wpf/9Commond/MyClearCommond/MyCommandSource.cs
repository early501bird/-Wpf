﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Wpf._9Commond.MyClearCommond
{
    public class MyCommandSource:UserControl,ICommandSource
    {
        public ICommand Command { get; set; }
        public object CommandParameter { get; set; }
        public IInputElement CommandTarget { get; set; }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            if(this.CommandTarget!=null)
                Command.Execute(CommandTarget);
        }
    }
}
