using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class ReactionList : ComponentList
    {
        private ArrayList reactions = new ArrayList();  
        
        public override Iterator CreateIterator()
        {
            return new ReactionIterator(this); 
        }

        public int Count
        {
            get 
            {
                return reactions.Count;
            }
        }

        public object this[int index]
        {
            get { return reactions[index]; }
            set { reactions.Insert(index, value); }
        }

        
    }
}
