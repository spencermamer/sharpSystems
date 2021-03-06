﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public interface ISimulator
    {
        bool IsInitialized { get; set; }
        bool IsRunning { get; set; }
        void SetController(Controller controller);
        void SetReporter(Reporter reporter);
        void Simulate();
    }
}
