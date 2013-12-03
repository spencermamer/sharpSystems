using System;
using System.Collections.Generic;
using System.Text;

namespace sharpSystems
{
    public class ReactionBase : Component
    {
        protected double rate;
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public ReactionBase(string name) : base(name) { }
    }
}
