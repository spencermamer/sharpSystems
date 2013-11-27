using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class RateParameter : ParameterBase
    {
        public override bool IsTimeDependent
        {
            get { throw new NotImplementedException(); }
        }


        private double rateValue;
        public override double Value
        {
            get { return rateValue; }
            protected set { rateValue = value; }
        }

        public RateParameter(string name, double rateValue) : base(name) 
        {
            this.rateValue = rateValue;
        }
    }
}
