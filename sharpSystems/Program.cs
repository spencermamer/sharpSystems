using System;
using System.Collections.Generic;

using System.Text;
using System.Threading;
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
            var pB = mlr.DefineNewSpecie("B");
            var A = mlr.PlaceSpecie(pA, cell, 5000);
            var B = mlr.PlaceSpecie(pB, cell, 100);
            Reaction r1 = new Reaction("For");
            Reaction r2 = new Reaction("Rev");

            r1.AddReactant(A, 1);

            r1.AddProduct(B);
            r1.RateConst = .001;
            r2.AddReactant(B, 1);
            r2.AddProduct(A, 1);
            r2.RateConst = .02;

           
            ReactionList rlist = new ReactionList();
            rlist[0] = r1;
            rlist[1] = r2;

            Simulator sim = new GillespieStochasticSimulator(rlist);
            Controller control = new SimulationController(sim);
            control.RunSimulation();
            bool _continue = true;
            while (_continue)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    switch (cki.KeyChar)
                    {
                        case 'p':
                            control.TogglePause();
                            break;
                        case 'q':
                            control.SendTerminationSignal();
                            _continue = false;
                            break;
                        default:
                            break;
                    }
                }
                

            }
        }
    }
}
