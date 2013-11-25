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
        private Dictionary<Tag, CompartmentTransferReaction> transferReactions = new Dictionary<Tag, CompartmentTransferReaction>();
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
            protoSpecies.Add(proto.MyTag, proto);
        }

        private void AddCompartmentEntry(Compartment comp)
        {
            compartments.Add(comp.Tag, comp);
        }

        public Tag CreateNewSpecie(string specieName)
        {
            ProtoSpecie proto = new ProtoSpecie(specieName);
            AddProtoSpecieEntry(proto);
            return proto.MyTag;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="specieTag">Tag reffering to the ProtoSpecie from which the new Specie instance will be created</param>
        /// <param name="compartmentTag">Tag referring to the compartment where new Specie instance will be created</param>
        /// <param name="quantity">Initial number of molecules new Specie instance will have</param>
        public void PlaceSpecie(Tag specieTag, Tag compartmentTag, int quantity)
        {
            ProtoSpecie prototype = GetProtoSpecie(specieTag);
            Compartment location = compartments[compartmentTag];
            location.AddSpecie(prototype, quantity);
            prototype.AddLocationUseEntry(location);
        }

        private void AddTransferReactionEntry(CompartmentTransferReaction transferRxn)
        {
            transferReactions.Add(transferRxn.MyTag, transferRxn);
        }

        public Tag CreateTransferReaction(string name, Tag specieTag, Tag origin, Tag destination)
        {
            CompartmentTransferReaction transRxn = new CompartmentTransferReaction(name, specieTag, origin, destination);
            AddTransferReactionEntry(transRxn);
            return transRxn.MyTag;

        }

    }
}
