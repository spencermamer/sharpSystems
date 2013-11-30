using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class ReactionIterator : Iterator
    {
        private ReactionList reactions;
        private int current = 0;

        public ReactionIterator(ReactionList reactions) 
        {
            this.reactions = reactions;
        }

        public override object GetFirst()
        {
            return reactions[0];
        }

        public override object GetNext()
        {
            object next = null;
            if (current < reactions.Count)
            {
                next = reactions[current++];
            }
            return next;
        }
        public Reaction Next()
        {
            return (Reaction)GetNext();
        }
        public Reaction First()
        {
            return (Reaction)GetFirst();
        }
        public Reaction Current()
        {
            return (Reaction)Current();
        }
        public override bool IsDone()
        {
            return current >= reactions.Count ? true : false;   
        }

        public int CurrentIndex()
        {
            return current;
        }

        public override object CurrentItem()
        {
            return reactions[current];
        }


    }
}
