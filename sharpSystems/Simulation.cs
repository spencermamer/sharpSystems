using System;
using System.Collections.Generic;
using System.Text;

namespace sharpSystems
{
    public abstract class Simulation
    {
        abstract void initialize();
        abstract void reset();
        abstract void step();
    }
}
