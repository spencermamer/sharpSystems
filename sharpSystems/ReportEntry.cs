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

        #region Constructor Declarations

        public ReportEntry(double currentTime, int[] quantities)
        {
            this.currentTimePoint = currentTime;
            this.quantities = quantities;
            this.entryString = GetReportEntryString(currentTimePoint, this.quantities);
        }
        #endregion 

        #region Method Declarations
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

        public override string ToString()
        {
            return GetReportEntryString(currentTimePoint, quantities);
        }
        #endregion
    }
}
