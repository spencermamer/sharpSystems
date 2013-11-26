using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpSystems
{
    public class ProtoSpecie : Component
    {
        protected Tag myTag;
        private bool isInUse = false;
        public bool IsInUse
        {
            get { return isInUse; }
            private set { isInUse = value; }
        }
        private List<Compartment> specieLocations = new List<Compartment>();

        public Tag MyTag
        {
            get { return myTag; }
            protected set { myTag = value; }
        }


        /// <summary>
        /// Defines a specific type chemical compound/molecule/protein/element, typically within the ModelSystem. It serves as the "prototype" for the creation of physical instances in different Compartments. For example, 
        /// you define a prototype named "Ang-1", and when the ModelSystem PlaceSpecie method executes, it creates a Specie object instance with the same Tag and Name as the prototype within that Compartment. The Tag can be used to identify 
        /// equivalent species in different compartments, and serves as a universal look-up key to find a derived Specie in a Reaction or Compartment
        /// </summary>
        /// <param name="name">Unique string identifying the chemical specie. (e.g. "O2", "VEGFA", "mRNA"</param>
        public ProtoSpecie(string name) : base(name)
        {
            this.myTag = new Tag(this, "PROTOSPECIE_" + name); // Create a tag associated with this ProtoSpecie instance, and assign it an alias based off its name
        }

        private bool SetUseStatus(bool status) 
        {
            this.IsInUse = status;
            return IsInUse;
        }

        public void AddLocationUseEntry(Compartment comp)
        {
            specieLocations.Add(comp);
            SetUseStatus(true);
        }

        public void PrintWhereInUse()
        {
            Console.WriteLine("Specie " + this.Name + " has been placed in the following compartments:");
            foreach (Compartment comp in specieLocations)
            {
                Console.WriteLine("\t" + comp.Name);
            }
        }

    }
}
