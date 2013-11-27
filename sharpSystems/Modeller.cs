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
        private List<Compartment> compartments;

        private Dictionary<Tag, ProtoSpecie> protospeciesMap;
        private Dictionary<Tag, Component> componentsMap;
        
        public Modeller() 
        {
            // Initialize the various collections used to store and map various components
            this.species = new List<Specie>();
            this.reactions = new List<Reaction>();
            this.protospeciesMap = new Dictionary<Tag, ProtoSpecie>();
        }

        /// <summary>Returns, if it exists, a ProtoSpecie mapped with a given tag</summary>
        /// <param name="protoTag">Tag assigned to desired ProtoSpecie instance</param>
        /// <returns>ProtoSpecie instance</returns>
        private ProtoSpecie GetPrototype(Tag protoTag)
        {
            return protospeciesMap[protoTag];
        }

        // Enters ProtoSpecie into dictionary, using its MyTag as the lookup key.
        private void AddProtoSpecie(ProtoSpecie proto)
        {
            protospeciesMap.Add(proto.MyTag, proto);
        }

        // Adds Specie to species list
        private void AddSpecieEntry(Specie specie)
        {
            species.Add(specie);
        }

        // Returns a species object from given prototype, located in given compartment, with given quantity of molecules
        private Specie SpecieFactory(ProtoSpecie proto, Compartment place, int quantity)
        {
            return new Specie(proto, place, quantity);
        }

        // Returns a new ProtoSpecie instance with given name.
        private ProtoSpecie ProtoSpecieFactory(string name)
        {
            return new ProtoSpecie(name);
        }
       
        // Creates a new ProtoSpecie within the model, and returns an identification tag.
        public Tag DefineNewSpecie(string name)
        {
            ProtoSpecie newProto = ProtoSpecieFactory(name);
            AddProtoSpecie(newProto);
            return newProto.MyTag;
        }

        // A specie instance based off of a protospecie is created in given compartment
        public Specie PlaceSpecie(Tag protoTag, Compartment place, int quantity = 0)
        {
            ProtoSpecie proto = GetPrototype(protoTag);
            Specie newSpecie = SpecieFactory(proto, place, quantity);
            AddSpecieEntry(newSpecie);
            return newSpecie;
        }

    }
}
