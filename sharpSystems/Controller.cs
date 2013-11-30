using System;
using System.Collections.Generic;
using System.Text;

namespace sharpSystems
{
    
    public abstract class Controller : IController
    {
        public abstract void SendTerminationSignal();
        public abstract void TogglePause();
        public abstract void RunSimulation();

        
    }
    
}
