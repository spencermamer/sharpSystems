using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpSystems
{
    public abstract class Recorder : IRecord
    {
        public abstract void RecordEntry();
    }
}
