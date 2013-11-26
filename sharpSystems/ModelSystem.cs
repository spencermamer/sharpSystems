using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class ModelSystem
    {
        private string modelName;

        private List<Specie> species = new List<Specie>();

        private Dictionary<Tag, ProtoSpecie> protoSpecies = new Dictionary<Tag, ProtoSpecie>();
        private Dictionary<Tag, Compartment> compartments = new Dictionary<Tag, Compartment>();
        private Dictionary<Tag, TransferReaction> transferReactions = new Dictionary<Tag, TransferReaction>();
        private Dictionary<Tag, Reaction> reactions = new Dictionary<Tag, Reaction>();


        public ModelSystem(string name)
        {
            this.modelName = name;
        }

        public ModelSystem()
        {
            this.modelName = "Model";
        }

        private void AddProtoSpecieEntry(ProtoSpecie proto)
        {
            protoSpecies.Add(proto.MyTag, proto);
        }

        private void AddCompartmentEntry(Compartment comp)
        {
            compartments.Add(comp.MyTag, comp);
        }

        public Tag CreateNewSpecie(string specieName)
        {
            ProtoSpecie proto = new ProtoSpecie(specieName);
            AddProtoSpecieEntry(proto);
            return proto.MyTag;
        }

        public Tag CreateCompartment(string name, Tag parentCompTag, double volume)
        {
            Compartment comp = new Compartment(name, (Compartment)parentCompTag.TaggedComponent, volume);
            AddCompartmentEntry(comp);
            return comp.MyTag;
        }

        public Tag CreateCompartment(string name, double volume)
        {
            Compartment comp = new Compartment(name, volume);
            AddCompartmentEntry(comp);
            return comp.MyTag;
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
            Compartment location = compartments[compartmentTag];
            
            species.Add(((Specie)location.AddSpecie(prototype, quantity).TaggedComponent));
            prototype.AddLocationUseEntry(location);
        }

        private void AddTransferReactionEntry(TransferReaction transferRxn)
        {
            transferReactions.Add(transferRxn.MyTag, transferRxn);
        }

        public Tag CreateTransferReaction(string name, Tag specieTag, Tag origin, Tag destination, double transferRate)
        {
            TransferReaction transRxn = new TransferReaction(name, specieTag, origin, destination, new RateParameter(name+"_transfer_rate", transferRate));
            AddTransferReactionEntry(transRxn);
            return transRxn.MyTag;
        }


        
        
    }
}
