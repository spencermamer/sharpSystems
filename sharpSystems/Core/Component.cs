using System;
using System.Collections.Generic;
using System.Text;

namespace sharpSystems
{
    public class Component
    {
        private ComponentType type;
        public ComponentType Type
        {
            get { return type; }
            protected set { type = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        // BEGIN CONSTRUCTOR DECLARATIONS

        
        public Component(string name)
        {
            // Every component must be defined with a name. A new tag is instantantiated and assigned
            this.name = name.ToLower();
        }



    }
}
