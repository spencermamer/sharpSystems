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
            Modeler mlr = new Modeler();
            var cell = mlr.CreateCompartment("cell", null, 50.0);
            var pA = mlr.DefineNewSpecie("A");
            Console.WriteLine(pA);
            var pB = mlr.DefineNewSpecie("B");
            var A = mlr.PlaceSpecie(pA, cell, 5000);
            var B = mlr.PlaceSpecie(pB, cell, 100);
            Reaction r1 = new Reaction("For");
            Reaction r2 = new Reaction("Rev");

            r1.AddReactant(A, 2);

            r1.AddProduct(B);
            r1.RateConst = .001;
            r2.AddReactant(B, 1);
            r2.AddProduct(A, 2);
            r2.RateConst = .0002;

           
            ReactionList rlist = new ReactionList();
            rlist[0] = r1;
            rlist[1] = r2;

            GillespieStochasticSimulator simulator = new GillespieStochasticSimulator(rlist);
            simulator.CalculateA0();
        }
    }
}
