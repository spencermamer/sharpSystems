using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class Component
    {
        protected ComponentType type;
        
        public static int componentCount;
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

        public Component(string name)
        {
            this.name = name.ToLower();
            this.myTag = new Tag(this);
            ++componentCount;
        }

        public Component(Component baseComponent)
        {
            this.name = baseComponent.Name;
            this.myTag = baseComponent.MyTag;
            ++componentCount;
        }

    }
}
