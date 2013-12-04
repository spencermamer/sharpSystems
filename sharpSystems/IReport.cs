using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public interface IReport
    {
        void Receive();
        void SendRecorderReport(Recorder recorder);

    }
}
