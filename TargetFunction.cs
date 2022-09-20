using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphMethod
{
    public class TargetFunction
    {
        public enum TargetEnum { Max, Min }
        public double C1 { get; set; }
        public double C2 { get; set; }
        public TargetEnum Target { get; set; }

        public TargetFunction(double c1, double c2, TargetEnum target)
        {
            C1 = c1;
            C2 = c2;
            Target = target;
        }

    }
}
