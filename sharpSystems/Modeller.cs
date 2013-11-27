using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class Modeller
    {

        private List<Specie> species;
        private List<Reaction> reactions;

        private Dictionary<Tag, ProtoSpecie> protospeciesMap;
        private Dictionary<Tag, Component> componentsMap;
        
        public Modeller() 
        {
            // Initialize the various collections used to store and map various components
            this.species = new List<Specie>();
            this.reactions = new List<Reaction>();
            this.protospeciesMap = new Dictionary<Tag, ProtoSpecie>();
        }

        private Tag AddProtoSpecie(ProtoSpecie proto)
        {
            protospeciesMap.Add(proto.MyTag, proto);
            return proto.MyTag;
        }

        private void AddSpecie(Specie specie)
        {
            species.Add(specie);
        }

        public Tag DefineSpecie(string name)
        {
            return AddProtoSpecie(new ProtoSpecie(name));
        }

        private ProtoSpecie GetPrototype(Tag specieTag) 
        {
            return protospeciesMap[specieTag];
        }

        public Specie PlaceSpecie(Tag specieTag, Compartment place, int quantity = 0)
        {
            return new Specie(GetPrototype(specieTag), place, quantity);
        }

    }
}
