using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class CompartmentTransferReaction : AbstractReaction
    {
        private Compartment originCompartment;
        private Compartment destinationCompartment;

        public CompartmentTransferReaction(string name) : base(name)
        {

        }
    }
}
