using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class Reagent
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

        public int Quantity
        {
            get { return specie.Quantity; }
            set { specie.Quantity = value; }

        }
        private Role reactionRole;
        public Role ReactionRole
        {
            get { return reactionRole; }
            private set { reactionRole = value; }
        }

        private string name;
        public string Name
        {
            get { return specie.Name; }
            private set { name = value; }
        }

        // CONSTRUCTOR DECLARATIONS
        public Reagent(Specie specie, int stoich, Role role)
        {
            this.specie = specie;
            this.stoich = stoich;
            this.reactionRole = role;
        }

    }
}
