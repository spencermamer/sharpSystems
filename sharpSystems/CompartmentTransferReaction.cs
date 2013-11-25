using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class CompartmentTransferReaction : AbstractReaction
    {

        private static int _defaultTransferQuantity = 1;
        private Compartment origin;
        /// <summary>
        /// Defines the compartment that the specie is leaving
        /// </summary>
        public Compartment Origin
        {
            get { return origin; }
            private set { origin = value; }
        }
        private Compartment destination;
        /// <summary>
        /// Defines the compartment that the specie is entering
        /// </summary>
        public Compartment Destination
        {
            get { return destination; }
            private set { destination = value; }
        }
        private Tag specieTag;
        private Specie originSpecie;
        private Specie destSpecie;
        

        public CompartmentTransferReaction(string name, Tag specieTag, Tag originTag, Tag destTag) : base(name)
        {
            this.specieTag = specieTag;

            if (!originTag.Equals(destTag))
            {
                this.origin = (Compartment)originTag.TaggedComponent;
                this.destination = (Compartment)destTag.TaggedComponent;
                if (this.origin.HasSpecie(specieTag))
                {
                    this.originSpecie = this.origin.GetSpecie(specieTag);
                }
                if (this.destination.HasSpecie(specieTag))
                {
                    this.destSpecie = this.destination.GetSpecie(specieTag);
                }
            }
            else
            {
                Console.WriteLine("ERROR: Destination and Origin Compartment cannot be the same");
            }
            
           
        }


        public override void FireReaction()
        {
            if (ReactionVerified())
            {
                originSpecie.DeltaQuantity(-1*_defaultTransferQuantity);
                destSpecie.DeltaQuantity(_defaultTransferQuantity);
    
                Console.WriteLine("Origin_A: {0} \t Dest_A: {1}", originSpecie.Quantity, destSpecie.Quantity);

            }
        }

        public bool OriginHasEnoughSpecie()
        {
            return (originSpecie.Quantity >= _defaultTransferQuantity);
        }

        public override bool ReactionVerified()
        {
            return (NeededSpeciesExist() && OriginHasEnoughSpecie());
        }

        public override bool NeededSpeciesExist()
        {
            return origin.HasSpecie(specieTag) && destination.HasSpecie(specieTag);
        }
    }
}
