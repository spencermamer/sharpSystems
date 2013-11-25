using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public abstract class AbstractParameter : Component
    {
        private Tag myTag;

        public Tag MyTag
        {
            get { return myTag; }
            protected set { myTag = value; }
        }

        public AbstractParameter(string name) : base(name) 
        {
            this.myTag = new Tag(this, "PARAMETER_" + name);
        }

        public abstract double GetValue();



    }
}
