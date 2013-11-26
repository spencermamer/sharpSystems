using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public abstract class AbstractParameter : Component
    {
        public AbstractParameter(string name) : base(name) 
        {
        }

        public abstract double GetValue();



    }
}
