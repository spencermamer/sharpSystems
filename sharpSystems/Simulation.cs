using System;
using System.Collections.Generic;
using System.Text;

namespace sharpSystems
{
    public abstract class Simulation
    {
        public bool IsInitialized
        {
            set;
            get;
        }

        // CONSTRUCTOR DECLARATION
        

        // METHOD DECLARATIONS
        abstract void Initalize();
        abstract void RunSimulation();
    }
}
