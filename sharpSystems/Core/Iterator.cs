using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public abstract class Iterator
    {
        public abstract object GetFirst();
        public abstract object GetNext();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
}
