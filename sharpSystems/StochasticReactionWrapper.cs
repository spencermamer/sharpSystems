using System;
using System.Collections.Generic;
using System.Text;

namespace sharpSystems
{
    public class StochasticReactionWrapper : ReactionWrapper
    {

        // CONSTRUCTOR DECLARATION
        public StochasticReactionWrapper(Reaction reaction) : base(reaction) 
        {

        }
        // METHOD DECLARATIONS
        private double CalculateH()
        {
            double h = 1.0;
            foreach (Reagent rg in reactants)
            {
                h *= rg.Specie.Quantity;
            }
            return h;
        }
        
        private static double CalculateH(Reagent[] reactants) 
        {
            double h = 1.0;
            foreach(Reagent rg in reactants) 
            {
                h *= rg.Specie.Quantity;
            }
            return h;
        }

        public static double CalculatePropensity(Reaction reaction) 
        {
            return reaction.Rate * CalculateH(reaction.ReactantArray);
        }


        public override double CalculatePropensity()
        {
            propensity = rateConst * CalculateH();
            return propensity;
        }
       
    }
}
