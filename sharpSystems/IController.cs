using System;
namespace sharpSystems
{
    public interface IController
    {
        void RunSimulation();
        void SendTerminationSignal();
        void TogglePause();
        void Reset();
    }
}
