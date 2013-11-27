using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public interface IParameter
    {
        public double DoubleValue
        {
            get;
            set;
        }

        public bool IsTimeDependent
        {
            get;
            set;
        }

    }
}
