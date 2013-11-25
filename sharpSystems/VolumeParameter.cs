using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class VolumeParameter : AbstractParameter
    {
        private double volume;

        public VolumeParameter(string name, double volume) : base(name) 
        {
            if (volume >= 0)
            {
                this.volume = volume;
            }
            else
            {
                this.volume = 0.0;
                Console.WriteLine("ERROR: Volume cannot be negative");
            }
        }

        /// <summary>
        /// Access the VolumeParameter's numerical value
        /// </summary>
        /// <returns>double value of volume in Liters</returns>
        public override double GetValue()
        {
            return volume;
        }
    }
}
