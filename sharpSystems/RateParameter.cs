using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class RateParameter : AbstractParameter
    {
        private double rate;

        public RateParameter(string name, double rxnRate)
            : base(name)
        {
            this.rate = rxnRate;
            this.MyTag = new Tag(this, "RATEPARAM_" + name);
        }

        public override double GetValue()
        {
            return rate;
        }
    }
}
