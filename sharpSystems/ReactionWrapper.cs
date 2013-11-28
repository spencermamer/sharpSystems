using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public abstract class ReactionWrapper
    {
        protected Reagent[] reactants;

        protected double rateConst;

        public ReactionWrapper(Reaction reaction)
        {
            this.reactants = reaction.ReactantArray;

        }

        public abstract double CalculatePropensity();



    }
}
