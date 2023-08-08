using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code0
{
    class ShapeMath
    {
        public static double GetArea(string shape = "", 
            double length = 0, 
            double length1 = 0)
        {
            if (String.Equals("Rectangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length * length1;
            }
            else if (String.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length * (length1 / 2 );

            }
            else if (String.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return Math.PI * Math.Pow(length, 2);
            }
            else
            {
                return -1;
            }
        }
        }
}
