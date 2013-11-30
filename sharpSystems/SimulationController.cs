using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;

namespace sharpSystems
{
    public class SimulationController : Controller
    {
        private bool isPaused;
        private bool isRunning;
        private Thread simulationThread;
        private Simulator simulator;

        public SimulationController(Simulator simulator)
        {
            this.simulator = simulator;
            this.simulationThread = new Thread(new ThreadStart(simulator.Simulate));
        }

        public override void SendTerminationSignal()
        {
            simulationThread.Abort();
        }

        public override void TogglePause()
        {
            if (isRunning)
            {
                if (!isPaused)
                {
                    simulationThread.Suspend();
                    Console.WriteLine("Simulation Paused!");
                }
                else
                {
                    simulationThread.Resume();
                }
            }
           
           

        }

        public double TimeElapsed
        {
            get { return simulator.TimeElapsed; }
        }
        public override void RunSimulation()
        {
            simulator.IsRunning = true;
            simulationThread.Start();
            
        }
}
}
