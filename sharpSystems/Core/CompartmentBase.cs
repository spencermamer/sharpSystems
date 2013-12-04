using System;
using System.Collections.Generic;
using System.Text;

namespace sharpSystems
{
    public class CompartmentBase : Component
    {
        
        public CompartmentBase(string name)
            : base(name)
        {
            base.Type = ComponentType.Compartment;
        }
    }
}
