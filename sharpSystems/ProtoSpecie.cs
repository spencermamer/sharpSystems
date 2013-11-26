using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpSystems
{
    public class ProtoSpecie : Component
    {
        private bool isInUse = false;
        public bool IsInUse
        {
            get { return isInUse; }
            private set { isInUse = value; }
        }

        private List<Compartment> specieLocations = new List<Compartment>();

    
        public ProtoSpecie(string name) : base(name)
        {
        }


        public void AddLocationUseEntry(Compartment comp)
        {
            specieLocations.Add(comp);
            isInUse = true;
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
