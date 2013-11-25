using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class GenericDoubleParameter : AbstractParameter
    {
        private double value;

        public GenericDoubleParameter(string name, double value) : base(name)
        {
            this.value = value;
        }

        public override double GetValue()
        {
            return value;
        }
    }
}
