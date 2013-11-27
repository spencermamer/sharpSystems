using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace sharpSystems
{
    public class ProtoSpecie : SpecieBase
    {
        private bool isUsed = false;

        public bool IsUsed
        {
            get { return isUsed; }
            set { isUsed = value; }
        }

        public ProtoSpecie(string name) : base(name) {}


    }
}
