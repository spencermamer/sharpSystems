using System;
using System.Collections.Generic;
using System.Text;

namespace sharpSystems
{
    public class Model
    {
        private ProtoSpecie[] protospecies;
        private Compartment[] compartments;
        private Reaction[] reactions;
        private Specie[] species;
        

        public Model(ProtoSpecie[] protospecies, Compartment[] compartments, Specie[] species, Reaction[] reactions)
        {
            this.protospecies = protospecies;
            this.compartments = compartments;
            this.species = species;
            this.reactions = reactions;
        }



        
    }
}
