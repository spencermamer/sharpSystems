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
        public abstract void Initalize();
        public abstract void RunSimulation();
    }
}
