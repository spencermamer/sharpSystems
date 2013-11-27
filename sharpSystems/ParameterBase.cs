using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public abstract class ParameterBase : Component
    {
        protected bool isTimeIndependent;

        // BEGIN CONSTRUCTOR DECLARATIONS
        public ParameterBase(string name) : base(name)
        {
            base.Type = ComponentType.Parameter;
        }

        public abstract bool IsTimeDependent { get; }
        public abstract double Value { get; }

    }
}
