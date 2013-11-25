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
            ModelSystem sys = new ModelSystem("Test");
            Tag cell = sys.CreateCompartment("Cell", 1.4);
            Tag A = sys.CreateNewSpecie("A");
            Tag B = sys.CreateNewSpecie("B");
            Tag C = sys.CreateNewSpecie("C");
            sys.PlaceSpecie(A, cell, 10);
            sys.PlaceSpecie(B, cell, 5);
            ((Compartment)cell.TaggedComponent).PrintContents();
            Console.WriteLine("Cell has C?: " + ((Compartment)cell.TaggedComponent).HasSpecie(C));

        }
    }
}
