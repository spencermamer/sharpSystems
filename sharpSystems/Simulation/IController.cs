using System;
namespace sharpSystems
{
    interface IController
    {
        void RunSimulation();
        void SendTerminationSignal();
        void TogglePause();
        void Reset();
    }
}
