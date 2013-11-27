using System;
using System.Collections.Generic;
using System.Text;

namespace sharpSystems
{
    public class ReactionBase : Component
    {
        protected enum Role {REACTANT, PRODUCT}
        protected class Reagent
        {
            private Specie specie;
            public Specie Specie
            {
                get { return specie; }
                private set { specie = value; }
            }
            private int stoich;
            public int Stoich
            {
                get { return stoich; }
                private set { stoich = value; }
            }
            private Role reactionRole;
            public Role ReactionRole
            {
                get { return reactionRole; }
                private set { reactionRole = value; }
            }
            public Reagent(Specie specie, int stoich, Role role)
            {
                this.specie = specie;
                this.stoich = stoich;
                this.reactionRole = role;
            }
        }

        public ReactionBase(string name) : base(name) { }
    }
}
