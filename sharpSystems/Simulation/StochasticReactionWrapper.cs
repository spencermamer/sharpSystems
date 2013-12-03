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
        
        
        public override double CalculatePropensity()
        {
            propensity = rateConst * CalculateH();
            return propensity;
        }

        private void UpdateSpecieQuantity(Reagent reagent)
        {

            switch (reagent.ReactionRole)
            {
                case Role.PRODUCT:
                    reagent.Quantity += reagent.Stoich;
                    break;
                case Role.REACTANT:
                    if (reagent.Quantity >= reagent.Stoich) 
                    {
                        reagent.Quantity -= reagent.Stoich;

                    }
                    else
                    {
                        throw new Exception("Error: Not enough " + reagent.Name + " in "+ this.Name +" (Propensity: "+Propensity+"). Something might be wrong with the stoichiometry provided.");
                    }
                    break;      
                default:
                    throw new Exception("Error: Could not determine reagent role.");
            }
        }

        public override void FireReaction()
        {
            foreach(Reagent reagent in reagents) 
            {
                UpdateSpecieQuantity(reagent);
                
            }
            // REMOVE THIS LINE
            
        }
       
    }
}
