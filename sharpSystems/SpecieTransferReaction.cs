using System;
using System.Collections.Generic;
using System.Text;

namespace sharpSystems
{
    public class TransferReaction : Reaction
    {

        public TransferReaction TransferReactionFactory(string spName, Compartment origin, Compartment location, int stoich=1)
        {
            return new TransferReaction("transfer_" + spName, origin.GetSpecie(spName), location.GetSpecie(spName), stoich);

        }

        private TransferReaction(string name, Specie spOrigin, Specie spDest, int stoich)
            : base(name)
        {
            AddProduct(spDest, stoich);
        }
    }
}
