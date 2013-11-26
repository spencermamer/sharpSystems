using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class Component
    {
        string name;
        public static int componentCount;

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        public Component(string name)
        {
            this.name = name.ToLower();
            ++componentCount;
        }

    }
}
