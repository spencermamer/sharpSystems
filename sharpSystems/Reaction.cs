using System;
using System.Collections.Generic;
using System.Text;

namespace sharpSystems
{
    public class Reaction : ReactionBase
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

        public double RateConst
        {
            get { return rateConst; }
            set { rateConst = value; }
        }
        private Reagent[] reagentArray;
        public Reagent[] ReagentArray
        {
            get
            {
                List<Reagent> list = new List<Reagent>();
                list.AddRange(ReactantArray);
                list.AddRange(ProductsArray);
                reagentArray = list.ToArray();
                return reagentArray;
            }
            protected set { reagentArray = value;}
        }

        // BEGIN CONSTRUCTOR DECLARATION
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
            AddReagentEntry(ReagentFactory(specie, stoich, Role.PRODUCT));
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
