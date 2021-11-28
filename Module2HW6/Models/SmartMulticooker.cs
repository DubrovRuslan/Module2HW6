using Module2HW6.Models.Abstractions;

namespace Module2HW6.Models
{
    public class SmartMulticooker : SmartElectricalAppliance
    {
        public int WeightOfLaundry { get; set; }

        public override ElectricalApplianceType ElectricalApplianceType => ElectricalApplianceType.SmartMulticooker;
    }
}