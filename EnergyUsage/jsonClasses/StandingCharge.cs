using System;

namespace EnergyUsage
{
    public class StandingChargeRootobject
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public StandingChargeResult[] results { get; set; }
    }

    public class StandingChargeResult
    {
        public string value_exc_vat { get; set; }
        public string value_inc_vat { get; set; }
        //public DateTime valid_from { get; set; }
        //public DateTime? valid_to { get; set; }

        public string valid_from { get; set; }
        public string valid_to { get; set; }
        
        public string payment_method { get; set; }
    }
}
