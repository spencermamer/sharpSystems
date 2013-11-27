using System;
using System.Collections.Generic;
using System.Linq;
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
        private Tag myTag;
        public Tag MyTag
        {
            get { return myTag; }
            protected set { myTag = value; }
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
            this.myTag = new Tag(this);
        }

        public Component(Component baseComponent)
        {
            // Used for a component derived from a Prototype component, such as a Species instant from a ProtoSpecie
            // In such a case, the name and tag are reassigned for that derived component, allowing
            // multiple instants of that protospecie to be seen as identical
            this.name = baseComponent.Name;
            this.myTag = baseComponent.MyTag;
        }

    }
}
