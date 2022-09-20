using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphMethod
{
    public class SystemLimits
    {
        public List<Limit> Limits { get; set; } 
        
        public SystemLimits(List<Limit> limits)
        {
            Limits = limits;
        }
    }
}
