using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public sealed class GillespieStochasticSimulator : StochasticSimulator
    {
        private ReactionList reactions;
       
        public GillespieStochasticSimulator(ReactionList reactions)
        {
            this.reactions = reactions;
            
        }

        private StochasticReactionWrapper NextReaction(ReactionIterator iter)
        {
            return new StochasticReactionWrapper(iter.Next());
        }

        private double GetReactionProbability(StochasticReactionWrapper rWrapper)
        {
            return rWrapper.CalculatePropensity();
        }

        public double CalculateA0() 
        {
            double a0 = 0;
            ReactionIterator iter = new ReactionIterator(reactions);
            while (!iter.IsDone())
            {
                a0 += GetReactionProbability(NextReaction(iter));
                Console.WriteLine(a0);
            }

            return a0;
        }

    }
}
