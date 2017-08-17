using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Wpf.Route.ReportTime
{
    public class TimeButton:Button
    {
        public static readonly RoutedEvent ReportTimEvent = EventManager.RegisterRoutedEvent(
            "ReportTime", RoutingStrategy.Bubble, typeof(EventHandler<ReportTimeEventArgs>), typeof(TimeButton));
        public event RoutedEventHandler ReportTime
        {
            add { AddHandler(ReportTimEvent, value);}
            remove { RemoveHandler(ReportTimEvent, value);}
        }

        protected override void OnClick()
        {
            base.OnClick();
            
            ReportTimeEventArgs args=new ReportTimeEventArgs(ReportTimEvent,this);
            args.ClickTime = DateTime.Now;
            RaiseEvent(args);
        }
    }
}
