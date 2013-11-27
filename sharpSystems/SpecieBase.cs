using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class SpecieBase : Component
    {
        
        public SpecieBase(string name)
            : base(name)
        {
            base.type = ComponentType.Specie;

        }

        public SpecieBase(SpecieBase proto) : base(proto)
        {
            base.type = ComponentType.Specie;
        }
    }
}
