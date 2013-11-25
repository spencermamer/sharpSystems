using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpSystems
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sys = new ModelSystem("Test".ToLower());
            var cell = sys.CreateCompartment("Cell", 1.4);
            var memb = sys.CreateCompartment("membrane", 1.0);
            var A = sys.CreateNewSpecie("A");
            var B = sys.CreateNewSpecie("B");
            var C = sys.CreateNewSpecie("C");
            sys.PlaceSpecie(A, cell, 10);
            sys.PlaceSpecie(A, memb, 10);
            sys.PlaceSpecie(B, cell, 5);
            ((Compartment)cell.TaggedComponent).PrintContents();
            Console.WriteLine("Cell has C?: " + ((Compartment)cell.TaggedComponent).HasSpecie(C) + "\n");

            ((ProtoSpecie)A.TaggedComponent).PrintWhereInUse();
        }
    }
}
