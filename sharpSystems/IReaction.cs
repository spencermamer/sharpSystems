using System;
using System.Collections.Generic;

using System.Text;

namespace sharpSystems
{
    public interface IReactionFactory
    {
        void AddReactant(Specie specie, int stoich = 1);
        void AddProduct(Specie specie, int stoich = 1);

    }
}
