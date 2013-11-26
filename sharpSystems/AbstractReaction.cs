using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public abstract class AbstractReaction : Component
    {
        protected readonly static int _default_stoich = 1;

        protected RateParameter rateParameter;
        public RateParameter RateParameter
        {
            get { return rateParameter; }
            set { rateParameter = value; }
        }
        public double RateValue
        {
            get { return rateParameter.Value; }
        }

        protected List<Specie> species;
        protected List<Reagent> reactants;
        protected List<Reagent> products;

        public AbstractReaction(string name, RateParameter rateParam)
            : base(name)
        {
            this.species = new List<Specie>();
            this.reactants = new List<Reagent>();
            this.products = new List<Reagent>();
            this.rateParameter = rateParam;
        }

        public AbstractReaction(string name) : this(name, null)
        {
            
        }


        protected void AddSpecieEntry(Reagent reagent)
        {
            species.Add(reagent.aSpecie);
            // Depending on whether the reagent is a Reactant or Product, add to appropriate list
            switch (reagent.Role)
            {
                case ReactionRole.Reactant:
                    reactants.Add(reagent);
                    break;
                case ReactionRole.Product:
                    products.Add(reagent);
                    break;
                default:
                    Console.WriteLine("Error: Improper role");
                    break;
            }
        }

        public void AddReactant(Specie specie, int stoich)
        {
            Reagent reactant = new Reagent(specie, stoich, ReactionRole.Reactant);
            AddSpecieEntry(reactant);
        }

        public void AddProduct(Specie specie, int stoich)
        {
            Reagent product = new Reagent(specie, stoich, ReactionRole.Product);
            AddSpecieEntry(product);
        }

        
        /*
        public Specie[] GetSpecieArray()
        {
            return species.ToArray<Specie>();
        }

        public Specie[] GetReactants()
        {
            Specie[] reactantsArray = new Specie[reactants.Count];
            Reagent[] reagents = reactants.ToArray<Reagent>();

            for (int i = 0; i < reactants.Count; i++)
            {
                reactantsArray[i] = reagents[i].aSpecie;
            }
            return reactantsArray;
        }
         */

    }
}
