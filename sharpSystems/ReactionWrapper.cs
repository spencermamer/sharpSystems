using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace sharpSystems
{
    public abstract class ReactionWrapper
    {

        // CLASS VARIABLES

        protected Reagent[] reactants;
        protected Reagent[] products;
        protected Reagent[] reagents;

        protected double propensity; 
        protected double rateConst;
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // PROPERTIESS
        public double Propensity
        {
            get 
            {
                return CalculatePropensity(); 
            }
            private set
            {
                propensity = value;
            }
        }

       
        // CONSTUCTOR DEFINITION
        public ReactionWrapper(Reaction reaction)
        {
            this.name = reaction.Name;
            this.reactants = reaction.ReactantArray;
            this.products = reaction.ProductsArray;
            this.rateConst = reaction.RateConst;
            this.reagents = reaction.ReagentArray;
        }

        public abstract double CalculatePropensity();
        public abstract void FireReaction();
        
       


    }
}
