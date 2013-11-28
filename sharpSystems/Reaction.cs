using System;
using System.Collections.Generic;
using System.Text;

namespace sharpSystems
{
    public class Reaction : ReactionBase, IReactionFactory
    {
        private List<Reagent> products;

        public Reagent[] ProductsArray
        {
            get { return products.ToArray(); }
        }
        private List<Reagent> reactants;

        public Reagent[] ReactantArray
        {
            get { return reactants.ToArray(); }
        }

        private double rateConst;

        public Reaction(string name)
            : base(name)
        {
            this.products = new List<Reagent>();
            this.reactants = new List<Reagent>();

        }

        private Reagent ReagentFactory(Specie specie, int stoich, Role role)
        {
            return new Reagent(specie, stoich, role);
        }

        public void AddReactant(Specie specie, int stoich = 1)
        {
            AddReagentEntry(ReagentFactory(specie, stoich, Role.REACTANT));
        }

        public void AddProduct(Specie specie, int stoich = 1)
        {
            AddReagentEntry(ReagentFactory(specie, stoich, Role.REACTANT));
        }

        private Reagent AddReagentEntry(Reagent reagent)
        {
            switch (reagent.ReactionRole)
            {
                case Role.PRODUCT:
                    products.Add(reagent);
                    break;
                case Role.REACTANT:
                    reactants.Add(reagent);
                    break;
            }
            return reagent;
        } 

    }
}
