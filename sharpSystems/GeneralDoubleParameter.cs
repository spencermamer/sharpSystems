using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class GeneralDoubleParameter : ParameterBase
    {
        
        private double doubleValue;
        public override double Value { get { return doubleValue; } private set { doubleValue = value; } }
        public override bool IsTimeDependent
        {
            get { return false; }
        }
       
        //CONSTRUCTOR DECLARATIONS
        public GeneralDoubleParameter(string name, double value = 0.0) : base(name)
        {
            doubleValue = value;
            
        }

        // METHOD DECLARATION


    }
}
