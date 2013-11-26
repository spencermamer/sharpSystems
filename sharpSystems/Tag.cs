using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class Tag
    {
        static int tagCount; 

        Component taggedComponent;
        public Component TaggedComponent
        {
            get { return taggedComponent; }
            private set { taggedComponent = value; }
        }
        
        string tagAlias;
        public string TagAlias
        {
            get { return tagAlias; }
            private set { tagAlias = value; }
        }

        int tagID;
        public int TagID
        {
            get { return tagID; }
            private set { tagID = value + 1000; }
        }

        public Tag(Component component)
        {
            this.taggedComponent = component;
            this.TagID = ++tagCount;
        }

        public Tag(Component component, string alias)
            : this(component)
        {
            this.tagAlias = alias;
        }
    }
}
