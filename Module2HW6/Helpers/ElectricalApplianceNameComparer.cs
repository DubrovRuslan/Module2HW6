using System.Collections.Generic;
using Module2HW6.Models.Abstractions;

namespace Module2HW6.Helpers
{
    public class ElectricalApplianceNameComparer : IComparer<ElectricalAppliance>
    {
        public int Compare(ElectricalAppliance x, ElectricalAppliance y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
