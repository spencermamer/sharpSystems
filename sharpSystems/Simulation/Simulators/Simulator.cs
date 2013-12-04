using System;
using System.Collections.Generic;
using System.Text;

namespace sharpSystems
{
    public abstract class Simulator : ISimulator
    {
        protected Reporter reporter;
        protected Controller controller;

        private bool isInitialized;

        public bool IsInitialized 
        { 
            get 
            { 
                return isInitialized; 
            } 
            set 
            { 
                isInitialized = value; 
            } 
        }

        abstract public double TimeElapsed
        {
            get;
            
        }

        public abstract bool IsRunning { get; set; }


        public void SetController(Controller controller)
        {
            this.controller = controller;
        }

        public void SetReporter(Reporter reporter)
        {
            this.reporter = reporter;
        }

        public abstract void Simulate();
        
    }
}
