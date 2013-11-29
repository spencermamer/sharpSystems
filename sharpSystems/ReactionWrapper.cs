using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace sharpSystems
{
    public abstract class ReactionWrapper
    {
        protected Reagent[] reactants;

        protected double propensity;
        public double Propensity
        {
            get { return propensity; }
        }

        protected double rateConst;
       

        public ReactionWrapper(Reaction reaction)
        {
            this.reactants = reaction.ReactantArray;
            this.rateConst = reaction.RateConst;
        }

        public abstract double CalculatePropensity();

       


    }
}
