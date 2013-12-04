using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public abstract class Reporter : IReport
    {
        public abstract void Receive();

        public abstract void SendRecorderReport(Recorder recorder);
    }
}
