using System;
using System.Collections.Generic;
using System.Text;

namespace sharpSystems
{
    public class Compartment : CompartmentBase
    {
        private double volume;
        public double Volume
        {
            get { return volume; }
            private set { volume = value; }
        }
        protected Dictionary<string, Specie> species;
        
        private Compartment parent;
        public Compartment Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        

        // BEGIN CONSTRUCTOR DECLARATIONS

        public Compartment(string name, Compartment parent, double volume) : base(name)
        {
            this.species = new Dictionary<string, Specie>();
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
            if(!HasSpecie(specie.Name) )
            {
                species.Add(specie.Name, specie);
            }
        }
        
        public bool AddSpecie(Specie specie)
        {
            if (!HasSpecie(specie.Name))
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
            foreach (KeyValuePair<string, Specie> pair in species)
            {
                Console.WriteLine("\t"+pair.Value.Name + " ("+pair.Value.Quantity+")");

            }
        }

        public bool HasSpecie(string specieName)
        {
            return species.ContainsKey(specieName);
        }

        public Specie GetSpecie(string specieName)
        {
            if (HasSpecie(specieName))
            {
                return species[specieName];
            }
            else
            {
                Console.WriteLine("Error: Compartment does not have species");
                return null;
            }
        }

    }
}
