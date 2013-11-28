using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace sharpSystems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Compartment cell = new Compartment("cell", 10.0);
            ProtoSpecie pA = new ProtoSpecie("A");
            ProtoSpecie pB = new ProtoSpecie("B");

            Specie A = new Specie(pA, cell, 10);
            Specie B = new Specie(pB, cell, 500);

            Reaction rxn = new Reaction("test");
            rxn.Rate = 1.0E-9;
            rxn.AddReactant(A, 1);
            rxn.AddProduct(B, 1);

            ReactionWrapper rxnWrap = new StochasticReactionWrapper(rxn);
            Console.WriteLine(rxnWrap.CalculatePropensity());
            Console.WriteLine(StochasticReactionWrapper.CalculatePropensity(rxn));
           
        }
    }
}
