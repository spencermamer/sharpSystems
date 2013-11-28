using System;
using System.Collections.Generic;
using System.Text;

namespace sharpSystems
{
    namespace Simulation
    {
        public abstract class Controller
        {
            public abstract void SendCancelRequest();
            public abstract void SendStopRequest();
            public abstract void GetStatus();
        }
    }
}
