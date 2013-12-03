using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;

namespace sharpSystems
{
    public class SimulationController : Controller
    {
        private bool isRunning, isPaused;
        private Thread simulationThread;
        private Simulator simulator;

        public SimulationController(Simulator simulator)
        {
            this.simulator = simulator;
            this.simulationThread = new Thread(new ThreadStart(simulator.Simulate));
        }

        public override void SendTerminationSignal()
        {
            Console.WriteLine("Simulation Terminated!");

            simulationThread.Abort();
        }

        public override void TogglePause()
        {
            if (isRunning)
            {
                if (!isPaused)
                {
                    simulationThread.Suspend();
                    this.isPaused = true;
                    Console.WriteLine("Simulation Paused!");
                }
                else
                {
                    simulationThread.Resume();
                    this.isPaused = false;
                    Console.WriteLine("Simulation Resumed!");

                }
            }
           
           

        }

        public double TimeElapsed
        {
            get { return simulator.TimeElapsed; }
        }
        
        public override void RunSimulation()
        {
            this.isRunning = true;
            this.isPaused = false;
            simulationThread.Start();
            simulator.IsRunning = true;
            Console.WriteLine("Simulation Started!");
        }

        public override void Reset()
        {
           
        }
}
}
