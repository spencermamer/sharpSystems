using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public class ReportEntry
    {
        // CLASS VARIABLE DECLARATIONS
        private double currentTimePoint;
        private int[] quantities;
        private string entryString;
        public string EntryString
        {
            get { return entryString; }
            private set { this.entryString = value; }
        }

        // CONSTRUCTOR DECLARATIONS

        public ReportEntry(double currentTime, int[] quantities)
        {
            this.currentTimePoint = currentTime;
            this.quantities = quantities;
            this.entryString = GetReportEntryString(currentTimePoint, this.quantities);
        }
        
      
        // METHOD DECLARATIONS
        private string GetReportEntryString(double currentTimePoint, int[] quantities)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(currentTimePoint);

            foreach (int quantity in quantities)
            {
                sb.Append("\t" + quantity);
            }

            sb.AppendLine();

            return sb.ToString();
        }

    }
}
