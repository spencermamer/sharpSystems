using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class SpecieBase : Component
    {
        public static ComponentType componentType = ComponentType.Specie;

        public SpecieBase(string name)
            : base(name)
        {

        }

        public SpecieBase(SpecieBase proto) : base(proto)
        {

        }
    }
}
