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

            var rxn1 = (CompartmentTransferReaction)sys.CreateTransferReaction("A move", A, cell, memb).TaggedComponent;
            while (rxn1.OriginHasEnoughSpecie())
            {
                rxn1.FireReaction();
            }
        }
    }
}
