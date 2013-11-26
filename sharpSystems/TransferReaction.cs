using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    /// <summary>
    /// Type of 'reaction' where one type of specie is transported from one compartment to another.
    /// </summary>
    public class TransferReaction : AbstractReaction
    {

        private static int _defaultTransferQuantity = 1;

        private int transferQuantity;

        private Tag specieTag;
        private Specie originSpecie, destSpecie;
        private Compartment origin, destination;
        private RateParameter rateParam;

        public double ReactionRate
        {
            set { rateParam.Value = value;}
            get { return rateParam.Value; }
        }

        public TransferReaction(string name, Tag specieTag, Tag originTag, Tag destTag, RateParameter rateParam) : base(name)
        {
            this.specieTag = specieTag;
            this.rateParam = rateParam;

            // Get origin compartment object from tag, then access the instance of given specie from that compartment
            this.origin = (Compartment)originTag.TaggedComponent;
            this.originSpecie = GetCompartmentSpecie(this.origin, specieTag);
           
            // Get  destinationcompartment object from tag, then access the instance of given specie from that compartment
            this.destination = (Compartment)destTag.TaggedComponent;
            this.destSpecie = GetCompartmentSpecie(this.destination, specieTag);

            transferQuantity = _defaultTransferQuantity;

            // Register the origin and destination specie instances with the superclass's List
            AddReactant(originSpecie, transferQuantity);
            AddProduct(originSpecie, transferQuantity);
        }

        private bool CompartmentHasSpecie(Compartment comp, Tag specieTag) 
        {
            return comp.HasSpecie(specieTag);
        }

        private Specie GetCompartmentSpecie(Compartment comp, Tag specieTag)
        {
            if (CompartmentHasSpecie(comp, specieTag))
            {
                return comp.GetSpecie(specieTag);
            }
            else
            {
                Console.WriteLine("Error: {0} does not contain {1}", comp.Name, specieTag.TaggedComponent.Name);
                return null;
            }

        }

        private bool HasEnoughReactant()
        {
            if (originSpecie.Quantity >= transferQuantity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void FireReaction()
        {
            if (HasEnoughReactant())
            {
                originSpecie.DeltaQuantity(-1 * transferQuantity);
                destSpecie.DeltaQuantity(transferQuantity);
                Console.WriteLine("Origin_A: {0} \t Dest_A: {1}", originSpecie.Quantity, destSpecie.Quantity);
            }
            
        }

    }
}
