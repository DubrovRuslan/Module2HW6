using System.Collections.Generic;
using Module2HW6.Models.Abstractions;

namespace Module2HW6.Helpers
{
    public class ElectricalAppliancePowerComparer : IComparer<ElectricalAppliance>
    {
        public int Compare(ElectricalAppliance x, ElectricalAppliance y)
        {
            return (x.Power >= y.Power) ? 1 : -1;
        }
    }
}
