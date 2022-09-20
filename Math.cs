using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphMethod
{
    static class Math
    {
        public static Point Cramer(Limit l1, Limit l2)
        {
            double d = l1.A1 * l2.A2 - l1.A2 * l2.A1;
            double d1 = l1.B * l2.A2 - l2.B * l1.A2;
            double d2 = l1.A1 * l2.B - l2.A1 * l2.B;

            try
            {
                double x1 = d1 / d;
                double x2 = d2 / d;
                return new Point(x1, x2);
            }
            catch
            {
                return null;
            } 
        }

    }
}
