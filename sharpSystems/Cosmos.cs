using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class ModelSystem
    {
        private string name;

        private Dictionary<Tag, ProtoSpecie> protoSpecies = new Dictionary<Tag, ProtoSpecie>();
        private Dictionary<Tag, Compartment> compartments = new Dictionary<Tag, Compartment>();
        private List<Specie> species = new List<Specie>();

        public ModelSystem(string name)
        {
            this.name = name;
        }

        public ModelSystem()
        {
            this.name = "Model";
        }

        private void AddProtoSpecieEntry(ProtoSpecie proto)
        {
            protoSpecies.Add(proto.Tag, proto);
        }

        private void AddCompartmentEntry(Compartment comp)
        {
            compartments.Add(comp.Tag, comp);
        }

        public Tag CreateNewSpecie(string specieName)
        {
            ProtoSpecie proto = new ProtoSpecie(specieName);
            AddProtoSpecieEntry(proto);
            return proto.Tag;
        }

        public Tag CreateCompartment(string name, double volume)
        {
            Compartment comp = new Compartment(name, volume);
            AddCompartmentEntry(comp);
            return comp.Tag;
        }


        private ProtoSpecie GetProtoSpecie(Tag specieTag) 
        {
            return protoSpecies[specieTag];
        }

        private Compartment GetCompartment(Tag compTag)
        {
            return compartments[compTag];
        }

        public void PlaceSpecie(Tag specieTag, Tag compartmentTag, int quantity)
        {
            ProtoSpecie prototype = GetProtoSpecie(specieTag);
            compartments[compartmentTag].AddSpecie(prototype, quantity);
            prototype.SetUseStatus(true);
        }

    }
}
