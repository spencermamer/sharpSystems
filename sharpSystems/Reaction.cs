using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class Reaction : AbstractReaction, IReaction
    {
       

        public Reaction(string name) : base(name)
        {
            
        }

        public void FireReaction()
        {

        }

        public Specie[] GetInvolvedSpecies()
        {
            return species.ToArray<Specie>();
        }

        

        public bool IsValidReaction()
        {
            return false;
        }

    }
}
