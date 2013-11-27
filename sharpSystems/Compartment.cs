using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class Compartment : CompartmentBase
    {
        private double volume;
        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        protected Dictionary<Tag, Specie> species;
        
        private Compartment parent;
        public Compartment Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        

        // BEGIN CONSTRUCTOR DECLARATIONS

        public Compartment(string name, Compartment parent, double volume) : base(name)
        {
            this.species = new Dictionary<Tag, Specie>();
            this.parent = parent;
            this.volume = volume;
        }

        public Compartment(string name, Compartment parent) : this(name, parent, 0.0) 
        {

        }
        public Compartment(string name, double volume) : this(name, null, volume)
        {
            
        }
        public Compartment(string name) : this(name, null, 0.0) { }

        // BEGIN METHOD DECLARATIONS

        private void AddSpeciesEntry(Specie specie)
        {
            if(!HasSpecie(specie.MyTag) )
            {
                species.Add(specie.MyTag, specie);
            }
        }
        
        public bool AddSpecie(Specie specie)
        {
            if (!HasSpecie(specie.MyTag))
            {
                AddSpeciesEntry(specie);
                return true;
            }
            else
            {
                Console.WriteLine("Error: compartment already contains {1}. ",specie.Name);
                return false;
            }
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

        public Specie GetSpecie(Tag specieTag)
        {
            if (HasSpecie(specieTag))
            {
                return species[specieTag];
            }
            else
            {
                Console.WriteLine("Error: Compartment does not have species");
                return null;
            }
        }

    }
}
