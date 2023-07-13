using System;

namespace EnergyUsage
{
    /// <summary>
    /// Classes made from the json returned by Octopus.
    /// To make them copy the json file to clipboard.
    /// Goto Edit | Paste Special and paste.
    /// </summary>

    ////////////////////////////////////////////////////////////////////////////////////////////////
    // EnergyUsageRootobject and EnergyUsageResult are used when you get the usage from your Octopus account.
    public class EnergyUsageRootobject
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public EnergyUsageResult[] results { get; set; }
    }

    public class EnergyUsageResult
    {
        public double consumption { get; set; }
        public DateTime interval_start { get; set; }
        public DateTime interval_end { get; set; }
    }
}
