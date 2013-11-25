using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class Reaction : AbstractReaction
    {
        public Reaction(string name) : base(name)
        {

        }

        public override void FireReaction()
        {
            throw new NotImplementedException();
        }

        public override bool NeededSpeciesExist()
        {
            throw new NotImplementedException();
        }

        public override bool ReactionVerified()
        {
            throw new NotImplementedException();
        }
    }
}
