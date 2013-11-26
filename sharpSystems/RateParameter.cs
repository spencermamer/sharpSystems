using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class RateParameter : AbstractParameter
    {
        private double rate;
        public double Value
        {
            get { return rate; }
             set { rate = value; }
        }
        public RateParameter(string name, double rxnRate)
            : base(name)
        {
            this.rate = rxnRate;
        }

        public override double GetValue()
        {
            return rate;
        }
    }
}
