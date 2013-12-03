using System;
using System.Collections.Generic;

using System.Text;

namespace sharpSystems
{
    public class SpecieBase : Component
    {
        
        public SpecieBase(string name)
            : base(name)
        {
            base.Type = ComponentType.Specie;
        }

        public SpecieBase(SpecieBase proto) : base(proto.Name)
        {
            base.Type = ComponentType.Specie;
        }
    }
}
