using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.binding
{
    public class Caculator
    {
        public string Add(string arg1, string arg2)
        {
            double x = 0, y = 0, z = 0;
            if (double.TryParse(arg1, out x) && double.TryParse(arg2, out y))
            {
                z = x + y;
                return z.ToString();
            }
            return "imput error";
        }
    }
}
