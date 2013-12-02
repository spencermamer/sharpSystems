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
            var pC = mlr.DefineNewSpecie("C");
            var A = mlr.PlaceSpecie(pA, cell, 5000);
            var B = mlr.PlaceSpecie(pB, cell, 0);
            var C = mlr.PlaceSpecie(pC, cell, 0);
            Reaction r1 = new Reaction("For");
            Reaction r2 = new Reaction("Rev");
            Reaction r3 = new Reaction("Alt");
            Reaction r4 = new Reaction("Altr");
            r1.AddReactant(A, 1);

            r1.AddProduct(B);
            r1.RateConst = 1;
            r2.AddReactant(B, 1);
            r2.AddProduct(A, 1);
            r2.RateConst = 0.8;
            r3.AddReactant(A);
            r3.AddProduct(C);
            r3.RateConst = 5;

            r4.AddProduct(A);
            r4.AddReactant(C);
            r4.RateConst = 0.0001;


            Specie[] reagents = new Specie[3];
            reagents[0] = A;
            reagents[1] = B;
            reagents[2] = C;

            ReactionList rlist = new ReactionList();
            rlist[0] = r1;
            rlist[1] = r2;
            rlist[2] = r3;
            rlist[3] = r4;


            Simulator sim = new GillespieStochasticSimulator(rlist, reagents);
            Controller control = new SimulationController(sim);
            control.RunSimulation();
            Console.WriteLine("Controls: \nPress 'p' key to pause and unpause simulation.\nPress 'q' key to terminate simulation.");


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
