using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public struct Reagent
    {
        public int Stoich;
        public Specie aSpecie;
        public ReactionRole Role;

        public Reagent(Specie specie, int stoich, ReactionRole role)
        {
            this.aSpecie = specie;
            this.Stoich = stoich;
            this.Role = role;
        }

    }
}
