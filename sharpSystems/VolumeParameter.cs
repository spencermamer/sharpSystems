using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class VolumeParameter : ParameterBase
    {
        private bool isTimeDependent;
        public override bool IsTimeDependent
        {
            get { return isTimeDependent; }
            protected set { isTimeDependent = value; }
        }
        private double volumeValue;
        public override double Value
        {
            get { return volumeValue; }
            protected set { volumeValue = value; }
        }

        public VolumeParameter(string name, double volumeValue)
            : base(name)
        {
            this.volumeValue = volumeValue;
        }

        public void ChangeVolume(double newVolume)
        {
            volumeValue = newVolume;
        }

        public override string ToString()
        {
            return "Volume_" + Name + ": " + Value + " L\n";
            
        }
    }
}
