using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class Compartment : Component
    {
        private double volume;

        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        protected Dictionary<Tag, Specie> species;
        private Tag tag;

        public Tag Tag
        {
            get { return tag; }
            private set { tag = value; }
        }

        public Compartment(string name, double volume)
            : base(name)
        {
            this.species = new Dictionary<Tag, Specie>();
            this.volume = volume;
            this.tag = new Tag(this);
        }

        public Compartment(string name) : this(name, 0.0) { }


        private void AddSpeciesEntry(Specie specie)
        {
            species.Add(specie.myTag, specie);
        }

        public Tag AddSpecie(ProtoSpecie proto, int quantity) 
        {
            Specie specie = new Specie(proto,this, quantity);
            AddSpeciesEntry(specie);
            return specie.myTag;
        }

        public void PrintContents()
        {
            Console.WriteLine(Name + "'s contents:");
            foreach (KeyValuePair<Tag, Specie> pair in species)
            {
                Console.WriteLine("\t"+pair.Value.Name + " ("+pair.Value.Quantity+")");

            }
        }

        public bool HasSpecie(Tag specieTag)
        {
            return species.ContainsKey(specieTag);
        }


    }
}
