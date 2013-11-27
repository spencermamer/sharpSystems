using System;
using System.Collections.Generic;

using System.Text;

namespace sharpSystems
{
    public class Specie : SpecieBase
    {
        
        protected Compartment location;
        public Compartment Location
        {
            get { return location; }
            protected set { location = value; }
        }
        protected int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        //BEGIN CONSTRUCTOR DECLARATIONS
        /*
        public Specie(ProtoSpecie prototype, Compartment location, int quantity)
            : base(prototype.Name)
        {
            this.myTag = prototype.MyTag;
            if (quantity >= 0)
            {
                this.quantity = quantity;
            }
            else
            {
                this.quantity = 0;
                Console.WriteLine("ERROR: Specie cannot have negative quantity");
            }
            this.location = location;
        }
        
        public Specie(ProtoSpecie prototype, Compartment location)
            : this(prototype,location, 0)
        {

        }

        */

        public Specie(ProtoSpecie proto, Compartment location, int quantity)
            : base(proto)
        {
            this.location = Location;

            if (quantity >= 0) 
            { 
                this.quantity = quantity; 
            }
            else 
            { 
                this.quantity = 0; 
            }

            this.location.AddSpecie(this);
            proto.IsUsed = true;
        }

        // BEGIN METHOD DECLARATIONS

        public void DeltaQuantity(int delta) 
        {
            if (delta <= Quantity)
            {
                Quantity += delta;
            }
        }

        
    
    }
}
