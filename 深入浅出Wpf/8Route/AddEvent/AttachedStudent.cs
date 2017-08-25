using System.Windows;

namespace Wpf.Route.AddEvent
{
    public class AttachedStudent
    {
        public static readonly RoutedEvent NameChangedEvent = EventManager.RegisterRoutedEvent("NameChanged",
            RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(AttachedStudent));

        public static void AddNameChangedHandler(DependencyObject obj, RoutedEventHandler handler)
        {
            UIElement uiElement=new UIElement();
            uiElement?.AddHandler(AttachedStudent.NameChangedEvent, handler);
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
