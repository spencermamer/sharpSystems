using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class BaseCompartment : Component
    {
        
        public BaseCompartment(string name)
            : base(name)
        {
            base.type = ComponentType.Compartment;
        }
    }
}
