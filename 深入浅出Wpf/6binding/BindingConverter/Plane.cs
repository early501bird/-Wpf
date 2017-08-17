using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.binding.BindingConverter
{
    public enum Category
    {
        Boomber,
        Fighter
    }

    public enum State
    {
        Available,
        Locked,
        Unknown
    }

    public class Plane
    {
        public Category Category { get; set; }
        public string Name { get; set; }
        public State State { get; set; }
    }
}
