using System;
using System.Collections.Generic;
using System.Text;

namespace sharpSystems
{
    public abstract class Controller
    {
        abstract void SendCancelRequest();
        abstract void SendStopRequest();
        abstract void GetStatus;
    }
}
